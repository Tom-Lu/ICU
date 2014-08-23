namespace TomLu.ICU
{
    partial class PanelPublishedAPIs
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
            this.publishedApiRemoveBtn = new System.Windows.Forms.Button();
            this.publishedApiAddBtn = new System.Windows.Forms.Button();
            this.publishedAPIList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // publishedApiRemoveBtn
            // 
            this.publishedApiRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.publishedApiRemoveBtn.Location = new System.Drawing.Point(398, 519);
            this.publishedApiRemoveBtn.Name = "publishedApiRemoveBtn";
            this.publishedApiRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.publishedApiRemoveBtn.TabIndex = 8;
            this.publishedApiRemoveBtn.Text = "Remove";
            this.publishedApiRemoveBtn.UseVisualStyleBackColor = true;
            this.publishedApiRemoveBtn.Click += new System.EventHandler(this.publishedApiRemoveBtn_Click);
            // 
            // publishedApiAddBtn
            // 
            this.publishedApiAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.publishedApiAddBtn.Location = new System.Drawing.Point(316, 519);
            this.publishedApiAddBtn.Name = "publishedApiAddBtn";
            this.publishedApiAddBtn.Size = new System.Drawing.Size(75, 23);
            this.publishedApiAddBtn.TabIndex = 7;
            this.publishedApiAddBtn.Text = "Add ...";
            this.publishedApiAddBtn.UseVisualStyleBackColor = true;
            this.publishedApiAddBtn.Click += new System.EventHandler(this.publishedApiAddBtn_Click);
            // 
            // publishedAPIList
            // 
            this.publishedAPIList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishedAPIList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.publishedAPIList.FullRowSelect = true;
            this.publishedAPIList.Location = new System.Drawing.Point(3, 3);
            this.publishedAPIList.Name = "publishedAPIList";
            this.publishedAPIList.Size = new System.Drawing.Size(470, 511);
            this.publishedAPIList.TabIndex = 6;
            this.publishedAPIList.UseCompatibleStateImageBehavior = false;
            this.publishedAPIList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 139;
            // 
            // PanelPublishedAPIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.publishedApiRemoveBtn);
            this.Controls.Add(this.publishedApiAddBtn);
            this.Controls.Add(this.publishedAPIList);
            this.Name = "PanelPublishedAPIs";
            this.Size = new System.Drawing.Size(476, 552);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button publishedApiRemoveBtn;
        private System.Windows.Forms.Button publishedApiAddBtn;
        private System.Windows.Forms.ListView publishedAPIList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;

    }
}