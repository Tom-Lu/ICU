using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Ivi.ConfigServer.Interop;
using System.Collections;

namespace TomLu.ICU
{
    public partial class PanelDriverSession : UserControl, IDisplayPanel
    {
        private const int VirtualNameColumnIndex = 0;
        private const int PhysicalNameColumnIndex = 1;

        private IviDriverSession DriverSession = null;
        public PanelDriverSession() : this(null)
        {
        }

        public PanelDriverSession(IviDriverSession DriverSession)
        {
            InitializeComponent();
            this.DriverSession = DriverSession;
            UpdateContent();
        }

        public void UpdateContent()
        {
            if (DriverSession != null)
            {
                name.DataBindings.Clear();
                desc.DataBindings.Clear();
                cache.DataBindings.Clear();
                interchangeCheck.DataBindings.Clear();
                rangeCheck.DataBindings.Clear();
                queryStatus.DataBindings.Clear();
                recordCoercions.DataBindings.Clear();
                simulate.DataBindings.Clear();


                Utility.BindDataSource(name, "Text", DriverSession, "Name");
                Utility.BindDataSource(desc, "Text", DriverSession, "Description");
                Utility.BindDataSource(cache, "Checked", DriverSession, "Cache");
                Utility.BindDataSource(interchangeCheck, "Checked", DriverSession, "InterchangeCheck");
                Utility.BindDataSource(rangeCheck, "Checked", DriverSession, "RangeCheck");
                Utility.BindDataSource(queryStatus, "Checked", DriverSession, "QueryInstrStatus");
                Utility.BindDataSource(recordCoercions, "Checked", DriverSession, "RecordCoercions");
                Utility.BindDataSource(simulate, "Checked", DriverSession, "Simulate");

                softwareModule.Items.AddRange(IVIHandler.Instance.GetSoftwareModuleNames().ToArray());
                hardwareAsset.Items.AddRange(IVIHandler.Instance.GetHardwareNames().ToArray());

                if (DriverSession.SoftwareModule != null)
                {
                    softwareModule.Text = DriverSession.SoftwareModule.Name;
                }

                softwareModule.SelectedValueChanged += delegate(object sender, EventArgs e)
                {
                    DriverSession.SoftwareModule = IVIHandler.Instance.GetSoftwareModule(softwareModule.Text);
                };

                if (DriverSession.HardwareAsset != null)
                {
                    hardwareAsset.Text = DriverSession.HardwareAsset.Name;
                }

                hardwareAsset.SelectedValueChanged += delegate(object sender, EventArgs e)
                {
                    DriverSession.HardwareAsset = IVIHandler.Instance.GetHarwareAsset(hardwareAsset.Text);
                };

                UpdateVirtualNameView();
            }
        }

        private void btnActiveSoftwareModule_Click(object sender, EventArgs e)
        {
            ((ConfigureExplorer)ParentForm).ActiveNode(ConfigureExplorer.NodeType.SoftwareModuleNode, softwareModule.Text);
        }

        private void btnActiveHardwareAsset_Click(object sender, EventArgs e)
        {
            ((ConfigureExplorer)ParentForm).ActiveNode(ConfigureExplorer.NodeType.HardwareNode, hardwareAsset.Text);
        }

        private void removeVirtualName_Click(object sender, EventArgs e)
        {
            if (VirtualNameView.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = VirtualNameView.SelectedRows[0];
                if (Row != null)
                {
                    string Name = (string)Row.Cells[VirtualNameColumnIndex].Value;

                    if (Name != null)
                    {
                        IviVirtualName SelectedVirtualName = IVIHandler.Instance.GetVirtualName(DriverSession, Name);
                        if (SelectedVirtualName != null)
                        {
                            DriverSession.VirtualNames.Remove(SelectedVirtualName.Name);
                            VirtualNameView.Rows.Remove(Row);
                        }
                    }
                }
            }
        }

        private void UpdateVirtualNameView()
        {
            VirtualNameView.Rows.Clear();
            IviVirtualNameCollection virtualNames = DriverSession.VirtualNames;
            foreach (IviVirtualName virtualName in virtualNames)
            {
                DataGridViewRow Row = new DataGridViewRow();

                DataGridViewTextBoxCell NameCell = new DataGridViewTextBoxCell();
                NameCell.Value = virtualName.Name;

                DataGridViewComboBoxCell PhysicalNameCell = new DataGridViewComboBoxCell();
                PhysicalNameCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                ArrayList PhysicalNameList = new ArrayList(IVIHandler.Instance.GetPhysicalNameList(DriverSession.SoftwareModule));
                if (!PhysicalNameList.Contains(virtualName.MapTo))
                {
                    PhysicalNameList.Insert(0, virtualName.MapTo);
                }

                PhysicalNameCell.Items.AddRange(PhysicalNameList.ToArray());
                PhysicalNameCell.Value = virtualName.MapTo;

                Row.Cells.AddRange(new DataGridViewCell[] { NameCell, PhysicalNameCell });

                VirtualNameView.Rows.Add(Row);
            }
        }

