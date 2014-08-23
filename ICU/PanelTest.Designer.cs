namespace TomLu.ICU
{
    partial class PanelTest
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
            this.IviFunctionTab = new System.Windows.Forms.TabControl();
            this.driverTab = new System.Windows.Forms.TabPage();
            this.DriverOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DriverSetup = new System.Windows.Forms.TextBox();
            this.IoResDesc = new System.Windows.Forms.TextBox();
            this.QueryStatus = new System.Windows.Forms.CheckBox();
            this.InterchangeCheck = new System.Windows.Forms.CheckBox();
            this.Simulate = new System.Windows.Forms.CheckBox();
            this.RecordCoercions = new System.Windows.Forms.CheckBox();
            this.RangeCheck = new System.Windows.Forms.CheckBox();
            this.Cache = new System.Windows.Forms.CheckBox();
            this.DriverUtility = new System.Windows.Forms.GroupBox();
            this.ErrorQueryBtn = new System.Windows.Forms.Button();
            this.ErrorStatus = new System.Windows.Forms.TextBox();
            this.SelfTestResult = new System.Windows.Forms.TextBox();
            this.SelfTestBtn = new System.Windows.Forms.Button();
            this.UtilityResetDefaultBtn = new System.Windows.Forms.Button();
            this.UtilityResetBtn = new System.Windows.Forms.Button();
            this.DriverPropertyView = new System.Windows.Forms.ListView();
            this.DriverPropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverPropertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reset = new System.Windows.Forms.CheckBox();
            this.IdQuery = new System.Windows.Forms.CheckBox();
            this.LogicalName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Init_Close_Btn = new System.Windows.Forms.Button();
            this.IviFunctionTab.SuspendLayout();
            this.driverTab.SuspendLayout();
            this.DriverOptions.SuspendLayout();
            this.DriverUtility.SuspendLayout();
            this.SuspendLayout();
            // 
            // IviFunctionTab
            // 
            this.IviFunctionTab.Controls.Add(this.driverTab);
            this.IviFunctionTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IviFunctionTab.Location = new System.Drawing.Point(0, 0);
            this.IviFunctionTab.Name = "IviFunctionTab";
            this.IviFunctionTab.SelectedIndex = 0;
            this.IviFunctionTab.Size = new System.Drawing.Size(474, 526);
            this.IviFunctionTab.TabIndex = 6;
            // 
            // driverTab
            // 
            this.driverTab.Controls.Add(this.DriverOptions);
            this.driverTab.Controls.Add(this.DriverUtility);
            this.driverTab.Controls.Add(this.DriverPropertyView);
            this.driverTab.Controls.Add(this.Reset);
            this.driverTab.Controls.Add(this.IdQuery);
            this.driverTab.Controls.Add(this.LogicalName);
            this.driverTab.Controls.Add(this.label1);
            this.driverTab.Controls.Add(this.Init_Close_Btn);
            this.driverTab.Location = new System.Drawing.Point(4, 22);
            this.driverTab.Name = "driverTab";
            this.driverTab.Padding = new System.Windows.Forms.Padding(3);
            this.driverTab.Size = new System.Drawing.Size(466, 500);
            this.driverTab.TabIndex = 0;
            this.driverTab.Text = "Driver";
            this.driverTab.UseVisualStyleBackColor = true;
            // 
            // DriverOptions
            // 
            this.DriverOptions.Controls.Add(this.label3);
            this.DriverOptions.Controls.Add(this.label2);
            this.DriverOptions.Controls.Add(this.DriverSetup);
            this.DriverOptions.Controls.Add(this.IoResDesc);
            this.DriverOptions.Controls.Add(this.QueryStatus);
            this.DriverOptions.Controls.Add(this.InterchangeCheck);
            this.DriverOptions.Controls.Add(this.Simulate);
            this.DriverOptions.Controls.Add(this.RecordCoercions);
            this.DriverOptions.Controls.Add(this.RangeCheck);
            this.DriverOptions.Controls.Add(this.Cache);
            this.DriverOptions.Location = new System.Drawing.Point(3, 49);
            this.DriverOptions.Name = "DriverOptions";
            this.DriverOptions.Size = new System.Drawing.Size(460, 124);
            this.DriverOptions.TabIndex = 13;
            this.DriverOptions.TabStop = false;
            this.DriverOptions.Text = "Driver Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "DriverSetup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "IoResourceDescriptor";
            // 
            // DriverSetup
            // 
            this.DriverSetup.Location = new System.Drawing.Point(137, 46);
            this.DriverSetup.Name = "DriverSetup";
            this.DriverSetup.ReadOnly = true;
            this.DriverSetup.Size = new System.Drawing.Size(313, 21);
            this.DriverSetup.TabIndex = 7;
            // 
            // IoResDesc
            // 
            this.IoResDesc.Location = new System.Drawing.Point(137, 19);
            this.IoResDesc.Name = "IoResDesc";
            this.IoResDesc.ReadOnly = true;
            this.IoResDesc.Size = new System.Drawing.Size(313, 21);
            this.IoResDesc.TabIndex = 7;
            // 
            // QueryStatus
            // 
            this.QueryStatus.AutoSize = true;
            this.QueryStatus.Checked = true;
            this.QueryStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QueryStatus.Location = new System.Drawing.Point(13, 100);
            this.QueryStatus.Name = "QueryStatus";
            this.QueryStatus.Size = new System.Drawing.Size(162, 16);
            this.QueryStatus.TabIndex = 4;
            this.QueryStatus.Text = "Query Instrument Status";
            this.QueryStatus.UseVisualStyleBackColor = true;
            // 
            // InterchangeCheck
            // 
            this.InterchangeCheck.AutoSize = true;
            this.InterchangeCheck.Checked = true;
            this.InterchangeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InterchangeCheck.Location = new System.Drawing.Point(192, 78);
            this.InterchangeCheck.Name = "InterchangeCheck";
            this.InterchangeCheck.Size = new System.Drawing.Size(126, 16);
            this.InterchangeCheck.TabIndex = 5;
            this.InterchangeCheck.Text = "Interchange Check";
            this.InterchangeCheck.UseVisualStyleBackColor = true;
            // 
            // Simulate
            // 
            this.Simulate.AutoSize = true;
            this.Simulate.Checked = true;
            this.Simulate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Simulate.Location = new System.Drawing.Point(359, 100);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(72, 16);
            this.Simulate.TabIndex = 6;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            // 
            // RecordCoercions
            // 
            this.RecordCoercions.AutoSize = true;
            this.RecordCoercions.Checked = true;
            this.RecordCoercions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecordCoercions.Location = new System.Drawing.Point(192, 100);
            this.RecordCoercions.Name = "RecordCoercions";
            this.RecordCoercions.Size = new System.Drawing.Size(120, 16);
            this.RecordCoercions.TabIndex = 1;
            this.RecordCoercions.Text = "Record Coercions";
            this.RecordCoercions.UseVisualStyleBackColor = true;
            // 
            // RangeCheck
            // 
            this.RangeCheck.AutoSize = true;
            this.RangeCheck.Checked = true;
            this.RangeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RangeCheck.Location = new System.Drawing.Point(359, 78);
            this.RangeCheck.Name = "RangeCheck";
            this.RangeCheck.Size = new System.Drawing.Size(90, 16);
            this.RangeCheck.TabIndex = 2;
            this.RangeCheck.Text = "Range Check";
            this.RangeCheck.UseVisualStyleBackColor = true;
            // 
            // Cache
            // 
            this.Cache.AutoSize = true;
            this.Cache.Checked = true;
            this.Cache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cache.Location = new System.Drawing.Point(13, 78);
            this.Cache.Name = "Cache";
            this.Cache.Size = new System.Drawing.Size(54, 16);
            this.Cache.TabIndex = 3;
            this.Cache.Text = "Cache";
            this.Cache.UseVisualStyleBackColor = true;
            // 
            // DriverUtility
            // 
            this.DriverUtility.Controls.Add(this.ErrorQueryBtn);
            this.DriverUtility.Controls.Add(this.ErrorStatus);
            this.DriverUtility.Controls.Add(this.SelfTestResult);
            this.DriverUtility.Controls.Add(this.SelfTestBtn);
            this.DriverUtility.Controls.Add(this.UtilityResetDefaultBtn);
            this.DriverUtility.Controls.Add(this.UtilityResetBtn);
            this.DriverUtility.Location = new System.Drawing.Point(3, 181);
            this.DriverUtility.Name = "DriverUtility";
            this.DriverUtility.Size = new System.Drawing.Size(460, 114);
            this.DriverUtility.TabIndex = 12;
            this.DriverUtility.TabStop = false;
            this.DriverUtility.Text = "Utility";
            // 
            // ErrorQueryBtn
            // 
            this.ErrorQueryBtn.Location = new System.Drawing.Point(6, 81);
            this.ErrorQueryBtn.Name = "ErrorQueryBtn";
            this.ErrorQueryBtn.Size = new System.Drawing.Size(98, 23);
            this.ErrorQueryBtn.TabIndex = 4;
            this.ErrorQueryBtn.Text = "Error Query";
            this.ErrorQueryBtn.UseVisualStyleBackColor = true;
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.Location = new System.Drawing.Point(110, 82);
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(340, 21);
            this.ErrorStatus.TabIndex = 3;
            // 
            // SelfTestResult
            // 
            this.SelfTestResult.Location = new System.Drawing.Point(110, 52);
            this.SelfTestResult.Name = "SelfTestResult";
            this.SelfTestResult.Size = new System.Drawing.Size(340, 21);
            this.SelfTestResult.TabIndex = 3;
            // 
            // SelfTestBtn
            // 
            this.SelfTestBtn.Location = new System.Drawing.Point(6, 51);
            this.SelfTestBtn.Name = "SelfTestBtn";
            this.SelfTestBtn.Size = new System.Drawing.Size(98, 23);
            this.SelfTestBtn.TabIndex = 2;
            this.SelfTestBtn.Text = "Self Test";
            this.SelfTestBtn.UseVisualStyleBackColor = true;
            // 
            // UtilityResetDefaultBtn
            // 
            this.UtilityResetDefaultBtn.Location = new System.Drawing.Point(110, 20);
            this.UtilityResetDefaultBtn.Name = "UtilityResetDefaultBtn";
            this.UtilityResetDefaultBtn.Size = new System.Drawing.Size(100, 23);
            this.UtilityResetDefaultBtn.TabIndex = 1;
            this.UtilityResetDefaultBtn.Text = "Reset Default";
            this.UtilityResetDefaultBtn.UseVisualStyleBackColor = true;
            // 
            // UtilityResetBtn
            // 
            this.UtilityResetBtn.Location = new System.Drawing.Point(6, 20);
            this.UtilityResetBtn.Name = "UtilityResetBtn";
            this.UtilityResetBtn.Size = new System.Drawing.Size(98, 23);
            this.UtilityResetBtn.TabIndex = 0;
            this.UtilityResetBtn.Text = "Reset";
            this.UtilityResetBtn.UseVisualStyleBackColor = true;
            // 
            // DriverPropertyView
            // 
            this.DriverPropertyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriverPropertyName,
            this.DriverPropertyValue});
            this.DriverPropertyView.FullRowSelect = true;
            this.DriverPropertyView.Location = new System.Drawing.Point(3, 307);
            this.DriverPropertyView.Name = "DriverPropertyView";
            this.DriverPropertyView.ShowItemToolTips = true;
            this.DriverPropertyView.Size = new System.Drawing.Size(460, 190);
            this.DriverPropertyView.TabIndex = 11;
            this.DriverPropertyView.UseCompatibleStateImageBehavior = false;
            this.DriverPropertyView.View = System.Windows.Forms.View.Details;
            // 
            // DriverPropertyName
            // 
            this.DriverPropertyName.Text = "Name";
            this.DriverPropertyName.Width = 180;
            // 
            // DriverPropertyValue
            // 
            this.DriverPropertyValue.Text = "Value";
            this.DriverPropertyValue.Width = 260;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Checked = true;
            this.Reset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Reset.Location = new System.Drawing.Point(272, 24);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(54, 16);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // IdQuery
            // 
            this.IdQuery.AutoSize = true;
            this.IdQuery.Checked = true;
            this.IdQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdQuery.Location = new System.Drawing.Point(188, 24);
            this.IdQuery.Name = "IdQuery";
            this.IdQuery.Size = new System.Drawing.Size(66, 16);
            this.IdQuery.TabIndex = 9;
            this.IdQuery.Text = "IdQuery";
            this.IdQuery.UseVisualStyleBackColor = true;
            // 
            // LogicalName
            // 
            this.LogicalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogicalName.FormattingEnabled = true;
            this.LogicalName.Location = new System.Drawing.Point(6, 22);
            this.LogicalName.Name = "LogicalName";
            this.LogicalName.Size = new System.Drawing.Size(144, 20);
            this.LogicalName.TabIndex = 8;
            this.LogicalName.SelectedIndexChanged += new System.EventHandler(this.LogicalName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "LogicalName";
            // 
            // Init_Close_Btn
            // 
            this.Init_Close_Btn.Location = new System.Drawing.Point(355, 20);
            this.Init_Close_Btn.Name = "Init_Close_Btn";
            this.Init_Close_Btn.Size = new System.Drawing.Size(90, 23);
            this.Init_Close_Btn.TabIndex = 6;
            this.Init_Close_Btn.Text = "Initialize";
            this.Init_Close_Btn.UseVisualStyleBackColor = true;
            this.Init_Close_Btn.Click += new System.EventHandler(this.Init_CLose_Btn_Click);
            // 
            // PanelTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IviFunctionTab);
            this.Name = "PanelTest";
            this.Size = new System.Drawing.Size(474, 526);
            this.IviFunctionTab.ResumeLayout(false);
            this.driverTab.ResumeLayout(false);
            this.driverTab.PerformLayout();
            this.DriverOptions.ResumeLayout(false);
            this.DriverOptions.PerformLayout();
            this.DriverUtility.ResumeLayout(false);
            this.DriverUtility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IviFunctionTab;
        private System.Windows.Forms.TabPage driverTab;
        private System.Windows.Forms.CheckBox Reset;
        private System.Windows.Forms.CheckBox IdQuery;
        private System.Windows.Forms.ComboBox LogicalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Init_Close_Btn;
        private System.Windows.Forms.ListView DriverPropertyView;
        private System.Windows.Forms.ColumnHeader DriverPropertyName;
        private System.Windows.Forms.ColumnHeader DriverPropertyValue;
        private System.Windows.Forms.GroupBox DriverUtility;
        private System.Windows.Forms.Button SelfTestBtn;
        private System.Windows.Forms.Button UtilityResetDefaultBtn;
        private System.Windows.Forms.Button UtilityResetBtn;
        private System.Windows.Forms.TextBox SelfTestResult;
        private System.Windows.Forms.Button ErrorQueryBtn;
        private System.Windows.Forms.TextBox ErrorStatus;
        private System.Windows.Forms.GroupBox DriverOptions;
        private System.Windows.Forms.CheckBox QueryStatus;
        private System.Windows.Forms.CheckBox InterchangeCheck;
        private System.Windows.Forms.CheckBox Simulate;
        private System.Windows.Forms.CheckBox RecordCoercions;
        private System.Windows.Forms.CheckBox RangeCheck;
        private System.Windows.Forms.CheckBox Cache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DriverSetup;
        private System.Windows.Forms.TextBox IoResDesc;

    }
}
