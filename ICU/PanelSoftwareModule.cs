using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Ivi.ConfigServer.Interop;
using System.Threading;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;

namespace TomLu.ICU
{
    public partial class PanelSoftwareModule : UserControl, IDisplayPanel
    {
        private IIviSoftwareModule2 SoftwareModule = null;
        private IviPublishedAPI currentPublishedAPI = null;
        private const int PublishedAPINameColumn = 0;
        private const int PublishedAPIVersionColumn = 1;
        private const int PublishedAPITypeColumn = 2;

        private const int PhysicalNameColumn = 0;
        private const int RCNameColumn = 1;

        private delegate void DelegateFunction();
        public PanelSoftwareModule()
            : this(null)
        {
        }

        public PanelSoftwareModule(IIviSoftwareModule2 softwareModule)
        {
            InitializeComponent();
            this.SoftwareModule = softwareModule;
            UpdateContent();
        }

        public void UpdateContent()
        {
            if (SoftwareModule != null)
            {
                name.DataBindings.Clear();
                desc.DataBindings.Clear();
                prefix.DataBindings.Clear();
                progId.DataBindings.Clear();
                qualifiedClassName.DataBindings.Clear();
                modulePath32.DataBindings.Clear();
                modulePath64.DataBindings.Clear();

                Utility.BindDataSource(name, "Text", SoftwareModule, "Name");
                Utility.BindDataSource(desc, "Text", SoftwareModule, "Description");
                Utility.BindDataSource(prefix, "Text", SoftwareModule, "Prefix");
                Utility.BindDataSource(progId, "Text", SoftwareModule, "ProgID");
                Utility.BindDataSource(qualifiedClassName, "Text", SoftwareModule, "AssemblyQualifiedClassName");
                Utility.BindDataSource(modulePath32, "Text", SoftwareModule, "ModulePath32");
                Utility.BindDataSource(modulePath64, "Text", SoftwareModule, "ModulePath64");

                supportedInstModules.Text = SoftwareModule.SupportedInstrumentModels.Replace(",", "\r\n");


                UpdatePhysicalNameView();
                UpdatePublishedAPIView();

                SetupCallbacks();
            }
        }

        private void SetupCallbacks()
        {
            btnPath32.Click += delegate(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    modulePath32.Text = dialog.FileName;
                }
            };

            btnPath64.Click += delegate(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    modulePath64.Text = dialog.FileName;
                }
            };

