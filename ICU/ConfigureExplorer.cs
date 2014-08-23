using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ivi.ConfigServer.Interop;

namespace TomLu.ICU
{
    public partial class ConfigureExplorer : Form
    {
        private IviConfigStore iviConfigStore;
        private TreeNode systemInfoNode;
        private TreeNode logicalNameNode;
        private TreeNode hardwareAssetNode;
        private TreeNode driverSessionNode;
        private TreeNode softwareModuleNode;
        private TreeNode publishedAPINode;
        private Control activePanel = null;
        private ArrayList navigationList = null;
        private int navigationIndex = -1;

        public enum NodeType { Unknow, DriverNode, HardwareNode, LogicalNameNode, SoftwareModuleNode, GlobalPublishedAPI };

        public ConfigureExplorer()
        {
            InitializeComponent();

            navigationList = new ArrayList();
            DisplayConfigStore();
        }

        private void ConfigStoreRefresh_Click(object sender, EventArgs e)
        {
            IVIHandler.Reset();
            DisplayConfigStore();
        }

        private void ConfigStoreSave_Click(object sender, EventArgs e)
        {
            IVIHandler.Instance.Save();
        }

        private void ExplorerTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;

            if ((currentNode.Parent != systemInfoNode) || (currentNode == publishedAPINode) && currentNode != navigationList[navigationList.Count - 1])
            {
                navigationList.Add(currentNode);
                navigationIndex = navigationList.Count - 1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (--navigationIndex >= 0)
            {
                ActiveNode((TreeNode)navigationList[navigationIndex]);
            }
            else
            {
                navigationIndex = 0;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (++navigationIndex < navigationList.Count)
            {
                ActiveNode((TreeNode)navigationList[navigationIndex]);
            }
            else
            {
                navigationIndex = navigationList.Count - 1;
            }
        }

        private void ExplorerTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;

            if (currentNode.Equals(systemInfoNode))
            {
                activePanel = new PanelSystemInfo();
            }
            else if (currentNode == publishedAPINode)
            {
                activePanel = new PanelPublishedAPIs();
            }
            else if (currentNode.Parent != null)
            {
                switch (GetNodeType(currentNode))
                {
                    case NodeType.LogicalNameNode:
                        activePanel = new PanelLogicalName(iviConfigStore.LogicalNames[currentNode.Text]);
                        break;
                    case NodeType.HardwareNode:
                        activePanel = new PanelHardwareAsset(iviConfigStore.HardwareAssets[currentNode.Text]);
                        break;
                    case NodeType.DriverNode:
                        activePanel = new PanelDriverSession(iviConfigStore.DriverSessions[currentNode.Text]);
                        break;
                    case NodeType.SoftwareModuleNode:
                        activePanel = new PanelSoftwareModule((IIviSoftwareModule2)iviConfigStore.SoftwareModules[currentNode.Text]);
                        break;
                    default:
                        activePanel = null;
                        break;
                }
            }

            if (activePanel != null)
            {
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(activePanel);
                splitContainer1.Panel2.Refresh();
            }
        }

