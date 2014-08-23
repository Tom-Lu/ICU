using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.ConfigServer.Interop;
using System.Threading;
using System.Text.RegularExpressions;

namespace TomLu.ICU
{
    public partial class PanelPublishedAPIs : UserControl, IDisplayPanel
    {
        private delegate void DelegateFunction();

        public PanelPublishedAPIs()
        {
            InitializeComponent();
            UpdateContent();
        }

        public void UpdateContent()
        {

            publishedAPIList.Items.Clear();
            IviPublishedAPICollection publishedAPIs = IVIHandler.Instance.IviConfigStore.PublishedAPIs;
            foreach (IviPublishedAPI publishedAPI in publishedAPIs)
            {
                publishedAPIList.Items.Add(new ListViewItem(new string[] { publishedAPI.Name, String.Format("{0}.{1}", publishedAPI.MajorVersion, publishedAPI.MinorVersion), publishedAPI.Type }));
            }

        }

        private void publishedApiAddBtn_Click(object sender, EventArgs e)
        {
            FormAddPublishedAPI addAPIDialog = new FormAddPublishedAPI();
            if (addAPIDialog.ShowDialog() != DialogResult.Cancel)
            {
                UpdateContent();
            }
        }

        private void publishedApiRemoveBtn_Click(object sender, EventArgs e)
        {
            if (publishedAPIList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = publishedAPIList.SelectedItems[0];
                IVIHandler.Instance.IviConfigStore.PublishedAPIs.Remove(selectedItem.SubItems[0].Text, int.Parse(selectedItem.SubItems[1].Text.Split('.')[0]), int.Parse(selectedItem.SubItems[1].Text.Split('.')[1]), selectedItem.SubItems[2].Text);
                publishedAPIList.Items.Remove(selectedItem);
            }
        }
    }
}