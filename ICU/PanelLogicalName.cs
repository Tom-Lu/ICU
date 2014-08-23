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
    public partial class PanelLogicalName : UserControl, IDisplayPanel
    {
        private IviLogicalName logicalName = null;
        public PanelLogicalName():this(null)
        {
        }

        public PanelLogicalName(IviLogicalName logicalName)
        {
            InitializeComponent();

            this.logicalName = logicalName;
            UpdateContent();
        }

        private void btnActiveDriver_Click(object sender, EventArgs e)
        {
            ((ConfigureExplorer)ParentForm).ActiveNode(ConfigureExplorer.NodeType.DriverNode, driver.Text);
        }

        public void UpdateContent()
        {
            if (logicalName != null)
            {
                name.DataBindings.Clear();
                desc.DataBindings.Clear();
                Utility.BindDataSource(name, "Text", logicalName, "Name");
                Utility.BindDataSource(desc, "Text", logicalName, "Description");

                driver.Items.AddRange(IVIHandler.Instance.GetDriverNames().ToArray());
                if (logicalName.Session != null)
                {
                    driver.Text = logicalName.Session.Name;
                }

                driver.SelectedValueChanged += delegate(object sender, EventArgs e)
                {
                    logicalName.Session = (IviSession)IVIHandler.Instance.GetDriverSession(driver.Text);
                };
            }
        }
    }
}