        private void ExplorerTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                TreeNode currentNode = e.Node;
                switch (GetNodeType(currentNode))
                {
                    case NodeType.LogicalNameNode:
                        IVIHandler.Instance.GetLogicalName(currentNode.Text).Name = e.Label;
                        ((IDisplayPanel)activePanel).UpdateContent();
                        break;
                    case NodeType.HardwareNode:
                        IVIHandler.Instance.GetHarwareAsset(currentNode.Text).Name = e.Label;
                        ((IDisplayPanel)activePanel).UpdateContent();
                        break;
                    case NodeType.DriverNode:
                        IVIHandler.Instance.GetDriverSession(currentNode.Text).Name = e.Label;
                        ((IDisplayPanel)activePanel).UpdateContent();
                        break;
                    case NodeType.SoftwareModuleNode:
                        IVIHandler.Instance.GetSoftwareModule(currentNode.Text).Name = e.Label;
                        ((IDisplayPanel)activePanel).UpdateContent();
                        break;
                    default:
                        break;
                }
                ActiveNode(currentNode, false);
            }
        }

        private NodeType GetNodeType(TreeNode CurrentNode)
        {
            if (CurrentNode.Parent.Equals(logicalNameNode))
            {
                return NodeType.LogicalNameNode;
            }
            else if (CurrentNode.Parent.Equals(hardwareAssetNode))
            {
                return NodeType.HardwareNode;
            }
            else if (CurrentNode.Parent.Equals(driverSessionNode))
            {
                return NodeType.DriverNode;
            }
            else if (CurrentNode.Parent.Equals(softwareModuleNode))
            {
                return NodeType.SoftwareModuleNode;
            }

            return NodeType.Unknow;
        }

        private void ActiveNode(TreeNode Node, bool NameEdit = false)
        {
            if (Node != null)
            {
                ExplorerTree.SelectedNode = Node;
                if (NameEdit)
                {
                    Node.BeginEdit();
                }
            }
        }

        public void ActiveNode(NodeType type, string Name, bool NameEdit = false)
        {
            TreeNode node = null;

            switch (type)
            {
                case NodeType.DriverNode:
                    node = driverSessionNode;
                    break;

                case NodeType.HardwareNode:
                    node = hardwareAssetNode;
                    break;

                case NodeType.LogicalNameNode:
                    node = logicalNameNode;
                    break;

                case NodeType.SoftwareModuleNode:
                    node = softwareModuleNode;
                    break;

                case NodeType.GlobalPublishedAPI:
                    node = publishedAPINode;
                    break;

                default:
                    break;
            }

            if (node != null)
            {
                TreeNode targetNode = Name == null ? node : node.Nodes[Name];
                if (targetNode != null)
                {
                    ExplorerTree.SelectedNode = targetNode;

                    if (NameEdit)
                    {
                        targetNode.BeginEdit();
                    }
                }
            }
        }

        public void DisplayConfigStore()
        {
            iviConfigStore = IVIHandler.Instance.IviConfigStore;
            if (iviConfigStore != null)
            {
                this.Text = "IVI Configuration Utility - " + iviConfigStore.MasterLocation;
                ExplorerTree.Nodes.Clear();
                ExplorerTree.LabelEdit = true;

                iviConfigStore.Deserialize(iviConfigStore.MasterLocation);

                systemInfoNode = new TreeNode("System");
                systemInfoNode.ImageKey = "icon_pc.png";
                systemInfoNode.SelectedImageKey = "icon_pc.png";

                logicalNameNode = new TreeNode("Logical Names");
                logicalNameNode.ImageKey = "icon_alias.png";
                logicalNameNode.SelectedImageKey = "icon_alias.png";

                hardwareAssetNode = new TreeNode("Hardware Asset");
                hardwareAssetNode.ImageKey = "icon_hardware.png";
                hardwareAssetNode.SelectedImageKey = "icon_hardware.png";

                driverSessionNode = new TreeNode("Driver Sessions");
                driverSessionNode.ImageKey = "icon_driver.png";
                driverSessionNode.SelectedImageKey = "icon_driver.png";

                softwareModuleNode = new TreeNode("Software Modules");
                softwareModuleNode.ImageKey = "icon_software.png";
                softwareModuleNode.SelectedImageKey = "icon_software.png";

                publishedAPINode = new TreeNode("Global Published APIs");
                publishedAPINode.ImageKey = "icon_software.png";
                publishedAPINode.SelectedImageKey = "icon_software.png";


                ExplorerTree.Nodes.Add(systemInfoNode);

                systemInfoNode.Nodes.Add(logicalNameNode);
                systemInfoNode.Nodes.Add(driverSessionNode);
                systemInfoNode.Nodes.Add(hardwareAssetNode);
                systemInfoNode.Nodes.Add(softwareModuleNode);
                systemInfoNode.Nodes.Add(publishedAPINode);

                DisplayLogicalNames();
                DisplayHardwareAssets();
                DisplayDriverSessions();
                DisplaySoftwareModules();

                systemInfoNode.Expand();
                ExplorerTree.SelectedNode = systemInfoNode;

                navigationList.Clear();
                navigationList.Add(systemInfoNode);

            }
        }

        #region Logical Name

        private void DisplayLogicalNames()
        {
            IviLogicalNameCollection logicalNames = iviConfigStore.LogicalNames;

            foreach (IviLogicalName logicalName in logicalNames)
            {
                TreeNode newLogicalNameNode = logicalNameNode.Nodes.Add(logicalName.Name, logicalName.Name);
                SetupLogicalNameNodeMenu(newLogicalNameNode);
            }

            logicalNameNode.ContextMenu = new ContextMenu();
            logicalNameNode.ContextMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e){
                AddLogicalName();
            }));
        }

        private void AddLogicalName()
        {
            IviLogicalName newLogicalName = IVIHandler.Instance.CreateLogicalName();
            TreeNode newNode = logicalNameNode.Nodes.Add(newLogicalName.Name, newLogicalName.Name);
            SetupLogicalNameNodeMenu(newNode);
            ActiveNode(newNode, true);
        }

        private void SetupLogicalNameNodeMenu(TreeNode Node)
        {
            ContextMenu LogicalNameNodeMenu = new ContextMenu();

            LogicalNameNodeMenu.MenuItems.Add(new MenuItem("Rename ...", delegate(object sender, EventArgs e)
            {
                Node.BeginEdit();
            }));

            LogicalNameNodeMenu.MenuItems.Add(new MenuItem("Delete", delegate(object sender, EventArgs e)
            {
                IVIHandler.Instance.IviConfigStore.LogicalNames.Remove(Node.Text);
                ActiveNode(Node.PrevNode);
                Node.Parent.Nodes.Remove(Node);
            }));

            LogicalNameNodeMenu.MenuItems.Add(new MenuItem("-"));
            LogicalNameNodeMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e){
                AddLogicalName();
            }));

            Node.ContextMenu = LogicalNameNodeMenu;
        }

        #endregion

        #region Hardware Asset

        private void DisplayHardwareAssets()
        {
            IviHardwareAssetCollection hardwareAssets = iviConfigStore.HardwareAssets;
            foreach (IviHardwareAsset hardwareAsset in hardwareAssets)
            {
                TreeNode newHardwareAssetNode = hardwareAssetNode.Nodes.Add(hardwareAsset.Name, hardwareAsset.Name);
                SetupHardwareAssetNodeMenu(newHardwareAssetNode);
            }

            hardwareAssetNode.ContextMenu = new ContextMenu();
            hardwareAssetNode.ContextMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddHardwareAsset();
            }));
        }

        private void AddHardwareAsset()
        {
            IviHardwareAsset newHardwareAsset = IVIHandler.Instance.CreateHardwareAsset();
            TreeNode newNode = hardwareAssetNode.Nodes.Add(newHardwareAsset.Name, newHardwareAsset.Name);
            SetupHardwareAssetNodeMenu(newNode);
            ActiveNode(newNode, true);
        }

        private void SetupHardwareAssetNodeMenu(TreeNode Node)
        {
            ContextMenu HardwareAssetNodeMenu = new ContextMenu();

            HardwareAssetNodeMenu.MenuItems.Add(new MenuItem("Rename ...", delegate(object sender, EventArgs e)
            {
                Node.BeginEdit();
            }));

            HardwareAssetNodeMenu.MenuItems.Add(new MenuItem("Delete", delegate(object sender, EventArgs e)
            {
                IVIHandler.Instance.IviConfigStore.HardwareAssets.Remove(Node.Text);
                ActiveNode(Node.PrevNode);
                Node.Parent.Nodes.Remove(Node);
            }));

            HardwareAssetNodeMenu.MenuItems.Add(new MenuItem("-"));
            HardwareAssetNodeMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddHardwareAsset();
            }));

            Node.ContextMenu = HardwareAssetNodeMenu;
        }

        #endregion

        #region Driver Session

        private void DisplayDriverSessions()
        {
            IviDriverSessionCollection driverSessions = iviConfigStore.DriverSessions;
            foreach (IviDriverSession driverSession in driverSessions)
            {
                TreeNode newDriverSessionNode = driverSessionNode.Nodes.Add(driverSession.Name, driverSession.Name);
                SetupDriverSessionNodeMenu(newDriverSessionNode);
            }

            driverSessionNode.ContextMenu = new ContextMenu();
            driverSessionNode.ContextMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddDriverSession();
            }));
        }

        private void AddDriverSession()
        {
            IviDriverSession newDriverSession = IVIHandler.Instance.CreateDriverSession();
            TreeNode newNode = driverSessionNode.Nodes.Add(newDriverSession.Name, newDriverSession.Name);
            SetupDriverSessionNodeMenu(newNode);
            ActiveNode(newNode, true);
        }

        private void SetupDriverSessionNodeMenu(TreeNode Node)
        {
            ContextMenu DriverSessionNodeMenu = new ContextMenu();

            DriverSessionNodeMenu.MenuItems.Add(new MenuItem("Rename ...", delegate(object sender, EventArgs e)
            {
                Node.BeginEdit();
            }));

            DriverSessionNodeMenu.MenuItems.Add(new MenuItem("Delete", delegate(object sender, EventArgs e)
            {
                IVIHandler.Instance.IviConfigStore.DriverSessions.Remove(Node.Text);
                ActiveNode(Node.PrevNode);
                Node.Parent.Nodes.Remove(Node);
            }));

            DriverSessionNodeMenu.MenuItems.Add(new MenuItem("-"));
            DriverSessionNodeMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddDriverSession();
            }));

            Node.ContextMenu = DriverSessionNodeMenu;
        }

        #endregion

        #region Software Module

        private void DisplaySoftwareModules()
        {
            IviSoftwareModuleCollection softwareModules = iviConfigStore.SoftwareModules;
            foreach (IviSoftwareModule softwareModule in softwareModules)
            {
                TreeNode softwareNode = softwareModuleNode.Nodes.Add(softwareModule.Name, softwareModule.Name);
                SetupSoftwareModuleNodeMenu(softwareNode);
            }

            softwareModuleNode.ContextMenu = new ContextMenu();
            softwareModuleNode.ContextMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddSoftwareModule();
            }));
        }

        private void AddSoftwareModule()
        {
            IIviSoftwareModule newSoftwareModule = IVIHandler.Instance.CreateSoftwareModule();
            TreeNode newNode = softwareModuleNode.Nodes.Add(newSoftwareModule.Name, newSoftwareModule.Name);
            SetupSoftwareModuleNodeMenu(newNode);
            ActiveNode(newNode, true);
        }

        private void SetupSoftwareModuleNodeMenu(TreeNode Node)
        {
            ContextMenu SoftwareModuleNodeMenu = new ContextMenu();

            SoftwareModuleNodeMenu.MenuItems.Add(new MenuItem("Rename ...", delegate(object sender, EventArgs e)
            {
                Node.BeginEdit();
            }));

            SoftwareModuleNodeMenu.MenuItems.Add(new MenuItem("Delete", delegate(object sender, EventArgs e)
            {
                IVIHandler.Instance.IviConfigStore.SoftwareModules.Remove(Node.Text);
                ActiveNode(Node.PrevNode);
                Node.Parent.Nodes.Remove(Node);
            }));

            SoftwareModuleNodeMenu.MenuItems.Add(new MenuItem("-"));
            SoftwareModuleNodeMenu.MenuItems.Add(new MenuItem("Create New ...", delegate(object sender, EventArgs e)
            {
                AddSoftwareModule();
            }));

            Node.ContextMenu = SoftwareModuleNodeMenu;
        }

        #endregion

    }
}
