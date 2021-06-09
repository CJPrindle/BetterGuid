namespace BetterGUID
{

    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNewGuid = new System.Windows.Forms.Button();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.lblGuidEmpty = new System.Windows.Forms.Label();
            this.lblGuidParse = new System.Windows.Forms.Label();
            this.lblWithBrackets = new System.Windows.Forms.Label();
            this.lblValueOnly = new System.Windows.Forms.Label();
            this.rdoEmpty = new System.Windows.Forms.RadioButton();
            this.rdoGuidParse = new System.Windows.Forms.RadioButton();
            this.rdoWithBrackets = new System.Windows.Forms.RadioButton();
            this.rdoValueOnly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkClose = new System.Windows.Forms.LinkLabel();
            this.gbFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGuid
            // 
            this.btnNewGuid.AutoSize = true;
            this.btnNewGuid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewGuid.Location = new System.Drawing.Point(370, 350);
            this.btnNewGuid.Name = "btnNewGuid";
            this.btnNewGuid.Size = new System.Drawing.Size(113, 38);
            this.btnNewGuid.TabIndex = 0;
            this.btnNewGuid.Text = "New GUID";
            this.btnNewGuid.UseVisualStyleBackColor = true;
            this.btnNewGuid.Click += new System.EventHandler(this.btnNewGuid_Click);
            // 
            // gbFormat
            // 
            this.gbFormat.Controls.Add(this.lblGuidEmpty);
            this.gbFormat.Controls.Add(this.lblGuidParse);
            this.gbFormat.Controls.Add(this.lblWithBrackets);
            this.gbFormat.Controls.Add(this.lblValueOnly);
            this.gbFormat.Controls.Add(this.rdoEmpty);
            this.gbFormat.Controls.Add(this.rdoGuidParse);
            this.gbFormat.Controls.Add(this.rdoWithBrackets);
            this.gbFormat.Controls.Add(this.rdoValueOnly);
            this.gbFormat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFormat.Location = new System.Drawing.Point(12, 52);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(829, 214);
            this.gbFormat.TabIndex = 1;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "Choose Format";
            // 
            // lblGuidEmpty
            // 
            this.lblGuidEmpty.AutoEllipsis = true;
            this.lblGuidEmpty.AutoSize = true;
            this.lblGuidEmpty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuidEmpty.ForeColor = System.Drawing.Color.Navy;
            this.lblGuidEmpty.Location = new System.Drawing.Point(221, 170);
            this.lblGuidEmpty.Name = "lblGuidEmpty";
            this.lblGuidEmpty.Size = new System.Drawing.Size(360, 25);
            this.lblGuidEmpty.TabIndex = 7;
            this.lblGuidEmpty.Text = "00000000-0000-0000-0000-000000000000";
            // 
            // lblGuidParse
            // 
            this.lblGuidParse.AutoEllipsis = true;
            this.lblGuidParse.AutoSize = true;
            this.lblGuidParse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuidParse.ForeColor = System.Drawing.Color.Navy;
            this.lblGuidParse.Location = new System.Drawing.Point(221, 127);
            this.lblGuidParse.Name = "lblGuidParse";
            this.lblGuidParse.Size = new System.Drawing.Size(559, 25);
            this.lblGuidParse.TabIndex = 6;
            this.lblGuidParse.Text = "var guid = Guid.Parse(\"20296BA3-5BF4-413C-956D-68F9F83260E3\");";
            // 
            // lblWithBrackets
            // 
            this.lblWithBrackets.AutoEllipsis = true;
            this.lblWithBrackets.AutoSize = true;
            this.lblWithBrackets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWithBrackets.ForeColor = System.Drawing.Color.Navy;
            this.lblWithBrackets.Location = new System.Drawing.Point(221, 84);
            this.lblWithBrackets.Name = "lblWithBrackets";
            this.lblWithBrackets.Size = new System.Drawing.Size(372, 25);
            this.lblWithBrackets.TabIndex = 5;
            this.lblWithBrackets.Text = "{20296BA3-5BF4-413C-956D-68F9F83260E3}";
            // 
            // lblValueOnly
            // 
            this.lblValueOnly.AutoEllipsis = true;
            this.lblValueOnly.AutoSize = true;
            this.lblValueOnly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValueOnly.ForeColor = System.Drawing.Color.Navy;
            this.lblValueOnly.Location = new System.Drawing.Point(221, 41);
            this.lblValueOnly.Name = "lblValueOnly";
            this.lblValueOnly.Size = new System.Drawing.Size(362, 25);
            this.lblValueOnly.TabIndex = 4;
            this.lblValueOnly.Text = "20296BA3-5BF4-413C-956D-68F9F83260E3";
            // 
            // rdoEmpty
            // 
            this.rdoEmpty.AutoSize = true;
            this.rdoEmpty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoEmpty.Location = new System.Drawing.Point(40, 168);
            this.rdoEmpty.Name = "rdoEmpty";
            this.rdoEmpty.Size = new System.Drawing.Size(88, 29);
            this.rdoEmpty.TabIndex = 3;
            this.rdoEmpty.Text = "Empty";
            this.rdoEmpty.UseVisualStyleBackColor = true;
            this.rdoEmpty.CheckedChanged += new System.EventHandler(this.rdoEmpty_CheckedChanged);
            // 
            // rdoGuidParse
            // 
            this.rdoGuidParse.AutoSize = true;
            this.rdoGuidParse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoGuidParse.Location = new System.Drawing.Point(40, 125);
            this.rdoGuidParse.Name = "rdoGuidParse";
            this.rdoGuidParse.Size = new System.Drawing.Size(153, 29);
            this.rdoGuidParse.TabIndex = 2;
            this.rdoGuidParse.Text = "Guid.Parse (c#)";
            this.rdoGuidParse.UseVisualStyleBackColor = true;
            this.rdoGuidParse.CheckedChanged += new System.EventHandler(this.rdoGuidParse_CheckedChanged);
            // 
            // rdoWithBrackets
            // 
            this.rdoWithBrackets.AutoSize = true;
            this.rdoWithBrackets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoWithBrackets.Location = new System.Drawing.Point(40, 82);
            this.rdoWithBrackets.Name = "rdoWithBrackets";
            this.rdoWithBrackets.Size = new System.Drawing.Size(144, 29);
            this.rdoWithBrackets.TabIndex = 1;
            this.rdoWithBrackets.Text = "With Brackets";
            this.rdoWithBrackets.UseVisualStyleBackColor = true;
            this.rdoWithBrackets.CheckedChanged += new System.EventHandler(this.rdoGuidBrackets_CheckedChanged);
            // 
            // rdoValueOnly
            // 
            this.rdoValueOnly.AutoSize = true;
            this.rdoValueOnly.Checked = true;
            this.rdoValueOnly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoValueOnly.Location = new System.Drawing.Point(40, 39);
            this.rdoValueOnly.Name = "rdoValueOnly";
            this.rdoValueOnly.Size = new System.Drawing.Size(121, 29);
            this.rdoValueOnly.TabIndex = 0;
            this.rdoValueOnly.TabStop = true;
            this.rdoValueOnly.Text = "Value Only";
            this.rdoValueOnly.UseVisualStyleBackColor = true;
            this.rdoValueOnly.CheckedChanged += new System.EventHandler(this.rdoValueOnly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate a GUID value in the selected format:";
            // 
            // lblOutValue
            // 
            this.lblOutValue.AutoEllipsis = true;
            this.lblOutValue.AutoSize = true;
            this.lblOutValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOutValue.ForeColor = System.Drawing.Color.Navy;
            this.lblOutValue.Location = new System.Drawing.Point(255, 297);
            this.lblOutValue.Name = "lblOutValue";
            this.lblOutValue.Size = new System.Drawing.Size(559, 25);
            this.lblOutValue.TabIndex = 7;
            this.lblOutValue.Text = "var guid = Guid.Parse(\"20296BA3-5BF4-413C-956D-68F9F83260E3\");";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(106, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Clipboard Value:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterGUID.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(48, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // linkClose
            // 
            this.linkClose.AutoSize = true;
            this.linkClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkClose.LinkColor = System.Drawing.Color.Red;
            this.linkClose.Location = new System.Drawing.Point(786, 12);
            this.linkClose.Name = "linkClose";
            this.linkClose.Size = new System.Drawing.Size(55, 25);
            this.linkClose.TabIndex = 9;
            this.linkClose.TabStop = true;
            this.linkClose.Text = "Close";
            this.linkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClose_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnNewGuid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(853, 401);
            this.Controls.Add(this.linkClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOutValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFormat);
            this.Controls.Add(this.btnNewGuid);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better GUID Generator";
            this.gbFormat.ResumeLayout(false);
            this.gbFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGuid;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.RadioButton rdoEmpty;
        private System.Windows.Forms.RadioButton rdoGuidParse;
        private System.Windows.Forms.RadioButton rdoWithBrackets;
        private System.Windows.Forms.RadioButton rdoValueOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValueOnly;
        private System.Windows.Forms.Label lblWithBrackets;
        private System.Windows.Forms.Label lblGuidParse;
        private System.Windows.Forms.Label lblGuidEmpty;
        private System.Windows.Forms.Label lblOutValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkClose;
    }
}

