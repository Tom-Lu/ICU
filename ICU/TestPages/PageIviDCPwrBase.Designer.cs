namespace TomLu.ICU.TestPages
{
    partial class PageIviDCPwrBase
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTabs = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "IviDCPwrBase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputTabs
            // 
            this.OutputTabs.Location = new System.Drawing.Point(3, 50);
            this.OutputTabs.Name = "OutputTabs";
            this.OutputTabs.SelectedIndex = 0;
            this.OutputTabs.Size = new System.Drawing.Size(494, 390);
            this.OutputTabs.TabIndex = 4;
            // 
            // PageIviDCPwrBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputTabs);
            this.Controls.Add(this.label1);
            this.Name = "PageIviDCPwrBase";
            this.Size = new System.Drawing.Size(500, 443);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl OutputTabs;
    }
}