            supportedInstModules.TextChanged += delegate(object sender, EventArgs e)
            {
                SoftwareModule.SupportedInstrumentModels = supportedInstModules.Text.Replace("\r\n", ",");
            };
        }

        #region PublishedAPI

        private void goGlobalAPIs_Click(object sender, EventArgs e)
        {
            ((ConfigureExplorer)ParentForm).ActiveNode(ConfigureExplorer.NodeType.GlobalPublishedAPI, null);
        }

        private void PublishedApiRemoveBtn_Click(object sender, EventArgs e)
        {
            if (PublishedAPIView.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = PublishedAPIView.SelectedRows[0];
                if (Row != null)
                {
                    IviPublishedAPI SelectedAPI = GetPublishedAPI(Row, false);
                    if (SelectedAPI != null)
                    {
                        SoftwareModule.PublishedAPIs.Remove(SelectedAPI.Name, SelectedAPI.MajorVersion, SelectedAPI.MinorVersion, SelectedAPI.Type);
                        PublishedAPIView.Rows.Remove(Row);
                    }
                }
            }
        }

        private void UpdatePublishedAPIView()
        {
            PublishedAPIView.Rows.Clear();
            foreach (IviPublishedAPI publishedAPI in SoftwareModule.PublishedAPIs)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewComboBoxCell nameCell = new DataGridViewComboBoxCell();
                nameCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                nameCell.Items.AddRange(IVIHandler.Instance.GetGlobalPublishedAPINameList().ToArray());
                nameCell.Value = publishedAPI.Name;

                DataGridViewComboBoxCell versionCell = new DataGridViewComboBoxCell();
                versionCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                versionCell.Items.AddRange(IVIHandler.Instance.GetGlobalPublishedAPIVersionList(publishedAPI.Name).ToArray());
                versionCell.Value = String.Format("{0}.{1}", publishedAPI.MajorVersion, publishedAPI.MinorVersion);

                DataGridViewComboBoxCell typeCell = new DataGridViewComboBoxCell();
                typeCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                typeCell.Items.AddRange(IVIHandler.Instance.GetGlobalPublishedAPITypeList(publishedAPI.Name, publishedAPI.MajorVersion, publishedAPI.MinorVersion).ToArray());
                typeCell.Value = publishedAPI.Type;

                row.Cells.AddRange(new DataGridViewCell[] { nameCell, versionCell, typeCell });

                PublishedAPIView.Rows.Add(row);
            }
        }

        private void PublishedAPIView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                EventHandler SelectedIndexChangedHandler = null;
                EventHandler LeaveHandler = null;

                DataGridViewComboBoxEditingControl ContentEditCtrl = e.Control as DataGridViewComboBoxEditingControl;
                ContentEditCtrl.DropDownStyle = ComboBoxStyle.DropDown;

                DataGridViewRow Row = PublishedAPIView.CurrentRow;
                DataGridViewComboBoxCell NameCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPINameColumn];
                DataGridViewComboBoxCell VersionCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPIVersionColumn];
                DataGridViewComboBoxCell TypeCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPITypeColumn];

                switch (PublishedAPIView.CurrentCell.ColumnIndex)
                {
                    case PublishedAPINameColumn:
                        {
                            ContentEditCtrl.SelectedIndexChanged += SelectedIndexChangedHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                string Name = ContentEditCtrl.Text;

                                if (!Name.Equals(NameCell.Value))
                                {
                                    NameCell.Value = Name;
                                    VersionCell.Items.Clear();
                                    VersionCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPIVersionList((IviSoftwareModule)SoftwareModule, Name).ToArray());
                                    VersionCell.Value = VersionCell.Items[0];

                                    string Version = (string)VersionCell.Value;
                                    int MajorVersion = int.Parse(Version.Split('.')[0]);
                                    int MinorVersion = int.Parse(Version.Split('.')[1]);

                                    TypeCell.Items.Clear();
                                    TypeCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPITypeList((IviSoftwareModule)SoftwareModule, Name, MajorVersion, MinorVersion).ToArray());
                                    TypeCell.Value = TypeCell.Items[0];

                                    IviPublishedAPI NewAPI = GetPublishedAPI(Row, true);
                                    UpdateOrAddPublishedAPI(this.currentPublishedAPI, NewAPI);
                                }
                            };

                            ContentEditCtrl.Leave += LeaveHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                ContentEditCtrl.SelectedIndexChanged -= SelectedIndexChangedHandler;
                                ContentEditCtrl.Leave -= LeaveHandler;
                            };
                        }
                        break;
                    case PublishedAPIVersionColumn:
                        {
                            ContentEditCtrl.SelectedIndexChanged += SelectedIndexChangedHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                string Version = ContentEditCtrl.Text;

                                if (!Version.Equals(VersionCell.Value))
                                {
                                    VersionCell.Value = Version;
                                    string Name = (string)NameCell.Value;
                                    int MajorVersion = int.Parse(Version.Split('.')[0]);
                                    int MinorVersion = int.Parse(Version.Split('.')[1]);

                                    VersionCell.Value = Version;
                                    TypeCell.Items.Clear();
                                    TypeCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPITypeList((IviSoftwareModule)SoftwareModule, Name, MajorVersion, MinorVersion).ToArray());
                                    TypeCell.Value = TypeCell.Items[0];

                                    IviPublishedAPI NewAPI = GetPublishedAPI(Row, true);
                                    UpdateOrAddPublishedAPI(this.currentPublishedAPI, NewAPI);
                                }
                            };

                            ContentEditCtrl.Leave += LeaveHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                ContentEditCtrl.SelectedIndexChanged -= SelectedIndexChangedHandler;
                                ContentEditCtrl.Leave -= LeaveHandler;
                            };
                        }
                        break;
                    case PublishedAPITypeColumn:
                        {
                            ContentEditCtrl.SelectedIndexChanged += SelectedIndexChangedHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                string Type = ContentEditCtrl.Text;

                                TypeCell.Value = Type;
                                IviPublishedAPI NewAPI = GetPublishedAPI(Row, true);
                                UpdateOrAddPublishedAPI(this.currentPublishedAPI, NewAPI);
                            };

                            ContentEditCtrl.Leave += LeaveHandler = delegate(object event_sender, EventArgs eArg)
                            {
                                ContentEditCtrl.SelectedIndexChanged -= SelectedIndexChangedHandler;
                                ContentEditCtrl.Leave -= LeaveHandler;
                            };
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        private void PublishedAPIView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow Row = PublishedAPIView.CurrentRow;
            DataGridViewComboBoxCell NameCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPINameColumn];
            DataGridViewComboBoxCell VersionCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPIVersionColumn];
            DataGridViewComboBoxCell TypeCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPITypeColumn];

            switch (e.ColumnIndex)
            {
                case PublishedAPINameColumn:
                    {
                        NameCell.Items.Clear();
                        NameCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPINameList((IviSoftwareModule)SoftwareModule, NameCell.Value).ToArray());
                        SendKeys.Send("{F4}");
                    }
                    break;
                case PublishedAPIVersionColumn:
                    {
                        string Name = (string)NameCell.Value;

                        if (Name == null)
                        {
                            NameCell.Items.Clear();
                            NameCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPINameList((IviSoftwareModule)SoftwareModule, NameCell.Value).ToArray());
                            PublishedAPIView.CurrentCell = NameCell;
                            SendKeys.Send("{F4}");
                        }
                        else
                        {
                            VersionCell.Items.Clear();
                            VersionCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPIVersionList((IviSoftwareModule)SoftwareModule, Name, VersionCell.Value).ToArray());
                            SendKeys.Send("{F4}");
                        }
                    }
                    break;
                case PublishedAPITypeColumn:
                    {
                        string Name = (string)NameCell.Value;
                        string Version = (string)VersionCell.Value;

                        if (Name == null)
                        {
                            NameCell.Items.Clear();
                            NameCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPINameList((IviSoftwareModule)SoftwareModule, NameCell.Value).ToArray());
                            PublishedAPIView.CurrentCell = NameCell;
                            SendKeys.Send("{F4}");
                        }
                        else if (Version == null)
                        {
                            VersionCell.Items.Clear();
                            VersionCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPIVersionList((IviSoftwareModule)SoftwareModule, Name, VersionCell.Value).ToArray());
                            PublishedAPIView.CurrentCell = VersionCell;
                            SendKeys.Send("{F4}");
                        }
                        else
                        {
                            int MajorVersion = int.Parse(Version.Split('.')[0]);
                            int MinorVersion = int.Parse(Version.Split('.')[1]);
                            TypeCell.Items.Clear();
                            TypeCell.Items.AddRange(IVIHandler.Instance.GetUnusedGlobalPublishedAPITypeList((IviSoftwareModule)SoftwareModule, Name, MajorVersion, MinorVersion, TypeCell.Value).ToArray());
                            SendKeys.Send("{F4}");
                        }
                    }
                    break;
                default:
                    break;
            }

            if (e.RowIndex == PublishedAPIView.RowCount - 1 && PublishedAPIView.AllowUserToAddRows)
            {
                currentPublishedAPI = null;
            }
            else
            {
                currentPublishedAPI = GetPublishedAPI(Row, false);
            }
        }

        private IviPublishedAPI GetPublishedAPI(DataGridViewRow Row, bool Global)
        {
            IviPublishedAPI ResultPublishedAPI = null;
            DataGridViewComboBoxCell NameCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPINameColumn];
            DataGridViewComboBoxCell VersionCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPIVersionColumn];
            DataGridViewComboBoxCell TypeCell = (DataGridViewComboBoxCell)Row.Cells[PublishedAPITypeColumn];

            string Name = (string)NameCell.Value;
            string Version = (string)VersionCell.Value;
            string Type = (string)TypeCell.Value;

            if (Name != null && Version != null && Type != null)
            {
                int MajorVersion = int.Parse(Version.Split('.')[0]);
                int MinorVersion = int.Parse(Version.Split('.')[1]);

                if (Global)
                {
                    ResultPublishedAPI = IVIHandler.Instance.GetGlobalPublishedAPI(Name, MajorVersion, MinorVersion, Type);
                }
                else
                {
                    ResultPublishedAPI = IVIHandler.Instance.GetPublishedAPI((IviSoftwareModule)SoftwareModule, Name, MajorVersion, MinorVersion, Type);
                }
            }

            return ResultPublishedAPI;
        }

        private void UpdateOrAddPublishedAPI(IviPublishedAPI OriginalAPI, IviPublishedAPI NewAPI)
        {
            if (OriginalAPI != null)
            {
                SoftwareModule.PublishedAPIs.Remove(OriginalAPI.Name, OriginalAPI.MajorVersion, OriginalAPI.MinorVersion, OriginalAPI.Type);
            }
            SoftwareModule.PublishedAPIs.Add(NewAPI);
        }

        #endregion

        #region Physical Names

        private void PhysicalNameRemoveBtn_Click(object sender, EventArgs e)
        {
            if (PhysicalNameView.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = PhysicalNameView.SelectedRows[0];
                if (Row != null)
                {
                    string Name = (string)Row.Cells[PhysicalNameColumn].Value;

                    if (Name != null)
                    {
                        IviPhysicalName SelectedPhysicalName = IVIHandler.Instance.GetPhysicalName((IviSoftwareModule)SoftwareModule, Name);
                        if (SelectedPhysicalName != null)
                        {
                            SoftwareModule.PhysicalNames.Remove(SelectedPhysicalName.Name);
                            PhysicalNameView.Rows.Remove(Row);
                        }
                    }
                }
            }
        }

        private void UpdatePhysicalNameView()
        {
            PhysicalNameView.Rows.Clear();
            IviPhysicalNameCollection physicalNames = SoftwareModule.PhysicalNames;
            foreach (IviPhysicalName physicalName in physicalNames)
            {
                DataGridViewRow Row = new DataGridViewRow();

                DataGridViewTextBoxCell NameCell = new DataGridViewTextBoxCell();
                NameCell.Value = physicalName.Name;

                DataGridViewComboBoxCell RCNameCell = new DataGridViewComboBoxCell();
                RCNameCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                ArrayList RCNameList = new ArrayList(IVIHandler.RCNameList);
                if (!RCNameList.Contains(physicalName.RCName))
                {
                    RCNameList.Insert(0, physicalName.RCName);
                }

                RCNameCell.Items.AddRange(RCNameList.ToArray());
                RCNameCell.Value = physicalName.RCName;

                Row.Cells.AddRange(new DataGridViewCell[] { NameCell, RCNameCell });

                PhysicalNameView.Rows.Add(Row);
            }
        }

        private void PhysicalNameView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow Row = PhysicalNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[PhysicalNameColumn];
            DataGridViewComboBoxCell RCNameCell = (DataGridViewComboBoxCell)Row.Cells[RCNameColumn];

            switch (e.ColumnIndex)
            {
                case PhysicalNameColumn:
                    {
                        string OldName = (string)NameCell.Value;
                        string NewName = (string)e.FormattedValue;
                        if (NewName != null && !NewName.Equals(string.Empty))
                        {
                            if (!NewName.Equals(OldName))
                            {
                                if (null != IVIHandler.Instance.GetPhysicalName((IviSoftwareModule)SoftwareModule, NewName))
                                {
                                    MessageBox.Show(string.Format("Physical Name \'{0}\' already exist!", NewName));
                                    e.Cancel = true;
                                }
                                else
                                {
                                    IviPhysicalName CurrentPhysicalName = IVIHandler.Instance.GetPhysicalName((IviSoftwareModule)SoftwareModule, OldName);
                                    if (CurrentPhysicalName != null)
                                    {
                                        CurrentPhysicalName.Name = NewName;
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
                case RCNameColumn:
                    {
                        string Name = (string)NameCell.Value;
                        string OldRCName = (string)RCNameCell.Value;
                        string NewRCName = (string)e.FormattedValue;

                        if (!NewRCName.Equals(OldRCName))
                        {
                            // Must set DataGridView first then set the EditingControl
                            if (!RCNameCell.Items.Contains(NewRCName))
                            {
                                RCNameCell.Items.Insert(0, NewRCName);
                            }

                            DataGridViewComboBoxEditingControl ContentEditCtrl = PhysicalNameView.EditingControl as DataGridViewComboBoxEditingControl;
                            if (ContentEditCtrl != null && !ContentEditCtrl.Items.Contains(NewRCName))
                            {
                                ContentEditCtrl.Items.Insert(0, NewRCName);
                                ContentEditCtrl.SelectedIndex = 0;
                            }

                            IviPhysicalName CurrentPhysicalName = IVIHandler.Instance.GetPhysicalName((IviSoftwareModule)SoftwareModule, Name);
                            if (CurrentPhysicalName != null)
                            {
                                CurrentPhysicalName.RCName = NewRCName;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void PhysicalNameView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewRow Row = PhysicalNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[PhysicalNameColumn];
            DataGridViewComboBoxCell RCNameCell = (DataGridViewComboBoxCell)Row.Cells[RCNameColumn];

            if (PhysicalNameView.CurrentCell == RCNameCell)
            {
                DataGridViewComboBoxEditingControl ContentEditCtrl = e.Control as DataGridViewComboBoxEditingControl;
                ContentEditCtrl.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void PhysicalNameView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow Row = PhysicalNameView.CurrentRow;
            DataGridViewTextBoxCell NameCell = (DataGridViewTextBoxCell)Row.Cells[PhysicalNameColumn];
            DataGridViewComboBoxCell RCNameCell = (DataGridViewComboBoxCell)Row.Cells[RCNameColumn];

            switch (e.ColumnIndex)
            {
                case PhysicalNameColumn:
                    {
                        if (NameCell.Value == null)
                        {
                            IviPhysicalName newPhysicalName = IVIHandler.Instance.CreatePhysicalName((IviSoftwareModule)SoftwareModule);
                            if (newPhysicalName != null)
                            {
                                NameCell.Value = newPhysicalName.Name;
                                RCNameCell.Value = newPhysicalName.RCName;
                                RCNameCell.Items.Clear();
                                RCNameCell.Items.AddRange(IVIHandler.RCNameList);
                            }
                        }
                    }
                    break;
                case RCNameColumn:
                    {
                        string Name = (string)NameCell.Value;

                        if (Name == null)
                        {
                            PhysicalNameView.CurrentCell = NameCell;
                            e.Cancel = true;
                            SendKeys.Send("{F2}");
                        }
                        else
                        {

                            ArrayList RCNameList = new ArrayList(IVIHandler.RCNameList);
                            if (!RCNameList.Contains(RCNameCell.Value))
                            {
                                RCNameList.Insert(0, RCNameCell.Value);
                            }

                            RCNameCell.Items.Clear();
                            RCNameCell.Items.AddRange(RCNameList.ToArray());
                            SendKeys.Send("{F4}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

