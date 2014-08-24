using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.DCPwr.Interop;
using Ivi.Driver.Interop;

namespace TomLu.ICU.TestPages
{
    public partial class PageIviDCPwrBase : UserControl
    {
        private IIviDCPwr DCPwr = null;
        public PageIviDCPwrBase() : this(null)
        {
        }

        public PageIviDCPwrBase(IIviDriver Driver)
        {
            InitializeComponent();
            DCPwr = (IIviDCPwr)Driver;

            OutputTabs.TabPages.Clear();

            IIviDCPwrOutputs Outputs = DCPwr.Outputs;
            for (int i = 1; i <= Outputs.Count; i++)
            {
                string Name = Outputs.get_Name(i);
                TabPage outputPage = new TabPage(Name);
                outputPage.Controls.Add(new PageIviDCPwrOutputTab(DCPwr, Outputs.get_Item(Name)));
                OutputTabs.TabPages.Add(outputPage);
            }
        }
    }
}
