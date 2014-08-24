using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.Driver.Interop;
using Ivi.DCPwr.Interop;

namespace TomLu.ICU.TestPages
{
    public partial class PageIviDCPwrOutputTab : UserControl
    {
        private IIviDCPwr DCPwr = null;
        private IIviDCPwrOutput Output = null;
        public PageIviDCPwrOutputTab() : this(null, null)
        {
        }

        public PageIviDCPwrOutputTab(IIviDCPwr DCPwr, IIviDCPwrOutput Output)
        {
            InitializeComponent();
            this.DCPwr = DCPwr;
            this.Output = Output;

            UpdateControlValues();
            SetupCallbacks();
        }

        private void UpdateControlValues()
        {
            if (Output != null)
            {
                OutputVoltageLevel.Text = Output.VoltageLevel.ToString();
                OutputCurrentLimit.Text = Output.CurrentLimit.ToString();
                OutputEnableBtn.Checked = Output.Enabled;
                OutputEnableBtn.Text = OutputEnableBtn.Checked ? "On" : "Off";

                CurrentLimitBehavior.Items.Clear();
                CurrentLimitBehavior.Items.AddRange(Enum.GetNames(typeof(IviDCPwrCurrentLimitBehaviorEnum)));
                CurrentLimitBehavior.Text = Output.CurrentLimitBehavior.ToString();

                RangeType.Items.Clear();
                RangeType.Items.AddRange(Enum.GetNames(typeof(IviDCPwrRangeTypeEnum)));
                RangeType.Text = (string)RangeType.Items[0];

                RangeValue.Text = "0.0";
                OVPLimit.Text = Output.OVPLimit.ToString();
                OVPEnable.Checked = Output.OVPEnabled;

                TriggerSource.Items.Clear();
                TriggerSource.Items.AddRange(Enum.GetNames(typeof(IviDCPwrTriggerSourceEnum)));
                TriggerSource.Text = Output.TriggerSource.ToString();
                TriggerVoltageLevel.Text = Output.TriggeredVoltageLevel.ToString();
                TriggerCurrentLimit.Text = Output.TriggeredCurrentLimit.ToString();

                MeasureType.Items.Clear();
                MeasureType.Items.AddRange(Enum.GetNames(typeof(IviDCPwrMeasurementTypeEnum)));
                MeasureType.Text = (string)MeasureType.Items[0];
                MeasureResult.Text = "";

            }       
        }

        private void SetupCallbacks()
        {
            //                 
            OutputVoltageLevel.TextChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.VoltageLevel = double.Parse(OutputVoltageLevel.Text);
            };

            OutputCurrentLimit.TextChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.CurrentLimit = double.Parse(OutputCurrentLimit.Text);
            };

            CurrentLimitBehavior.SelectedIndexChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.CurrentLimitBehavior = (IviDCPwrCurrentLimitBehaviorEnum)Enum.Parse( typeof(IviDCPwrCurrentLimitBehaviorEnum), CurrentLimitBehavior.Text);
            };

            OVPLimit.TextChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.OVPLimit = double.Parse(OVPLimit.Text);
            };

            OVPEnable.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.OVPEnabled = OVPEnable.Checked;
            };

            TriggerSource.SelectedIndexChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.TriggerSource = (IviDCPwrTriggerSourceEnum)Enum.Parse(typeof(IviDCPwrTriggerSourceEnum), TriggerSource.Text);
            };

            TriggerVoltageLevel.TextChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.TriggeredVoltageLevel = double.Parse(TriggerVoltageLevel.Text);
            };

            TriggerCurrentLimit.TextChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.TriggeredCurrentLimit = double.Parse(TriggerCurrentLimit.Text);
            };

            OutputEnableBtn.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.Enabled = OutputEnableBtn.Checked;
                OutputEnableBtn.Text = OutputEnableBtn.Checked ? "On" : "Off";
            };

            RangConfigureBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    Output.ConfigureRange((IviDCPwrRangeTypeEnum)Enum.Parse(typeof(IviDCPwrRangeTypeEnum), RangeType.Text), double.Parse(RangeValue.Text));
            };

            MeasureBtn.Click += delegate(object sender, EventArgs e)
            {
                if (Output != null)
                    MeasureResult.Text = Output.Measure((IviDCPwrMeasurementTypeEnum)Enum.Parse(typeof(IviDCPwrMeasurementTypeEnum), MeasureType.Text)).ToString();
            };
        }
    }
}
