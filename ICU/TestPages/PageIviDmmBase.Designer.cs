namespace TomLu.ICU.TestPages
{
    partial class PageIviDmmBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.IviDmmFunction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.TextBox();
            this.Resolution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfigureBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.Timeout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "IviDmmBase";
            // 
            // IviDmmFunction
            // 
            this.IviDmmFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IviDmmFunction.FormattingEnabled = true;
            this.IviDmmFunction.Location = new System.Drawing.Point(17, 70);
            this.IviDmmFunction.Name = "IviDmmFunction";
            this.IviDmmFunction.Size = new System.Drawing.Size(189, 20);
            this.IviDmmFunction.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dmm Function";
            // 
            // Range
            // 
            this.Range.Location = new System.Drawing.Point(214, 70);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(64, 21);
            this.Range.TabIndex = 3;
            this.Range.Text = "10";
            // 
            // Resolution
            // 
            this.Resolution.Location = new System.Drawing.Point(286, 70);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(63, 21);
            this.Resolution.TabIndex = 4;
            this.Resolution.Text = "0.001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resolution";
            // 
            // ConfigureBtn
            // 
            this.ConfigureBtn.Location = new System.Drawing.Point(368, 68);
            this.ConfigureBtn.Name = "ConfigureBtn";
            this.ConfigureBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfigureBtn.TabIndex = 7;
            this.ConfigureBtn.Text = "Configure";
            this.ConfigureBtn.UseVisualStyleBackColor = true;
            this.ConfigureBtn.Click += new System.EventHandler(this.ConfigureBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ReadValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Timeout);
            this.groupBox1.Controls.Add(this.ReadBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurement";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(14, 33);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 0;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // Timeout
            // 
            this.Timeout.Location = new System.Drawing.Point(103, 34);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(126, 21);
            this.Timeout.TabIndex = 1;
            this.Timeout.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Timeout(Milliseconds)";
            // 
            // ReadValue
            // 
            this.ReadValue.Location = new System.Drawing.Point(318, 33);
            this.ReadValue.Name = "ReadValue";
            this.ReadValue.Size = new System.Drawing.Size(122, 21);
            this.ReadValue.TabIndex = 3;
            this.ReadValue.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Read Value";
            // 
            // PageIviDmmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConfigureBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IviDmmFunction);
            this.Controls.Add(this.label1);
            this.Name = "PageIviDmmBase";
            this.Size = new System.Drawing.Size(474, 443);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IviDmmFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Range;
        private System.Windows.Forms.TextBox Resolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfigureBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Timeout;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReadValue;
    }
}
