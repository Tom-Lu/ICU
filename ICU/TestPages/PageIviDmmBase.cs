using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.Dmm.Interop;
using Ivi.Driver.Interop;

namespace TomLu.ICU.TestPages
{
    public partial class PageIviDmmBase : UserControl
    {
        private IIviDmm Dmm = null;
        public PageIviDmmBase() : this(null)
        {
        }

        public PageIviDmmBase(IIviDriver Driver)
        {
            InitializeComponent();
            Dmm = (IIviDmm)Driver;
            IviDmmFunction.Items.Clear();
            IviDmmFunction.Items.AddRange(Enum.GetNames(typeof(IviDmmFunctionEnum)));
            IviDmmFunction.Text = (string)IviDmmFunction.Items[0];
        }

        private void ConfigureBtn_Click(object sender, EventArgs e)
        {
            if (Dmm != null)
            {
                Dmm.Configure((IviDmmFunctionEnum)Enum.Parse(typeof(IviDmmFunctionEnum), IviDmmFunction.Text), double.Parse(Range.Text), double.Parse(Resolution.Text));
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (Dmm != null)
            {
                ReadValue.Text = Dmm.Measurement.Read(int.Parse(Timeout.Text)).ToString();
            }
        }
    }
}