        private void VirtualNameView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow Row = VirtualNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[VirtualNameColumnIndex];
            DataGridViewComboBoxCell PhysicalNameCell = (DataGridViewComboBoxCell)Row.Cells[PhysicalNameColumnIndex];

            switch (e.ColumnIndex)
            {
                case VirtualNameColumnIndex:
                    {
                        if (NameCell.Value == null)
                        {
                            if (DriverSession.SoftwareModule != null)
                            {
                                IviVirtualName newVirtualName = IVIHandler.Instance.CreateVirtualName(DriverSession);
                                if (newVirtualName != null)
                                {
                                    NameCell.Value = newVirtualName.Name;

                                    ArrayList PhysicalNameList = IVIHandler.Instance.GetPhysicalNameList(DriverSession.SoftwareModule);
                                    if (!PhysicalNameList.Contains(newVirtualName.MapTo))
                                    {
                                        PhysicalNameList.Add(newVirtualName.MapTo);
                                    }
                                    PhysicalNameCell.Items.Clear();
                                    PhysicalNameCell.Items.AddRange(PhysicalNameList.ToArray());
                                    PhysicalNameCell.Value = newVirtualName.MapTo;
                                }
                            }
                            else
                            {
                                e.Cancel = true;
                                Utility.FocusControl(this, softwareModule, "{F4}");
                            }
                        }
                    }
                    break;
                case PhysicalNameColumnIndex:
                    {
                        string Name = (string)NameCell.Value;

                        if (DriverSession.SoftwareModule == null)
                        {
                            e.Cancel = true;
                            Utility.FocusControl(this, softwareModule, "{F4}");
                        }
                        else if (Name == null)
                        {
                            e.Cancel = true;
                            VirtualNameView.CurrentCell = NameCell;
                            SendKeys.Send("{F2}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void VirtualNameView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow Row = VirtualNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[VirtualNameColumnIndex];
            DataGridViewComboBoxCell PhysicalNameCell = (DataGridViewComboBoxCell)Row.Cells[PhysicalNameColumnIndex];

            switch (e.ColumnIndex)
            {
                case VirtualNameColumnIndex:
                    {
                        string OldName = (string)NameCell.Value;
                        string NewName = (string)e.FormattedValue;
                        if (NewName != null && !NewName.Equals(string.Empty))
                        {
                            if (!NewName.Equals(OldName))
                            {
                                if (null != IVIHandler.Instance.GetVirtualName(DriverSession, NewName))
                                {
                                    MessageBox.Show(string.Format("Virtual Name \'{0}\' already exist!", NewName));
                                    e.Cancel = true;
                                }
                                else
                                {
                                    IviVirtualName CurrentVirtualName = IVIHandler.Instance.GetVirtualName(DriverSession, OldName);
                                    if (CurrentVirtualName != null)
                                    {
                                        CurrentVirtualName.Name = NewName;
                                    }
                                }
                            }
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    break;
                case PhysicalNameColumnIndex:
                    {
                        string Name = (string)NameCell.Value;
                        string OldPhysicalName = (string)PhysicalNameCell.Value;
                        string NewPhysicalName = (string)e.FormattedValue;

                        if (!NewPhysicalName.Equals(OldPhysicalName))
                        {
                            // Must set DataGridView first then set the EditingControl
                            if (!PhysicalNameCell.Items.Contains(NewPhysicalName))
                            {
                                PhysicalNameCell.Items.Insert(0, NewPhysicalName);
                            }

                            DataGridViewComboBoxEditingControl ContentEditCtrl = VirtualNameView.EditingControl as DataGridViewComboBoxEditingControl;
                            if (ContentEditCtrl != null && !ContentEditCtrl.Items.Contains(NewPhysicalName))
                            {
                                ContentEditCtrl.Items.Insert(0, NewPhysicalName);
                                ContentEditCtrl.SelectedIndex = 0;
                            }

                            IviVirtualName CurrentVirtualName = IVIHandler.Instance.GetVirtualName(DriverSession, Name);
                            if (CurrentVirtualName != null)
                            {
                                CurrentVirtualName.MapTo = NewPhysicalName;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void VirtualNameView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewRow Row = VirtualNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[VirtualNameColumnIndex];
            DataGridViewComboBoxCell PhysicalNameCell = (DataGridViewComboBoxCell)Row.Cells[PhysicalNameColumnIndex];

            if (VirtualNameView.CurrentCell == PhysicalNameCell)
            {
                DataGridViewComboBoxEditingControl ContentEditCtrl = e.Control as DataGridViewComboBoxEditingControl;
                ContentEditCtrl.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

    }
}
