using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ivi.ConfigServer.Interop;

namespace TomLu.ICU
{
    public partial class FormAddPublishedAPI : Form
    {
        public FormAddPublishedAPI()
        {
            InitializeComponent();

            APIName.Items.AddRange(IVIHandler.Instance.GetGlobalPublishedAPINameList().ToArray());
            APIName.Text = (string)APIName.Items[0];

            MajorVersion.Text = "1";
            MinorVersion.Text = "0";

            Type.Items.AddRange(new string[] { "IVI-C", "IVI-COM", "IVI.NET" });
            Type.Text = (string)Type.Items[0];

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string Name = APIName.Text;
            int majorVersion = int.Parse(MajorVersion.Text);
            int minorVersion = int.Parse(MinorVersion.Text);
            string type = Type.Text;

            IviPublishedAPI ExistAPI = IVIHandler.Instance.GetGlobalPublishedAPI(Name, majorVersion, minorVersion, type);
            if (ExistAPI != null)
            {
                MessageBox.Show("PublishedAPI already exist, duplicate item not allowed!");
            }
            else
            {
                IviPublishedAPI NewAPI = new IviPublishedAPI();
                NewAPI.Name = Name;
                NewAPI.MajorVersion = majorVersion;
                NewAPI.MinorVersion = minorVersion;
                NewAPI.Type = type;
                IVIHandler.Instance.IviConfigStore.PublishedAPIs.Add(NewAPI);

                DialogResult = System.Windows.Forms.DialogResult.OK;

                Close();
            }

        }
    }
}
