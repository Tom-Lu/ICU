using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.SessionFactory.Interop;
using Ivi.Driver.Interop;
using TomLu.ICU.TestPages;
using System.Collections;

namespace TomLu.ICU
{
    public partial class PanelTest : UserControl
    {
        private IIviDriver Driver = null;
        private TabPage IviDriverPage = null;
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
            IviDriverPage = this.driverTab;

            SetupCallbacks();

        }

        private void SetupCallbacks()
        {
            UtilityResetBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.Utility.Reset();
                }
            };

            UtilityResetDefaultBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.Utility.ResetWithDefaults();
                }
            };

            SelfTestBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    int TestResult = 0;
                    string TestMessage = string.Empty;
                    Driver.Utility.SelfTest(ref TestResult, ref TestMessage);
                    SelfTestResult.Text = string.Format("({0}){1}", TestResult, TestMessage);
                }
            };

            ErrorQueryBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    int ErrorCode = 0;
                    string ErrorMessage = string.Empty;
                    Driver.Utility.ErrorQuery(ref ErrorCode, ref ErrorMessage);
                    ErrorStatus.Text = string.Format("({0}){1}", ErrorCode, ErrorMessage);
                }
            };

            Cache.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.Cache = Cache.Checked;
                }
            };

            InterchangeCheck.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.InterchangeCheck = InterchangeCheck.Checked;
                }
            };

            RangeCheck.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.RangeCheck = RangeCheck.Checked;
                }
            };

            QueryStatus.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.QueryInstrumentStatus = QueryStatus.Checked;
                }
            };

            RecordCoercions.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.RecordCoercions = RecordCoercions.Checked;
                }
            };

            Simulate.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Driver != null && Driver.Initialized)
                {
                    Driver.DriverOperation.Simulate = Simulate.Checked;
                }
            };
        }

        private void DisplayIviTestPages()
        {
            IviFunctionTab.Controls.Clear();
            IviFunctionTab.Controls.Add(IviDriverPage);

            if (Driver.Initialized)
            {
                ArrayList Capabilities = new ArrayList(Driver.Identity.GroupCapabilities.Split(','));
                if (Capabilities.Contains("IviDmmBase"))
                {
                    TabPage dmmTab = new TabPage("DMM");
                    dmmTab.Controls.Add(new PageIviDmmBase(Driver));
                    IviFunctionTab.Controls.Add(dmmTab);
                }
            }
        }

        private void LogicalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder driverInfo = new StringBuilder();
            if (!LogicalName.Text.Equals(string.Empty))
            {
                Driver = (IIviDriver)IVIHandler.Instance.SessionFactory.CreateDriver(LogicalName.Text);

                if (Driver != null)
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
            if (Driver != null)
            {
                DriverPropertyView.Items.Clear();
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Identifier", Driver.Identity.Identifier }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Revision", Driver.Identity.Revision }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "Description", Driver.Identity.Description }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SupportedInstrumentModels", Driver.Identity.SupportedInstrumentModels }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SpecificationMajorVersion", Driver.Identity.SpecificationMajorVersion.ToString() }));
                DriverPropertyView.Items.Add(new ListViewItem(new string[] { "SpecificationMinorVersion", Driver.Identity.SpecificationMinorVersion.ToString() }));

                if (Driver.Initialized)
                {
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentModel", Driver.Identity.InstrumentModel }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentFirmwareRevision", Driver.Identity.InstrumentFirmwareRevision }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "InstrumentManufacturer", Driver.Identity.InstrumentManufacturer }));
                    DriverPropertyView.Items.Add(new ListViewItem(new string[] { "GroupCapabilities", Driver.Identity.GroupCapabilities }));
                }
            }

            DisplayDriverOptions();
            DisplayIviTestPages();
        }

        public void DisplayDriverOptions()
        {
            if (Driver != null && Driver.Initialized)
            {
                IoResDesc.Text = Driver.DriverOperation.IoResourceDescriptor;
                DriverSetup.Text = Driver.DriverOperation.DriverSetup;
                Cache.Checked = Driver.DriverOperation.Cache;
                InterchangeCheck.Checked = Driver.DriverOperation.InterchangeCheck;
                RangeCheck.Checked = Driver.DriverOperation.RangeCheck;
                QueryStatus.Checked = Driver.DriverOperation.QueryInstrumentStatus;
                RecordCoercions.Checked = Driver.DriverOperation.RecordCoercions;
                Simulate.Checked = Driver.DriverOperation.Simulate;
            }
        }

        private void Init_CLose_Btn_Click(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                if (!Driver.Initialized)
                {
                    Driver.Initialize(LogicalName.Text, IdQuery.Checked, Reset.Checked);
                    if (Driver.Initialized)
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
                    Driver.Close();
                    DisplayDriverInfo();
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
