namespace StaffOfSamokat
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.ResumeButton = new System.Windows.Forms.Button();
            this.MainInformationLabel = new System.Windows.Forms.Label();
            this.InformationButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResumeButton
            // 
            this.ResumeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResumeButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResumeButton.ForeColor = System.Drawing.Color.White;
            this.ResumeButton.Location = new System.Drawing.Point(65, 394);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(215, 37);
            this.ResumeButton.TabIndex = 8;
            this.ResumeButton.Text = "Ваше резюме";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // MainInformationLabel
            // 
            this.MainInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainInformationLabel.AutoSize = true;
            this.MainInformationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.MainInformationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainInformationLabel.ForeColor = System.Drawing.Color.White;
            this.MainInformationLabel.Location = new System.Drawing.Point(358, 24);
            this.MainInformationLabel.Name = "MainInformationLabel";
            this.MainInformationLabel.Size = new System.Drawing.Size(425, 161);
            this.MainInformationLabel.TabIndex = 9;
            this.MainInformationLabel.Text = resources.GetString("MainInformationLabel.Text");
            this.MainInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationButton.ForeColor = System.Drawing.Color.White;
            this.InformationButton.Location = new System.Drawing.Point(65, 467);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(215, 37);
            this.InformationButton.TabIndex = 10;
            this.InformationButton.Text = "Информация о нас";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StaffOfSamokat.Properties.Resources.Main4;
            this.pictureBox2.Location = new System.Drawing.Point(362, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaffOfSamokat.Properties.Resources.Main3;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 544);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.MainInformationLabel);
            this.Controls.Add(this.ResumeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Label MainInformationLabel;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}