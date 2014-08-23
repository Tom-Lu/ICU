using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.SessionFactory.Interop;
using Ivi.Driver.Interop;

namespace TomLu.ICU
{
    public partial class PanelTest : UserControl
    {
        private IIviDriver driver = null;
        public PanelTest()
        {
            InitializeComponent();

            IdQuery.Enabled = false;
            Reset.Enabled = false;
            Init_Close_Btn.Enabled = false;
            LogicalName.Enabled = true;
            DriverUtility.Enabled = false;
            DriverOptions.Enabled = false;

            LogicalName.Items.Clear();
            LogicalName.Items.AddRange(IVIHandler.Instance.GetLogicalNames().ToArray());

            SetupCallbacks();
        }

        private void SetupCallbacks()
        {
            UtilityResetBtn.Click += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.Utility.Reset();
                }
            };

            UtilityResetDefaultBtn.Click += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.Utility.ResetWithDefaults();
                }
            };

            SelfTestBtn.Click += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    int TestResult = 0;
                    string TestMessage = string.Empty;
                    driver.Utility.SelfTest(ref TestResult, ref TestMessage);
                    SelfTestResult.Text = string.Format("({0}){1}", TestResult, TestMessage);
                }
            };

            ErrorQueryBtn.Click += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    int ErrorCode = 0;
                    string ErrorMessage = string.Empty;
                    driver.Utility.ErrorQuery(ref ErrorCode, ref ErrorMessage);
                    ErrorStatus.Text = string.Format("({0}){1}", ErrorCode, ErrorMessage);
                }
            };

            Cache.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.Cache = Cache.Checked;
                }
            };

            InterchangeCheck.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.InterchangeCheck = InterchangeCheck.Checked;
                }
            };

            RangeCheck.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.RangeCheck = RangeCheck.Checked;
                }
            };

            QueryStatus.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.QueryInstrumentStatus = QueryStatus.Checked;
                }
            };

            RecordCoercions.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.RecordCoercions = RecordCoercions.Checked;
                }
            };

            Simulate.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (driver != null && driver.Initialized)
                {
                    driver.DriverOperation.Simulate = Simulate.Checked;
                }
            };
        }

        private void LogicalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder driverInfo = new StringBuilder();
            if (!LogicalName.Text.Equals(string.Empty))
            {
                driver = (IIviDriver)IVIHandler.Instance.SessionFactory.CreateDriver(LogicalName.Text);

                if (driver != null)
                {
                    DisplayDriverInfo();
                    IdQuery.Enabled = true;
                    Reset.Enabled = true;
                    Init_Close_Btn.Enabled = true;
                }
                else
                {
                    IdQuery.Enabled = false;
                    Reset.Enabled = false;
                    Init_Close_Btn.Enabled = false;
                }
            }
        }

        private void DisplayDriverInfo()
        {
            if (driver != null)
            {
                DriverPropertyView.Items.Clear();
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Identifier", driver.Identity.Identifier }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Revision", driver.Identity.Revision }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Description", driver.Identity.Description }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SupportedInstrumentModels", driver.Identity.SupportedInstrumentModels }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SpecificationMajorVersion", driver.Identity.SpecificationMajorVersion.ToString() }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SpecificationMinorVersion", driver.Identity.SpecificationMinorVersion.ToString() }));

                if (driver.Initialized)
                {
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentModel", driver.Identity.InstrumentModel }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentFirmwareRevision", driver.Identity.InstrumentFirmwareRevision }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentManufacturer", driver.Identity.InstrumentManufacturer }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "GroupCapabilities", driver.Identity.GroupCapabilities }));
                }
            }

            DisplayDriverOptions();
        }

        public void DisplayDriverOptions()
        {
            if (driver != null && driver.Initialized)
            {
                IoResDesc.Text = driver.DriverOperation.IoResourceDescriptor;
                DriverSetup.Text = driver.DriverOperation.DriverSetup;
                Cache.Checked = driver.DriverOperation.Cache;
                InterchangeCheck.Checked = driver.DriverOperation.InterchangeCheck;
                RangeCheck.Checked = driver.DriverOperation.RangeCheck;
                QueryStatus.Checked = driver.DriverOperation.QueryInstrumentStatus;
                RecordCoercions.Checked = driver.DriverOperation.RecordCoercions;
                Simulate.Checked = driver.DriverOperation.Simulate;
            }
        }

        private void Init_CLose_Btn_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                if (!driver.Initialized)
                {
                    driver.Initialize(LogicalName.Text, IdQuery.Checked, Reset.Checked);
                    if (driver.Initialized)
                    {
                        DisplayDriverInfo();
                        Init_Close_Btn.Text = "Close";
                        LogicalName.Enabled = false;
                        DriverUtility.Enabled = true;
                        DriverOptions.Enabled = true;
                        IdQuery.Enabled = false;
                        Reset.Enabled = false;
                    }
                    else
                    {
                        Init_Close_Btn.Text = "Initialize";
                    }
                }
                else
                {
                    driver.Close();
                    Init_Close_Btn.Text = "Initialize";
                    LogicalName.Enabled = true;
                    DriverUtility.Enabled = false;
                    DriverOptions.Enabled = false;
                    IdQuery.Enabled = true;
                    Reset.Enabled = true;
                }
            }
        }

    }
}
