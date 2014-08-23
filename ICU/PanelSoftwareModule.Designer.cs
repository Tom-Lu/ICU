namespace TomLu.ICU
{
    partial class PanelSoftwareModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modulePath32 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modulePath64 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.supportedInstModules = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PhysicalNameView = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhysicalNameRemoveBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PublishedAPIView = new System.Windows.Forms.DataGridView();
            this.PublishedAPIName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PublishedAPIVersion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PublishedAPIType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goGlobalAPIs = new System.Windows.Forms.Button();
            this.PublishedApiRemoveBtn = new System.Windows.Forms.Button();
            this.btnPath32 = new System.Windows.Forms.Button();
            this.btnPath64 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.qualifiedClassName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalNameView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PublishedAPIView)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(51, 8);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(157, 21);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 48);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(453, 70);
            this.desc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // modulePath32
            // 
            this.modulePath32.Location = new System.Drawing.Point(128, 207);
            this.modulePath32.Name = "modulePath32";
            this.modulePath32.Size = new System.Drawing.Size(264, 21);
            this.modulePath32.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ModulePath(32bit)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "ModulePath(64bit)";
            // 
            // modulePath64
            // 
            this.modulePath64.Location = new System.Drawing.Point(128, 232);
            this.modulePath64.Name = "modulePath64";
            this.modulePath64.Size = new System.Drawing.Size(264, 21);
            this.modulePath64.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prefix";
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(52, 129);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(156, 21);
            this.prefix.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "ProgID";
            // 
            // progId
            // 
            this.progId.Location = new System.Drawing.Point(265, 129);
            this.progId.Name = "progId";
            this.progId.Size = new System.Drawing.Size(200, 21);
            this.progId.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 264);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 276);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.supportedInstModules);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Supported Instrument Models";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // supportedInstModules
            // 
            this.supportedInstModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supportedInstModules.Location = new System.Drawing.Point(3, 3);
            this.supportedInstModules.Multiline = true;
            this.supportedInstModules.Name = "supportedInstModules";
            this.supportedInstModules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supportedInstModules.Size = new System.Drawing.Size(436, 244);
            this.supportedInstModules.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PhysicalNameView);
            this.tabPage2.Controls.Add(this.PhysicalNameRemoveBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Physical Names";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PhysicalNameView
            // 
            this.PhysicalNameView.AllowUserToDeleteRows = false;
            this.PhysicalNameView.AllowUserToResizeRows = false;
            this.PhysicalNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhysicalNameView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2});
            this.PhysicalNameView.Location = new System.Drawing.Point(3, 3);
            this.PhysicalNameView.MultiSelect = false;
            this.PhysicalNameView.Name = "PhysicalNameView";
            this.PhysicalNameView.RowHeadersVisible = false;
            this.PhysicalNameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PhysicalNameView.Size = new System.Drawing.Size(436, 216);
            this.PhysicalNameView.TabIndex = 14;
            this.PhysicalNameView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PhysicalNameView_CellBeginEdit);
            this.PhysicalNameView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PhysicalNameView_CellValidating);
            this.PhysicalNameView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.PhysicalNameView_EditingControlShowing);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Physical Name";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn1.Width = 200;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "Repeated Capability Name";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 200;
            // 
            // PhysicalNameRemoveBtn
            // 
            this.PhysicalNameRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PhysicalNameRemoveBtn.Location = new System.Drawing.Point(365, 224);
            this.PhysicalNameRemoveBtn.Name = "PhysicalNameRemoveBtn";
            this.PhysicalNameRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.PhysicalNameRemoveBtn.TabIndex = 4;
            this.PhysicalNameRemoveBtn.Text = "Remove";
            this.PhysicalNameRemoveBtn.UseVisualStyleBackColor = true;
            this.PhysicalNameRemoveBtn.Click += new System.EventHandler(this.PhysicalNameRemoveBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PublishedAPIView);
            this.tabPage3.Controls.Add(this.goGlobalAPIs);
            this.tabPage3.Controls.Add(this.PublishedApiRemoveBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(442, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PublishedAPIs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PublishedAPIView
            // 
            this.PublishedAPIView.AllowUserToDeleteRows = false;
            this.PublishedAPIView.AllowUserToResizeRows = false;
            this.PublishedAPIView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublishedAPIView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PublishedAPIName,
            this.PublishedAPIVersion,
            this.PublishedAPIType});
            this.PublishedAPIView.Location = new System.Drawing.Point(3, 3);
            this.PublishedAPIView.MultiSelect = false;
            this.PublishedAPIView.Name = "PublishedAPIView";
            this.PublishedAPIView.RowHeadersVisible = false;
            this.PublishedAPIView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PublishedAPIView.Size = new System.Drawing.Size(436, 216);
            this.PublishedAPIView.TabIndex = 13;
            this.PublishedAPIView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PublishedAPIView_CellBeginEdit);
            this.PublishedAPIView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.PublishedAPIView_EditingControlShowing);
            // 
            // PublishedAPIName
            // 
            this.PublishedAPIName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PublishedAPIName.HeaderText = "Name";
            this.PublishedAPIName.Name = "PublishedAPIName";
            this.PublishedAPIName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PublishedAPIName.Width = 200;
            // 
            // PublishedAPIVersion
            // 
            this.PublishedAPIVersion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PublishedAPIVersion.HeaderText = "Version";
            this.PublishedAPIVersion.Name = "PublishedAPIVersion";
            this.PublishedAPIVersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PublishedAPIVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PublishedAPIType
            // 
            this.PublishedAPIType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PublishedAPIType.HeaderText = "Type";
            this.PublishedAPIType.Name = "PublishedAPIType";
            this.PublishedAPIType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // goGlobalAPIs
            // 
            this.goGlobalAPIs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goGlobalAPIs.Location = new System.Drawing.Point(3, 224);
            this.goGlobalAPIs.Name = "goGlobalAPIs";
            this.goGlobalAPIs.Size = new System.Drawing.Size(145, 23);
            this.goGlobalAPIs.TabIndex = 2;
            this.goGlobalAPIs.Text = "Global Published APIs";
            this.goGlobalAPIs.UseVisualStyleBackColor = true;
            this.goGlobalAPIs.Click += new System.EventHandler(this.goGlobalAPIs_Click);
            // 
            // PublishedApiRemoveBtn
            // 
            this.PublishedApiRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PublishedApiRemoveBtn.Location = new System.Drawing.Point(365, 224);
            this.PublishedApiRemoveBtn.Name = "PublishedApiRemoveBtn";
            this.PublishedApiRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.PublishedApiRemoveBtn.TabIndex = 2;
            this.PublishedApiRemoveBtn.Text = "Remove";
            this.PublishedApiRemoveBtn.UseVisualStyleBackColor = true;
            this.PublishedApiRemoveBtn.Click += new System.EventHandler(this.PublishedApiRemoveBtn_Click);
            // 
            // btnPath32
            // 
            this.btnPath32.Location = new System.Drawing.Point(398, 207);
            this.btnPath32.Name = "btnPath32";
            this.btnPath32.Size = new System.Drawing.Size(68, 21);
            this.btnPath32.TabIndex = 8;
            this.btnPath32.Text = "Browse...";
            this.btnPath32.UseVisualStyleBackColor = true;
            // 
            // btnPath64
            // 
            this.btnPath64.Location = new System.Drawing.Point(398, 232);
            this.btnPath64.Name = "btnPath64";
            this.btnPath64.Size = new System.Drawing.Size(68, 21);
            this.btnPath64.TabIndex = 8;
            this.btnPath64.Text = "Browse...";
            this.btnPath64.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "AssemblyQualifiedClassName";
            // 
            // qualifiedClassName
            // 
            this.qualifiedClassName.Location = new System.Drawing.Point(14, 178);
            this.qualifiedClassName.Name = "qualifiedClassName";
            this.qualifiedClassName.Size = new System.Drawing.Size(451, 21);
            this.qualifiedClassName.TabIndex = 6;
            // 
            // PanelSoftwareModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnPath64);
            this.Controls.Add(this.btnPath32);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qualifiedClassName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modulePath64);
            this.Controls.Add(this.modulePath32);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "PanelSoftwareModule";
            this.Size = new System.Drawing.Size(478, 554);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalNameView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PublishedAPIView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modulePath32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modulePath64;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox progId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPath32;
        private System.Windows.Forms.Button btnPath64;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qualifiedClassName;
        private System.Windows.Forms.TextBox supportedInstModules;
        private System.Windows.Forms.Button PublishedApiRemoveBtn;
        private System.Windows.Forms.Button PhysicalNameRemoveBtn;
        private System.Windows.Forms.DataGridView PublishedAPIView;
        private System.Windows.Forms.DataGridViewComboBoxColumn PublishedAPIName;
        private System.Windows.Forms.DataGridViewComboBoxColumn PublishedAPIVersion;
        private System.Windows.Forms.DataGridViewComboBoxColumn PublishedAPIType;
        private System.Windows.Forms.Button goGlobalAPIs;
        private System.Windows.Forms.DataGridView PhysicalNameView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
    }
}
