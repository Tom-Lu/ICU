using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.ConfigServer.Interop;

namespace TomLu.ICU
{
    public partial class PanelHardwareAsset : UserControl, IDisplayPanel
    {
        private IviHardwareAsset hardwareAsset = null;

        public PanelHardwareAsset() : this(null)
        {

        }

        public PanelHardwareAsset(IviHardwareAsset hardwareAsset)
        {
            InitializeComponent();
            this.hardwareAsset = hardwareAsset;
            UpdateContent();
        }

        public void UpdateContent()
        {
            if (hardwareAsset != null)
            {
                name.DataBindings.Clear();
                desc.DataBindings.Clear();
                Utility.BindDataSource(name, "Text", hardwareAsset, "Name");
                Utility.BindDataSource(desc, "Text", hardwareAsset, "Description");
                name.Text = hardwareAsset.Name;
                desc.Text = hardwareAsset.Description;
                ioResourceDesc.Text = hardwareAsset.IOResourceDescriptor;

                ioResourceDesc.TextChanged += delegate(object sender, EventArgs e)
                {
                    hardwareAsset.IOResourceDescriptor = ioResourceDesc.Text;
                };
            }           
        }
    }
}
