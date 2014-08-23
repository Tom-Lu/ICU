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
        }
    }
}
