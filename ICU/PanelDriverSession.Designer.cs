namespace TomLu.ICU
{
    partial class PanelDriverSession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queryStatus = new System.Windows.Forms.CheckBox();
            this.interchangeCheck = new System.Windows.Forms.CheckBox();
            this.simulate = new System.Windows.Forms.CheckBox();
            this.recordCoercions = new System.Windows.Forms.CheckBox();
            this.rangeCheck = new System.Windows.Forms.CheckBox();
            this.cache = new System.Windows.Forms.CheckBox();
            this.softwareModule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hardwareAsset = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActiveSoftwareModule = new System.Windows.Forms.Button();
            this.btnActiveHardwareAsset = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.removeVirtualName = new System.Windows.Forms.Button();
            this.VirtualNameView = new System.Windows.Forms.DataGridView();
            this.VirtualNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VirtualNameView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.queryStatus);
            this.groupBox1.Controls.Add(this.interchangeCheck);
            this.groupBox1.Controls.Add(this.simulate);
            this.groupBox1.Controls.Add(this.recordCoercions);
            this.groupBox1.Controls.Add(this.rangeCheck);
            this.groupBox1.Controls.Add(this.cache);
            this.groupBox1.Location = new System.Drawing.Point(13, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization Options";
            // 
            // queryStatus
            // 
            this.queryStatus.AutoSize = true;
            this.queryStatus.Checked = true;
            this.queryStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.queryStatus.Location = new System.Drawing.Point(224, 62);
            this.queryStatus.Name = "queryStatus";
            this.queryStatus.Size = new System.Drawing.Size(162, 16);
            this.queryStatus.TabIndex = 0;
            this.queryStatus.Text = "Query Instrument Status";
            this.queryStatus.UseVisualStyleBackColor = true;
            // 
            // interchangeCheck
            // 
            this.interchangeCheck.AutoSize = true;
            this.interchangeCheck.Checked = true;
            this.interchangeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.interchangeCheck.Location = new System.Drawing.Point(224, 27);
            this.interchangeCheck.Name = "interchangeCheck";
            this.interchangeCheck.Size = new System.Drawing.Size(126, 16);
            this.interchangeCheck.TabIndex = 0;
            this.interchangeCheck.Text = "Interchange Check";
            this.interchangeCheck.UseVisualStyleBackColor = true;
            // 
            // simulate
            // 
            this.simulate.AutoSize = true;
            this.simulate.Checked = true;
            this.simulate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simulate.Location = new System.Drawing.Point(224, 97);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(72, 16);
            this.simulate.TabIndex = 0;
            this.simulate.Text = "Simulate";
            this.simulate.UseVisualStyleBackColor = true;
            // 
            // recordCoercions
            // 
            this.recordCoercions.AutoSize = true;
            this.recordCoercions.Checked = true;
            this.recordCoercions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recordCoercions.Location = new System.Drawing.Point(17, 97);
            this.recordCoercions.Name = "recordCoercions";
            this.recordCoercions.Size = new System.Drawing.Size(120, 16);
            this.recordCoercions.TabIndex = 0;
            this.recordCoercions.Text = "Record Coercions";
            this.recordCoercions.UseVisualStyleBackColor = true;
            // 
            // rangeCheck
            // 
            this.rangeCheck.AutoSize = true;
            this.rangeCheck.Checked = true;
            this.rangeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rangeCheck.Location = new System.Drawing.Point(17, 62);
            this.rangeCheck.Name = "rangeCheck";
            this.rangeCheck.Size = new System.Drawing.Size(90, 16);
            this.rangeCheck.TabIndex = 0;
            this.rangeCheck.Text = "Range Check";
            this.rangeCheck.UseVisualStyleBackColor = true;
            // 
            // cache
            // 
            this.cache.AutoSize = true;
            this.cache.Checked = true;
            this.cache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cache.Location = new System.Drawing.Point(17, 27);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(54, 16);
            this.cache.TabIndex = 0;
            this.cache.Text = "Cache";
            this.cache.UseVisualStyleBackColor = true;
            // 
            // softwareModule
            // 
            this.softwareModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.softwareModule.FormattingEnabled = true;
            this.softwareModule.Location = new System.Drawing.Point(119, 33);
            this.softwareModule.Name = "softwareModule";
            this.softwareModule.Size = new System.Drawing.Size(167, 20);
            this.softwareModule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Software Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hardware Asset";
            // 
            // hardwareAsset
            // 
            this.hardwareAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardwareAsset.FormattingEnabled = true;
            this.hardwareAsset.Location = new System.Drawing.Point(119, 58);
            this.hardwareAsset.Name = "hardwareAsset";
            this.hardwareAsset.Size = new System.Drawing.Size(167, 20);
            this.hardwareAsset.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Virtual Names";
            // 
            // btnActiveSoftwareModule
            // 
            this.btnActiveSoftwareModule.Location = new System.Drawing.Point(295, 32);
            this.btnActiveSoftwareModule.Name = "btnActiveSoftwareModule";
            this.btnActiveSoftwareModule.Size = new System.Drawing.Size(78, 21);
            this.btnActiveSoftwareModule.TabIndex = 5;
            this.btnActiveSoftwareModule.Text = "GoTo";
            this.btnActiveSoftwareModule.UseVisualStyleBackColor = true;
            this.btnActiveSoftwareModule.Click += new System.EventHandler(this.btnActiveSoftwareModule_Click);
            // 
            // btnActiveHardwareAsset
            // 
            this.btnActiveHardwareAsset.Location = new System.Drawing.Point(295, 57);
            this.btnActiveHardwareAsset.Name = "btnActiveHardwareAsset";
            this.btnActiveHardwareAsset.Size = new System.Drawing.Size(78, 21);
            this.btnActiveHardwareAsset.TabIndex = 5;
            this.btnActiveHardwareAsset.Text = "GoTo";
            this.btnActiveHardwareAsset.UseVisualStyleBackColor = true;
            this.btnActiveHardwareAsset.Click += new System.EventHandler(this.btnActiveHardwareAsset_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(119, 9);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(167, 21);
            this.name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(13, 104);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(448, 56);
            this.desc.TabIndex = 8;
            // 
            // removeVirtualName
            // 
            this.removeVirtualName.Location = new System.Drawing.Point(388, 472);
            this.removeVirtualName.Name = "removeVirtualName";
            this.removeVirtualName.Size = new System.Drawing.Size(75, 23);
            this.removeVirtualName.TabIndex = 10;
            this.removeVirtualName.Text = "Remove";
            this.removeVirtualName.UseVisualStyleBackColor = true;
            this.removeVirtualName.Click += new System.EventHandler(this.removeVirtualName_Click);
            // 
            // VirtualNameView
            // 
            this.VirtualNameView.AllowUserToDeleteRows = false;
            this.VirtualNameView.AllowUserToResizeColumns = false;
            this.VirtualNameView.AllowUserToResizeRows = false;
            this.VirtualNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VirtualNameView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VirtualNameColumn,
            this.PhysicalNameColumn});
            this.VirtualNameView.Location = new System.Drawing.Point(12, 325);
            this.VirtualNameView.MultiSelect = false;
            this.VirtualNameView.Name = "VirtualNameView";
            this.VirtualNameView.RowHeadersVisible = false;
            this.VirtualNameView.RowTemplate.Height = 23;
            this.VirtualNameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VirtualNameView.Size = new System.Drawing.Size(449, 143);
            this.VirtualNameView.TabIndex = 13;
            this.VirtualNameView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.VirtualNameView_CellBeginEdit);
            this.VirtualNameView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.VirtualNameView_CellValidating);
            this.VirtualNameView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.VirtualNameView_EditingControlShowing);
            // 
            // VirtualNameColumn
            // 
            this.VirtualNameColumn.HeaderText = "Virtual Name";
            this.VirtualNameColumn.Name = "VirtualNameColumn";
            this.VirtualNameColumn.Width = 200;
            // 
            // PhysicalNameColumn
            // 
            this.PhysicalNameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PhysicalNameColumn.HeaderText = "Physical Name";
            this.PhysicalNameColumn.Name = "PhysicalNameColumn";
            this.PhysicalNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhysicalNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhysicalNameColumn.Width = 200;
            // 
            // PanelDriverSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.VirtualNameView);
            this.Controls.Add(this.removeVirtualName);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActiveHardwareAsset);
            this.Controls.Add(this.btnActiveSoftwareModule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardwareAsset);
            this.Controls.Add(this.softwareModule);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelDriverSession";
            this.Size = new System.Drawing.Size(476, 504);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VirtualNameView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox queryStatus;
        private System.Windows.Forms.CheckBox interchangeCheck;
        private System.Windows.Forms.CheckBox recordCoercions;
        private System.Windows.Forms.CheckBox rangeCheck;
        private System.Windows.Forms.CheckBox cache;
        private System.Windows.Forms.CheckBox simulate;
        private System.Windows.Forms.ComboBox softwareModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hardwareAsset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActiveSoftwareModule;
        private System.Windows.Forms.Button btnActiveHardwareAsset;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Button removeVirtualName;
        private System.Windows.Forms.DataGridView VirtualNameView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VirtualNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhysicalNameColumn;
    }
}
