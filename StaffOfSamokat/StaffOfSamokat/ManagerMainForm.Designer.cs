namespace StaffOfSamokat
{
    partial class ManagerMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainForm));
            this.ResumeDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.ConsiderationButton = new System.Windows.Forms.Button();
            this.AsseptButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResumeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResumeDataGridView
            // 
            this.ResumeDataGridView.AllowUserToAddRows = false;
            this.ResumeDataGridView.AllowUserToDeleteRows = false;
            this.ResumeDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResumeDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResumeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResumeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResumeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResumeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.ResumeDataGridView.Location = new System.Drawing.Point(12, 108);
            this.ResumeDataGridView.Name = "ResumeDataGridView";
            this.ResumeDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResumeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ResumeDataGridView.RowHeadersVisible = false;
            this.ResumeDataGridView.RowHeadersWidth = 51;
            this.ResumeDataGridView.RowTemplate.Height = 24;
            this.ResumeDataGridView.Size = new System.Drawing.Size(1480, 369);
            this.ResumeDataGridView.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(1095, 24);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(332, 27);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.RegistrationLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.ForeColor = System.Drawing.Color.White;
            this.RegistrationLabel.Location = new System.Drawing.Point(681, 24);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationLabel.Size = new System.Drawing.Size(152, 35);
            this.RegistrationLabel.TabIndex = 7;
            this.RegistrationLabel.Text = "РЕЗЮМЕ";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchPictureBox.Image = global::StaffOfSamokat.Properties.Resources._98538310_icon_of_loupe_search_button_magnifying_glass_flat_design_style_vector_illustration;
            this.SearchPictureBox.Location = new System.Drawing.Point(1040, 17);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(49, 46);
            this.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchPictureBox.TabIndex = 6;
            this.SearchPictureBox.TabStop = false;
            // 
            // ConsiderationButton
            // 
            this.ConsiderationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsiderationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.ConsiderationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsiderationButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsiderationButton.ForeColor = System.Drawing.Color.White;
            this.ConsiderationButton.Location = new System.Drawing.Point(622, 497);
            this.ConsiderationButton.Name = "ConsiderationButton";
            this.ConsiderationButton.Size = new System.Drawing.Size(279, 33);
            this.ConsiderationButton.TabIndex = 8;
            this.ConsiderationButton.Text = "Отправить на рассмотрение";
            this.ConsiderationButton.UseVisualStyleBackColor = false;
            this.ConsiderationButton.Click += new System.EventHandler(this.ConsiderationButton_Click);
            // 
            // AsseptButton
            // 
            this.AsseptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AsseptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.AsseptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsseptButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsseptButton.ForeColor = System.Drawing.Color.White;
            this.AsseptButton.Location = new System.Drawing.Point(149, 497);
            this.AsseptButton.Name = "AsseptButton";
            this.AsseptButton.Size = new System.Drawing.Size(220, 33);
            this.AsseptButton.TabIndex = 9;
            this.AsseptButton.Text = "Принять работника";
            this.AsseptButton.UseVisualStyleBackColor = false;
            this.AsseptButton.Click += new System.EventHandler(this.AsseptButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RejectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.RejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RejectButton.ForeColor = System.Drawing.Color.White;
            this.RejectButton.Location = new System.Drawing.Point(1146, 497);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(204, 33);
            this.RejectButton.TabIndex = 10;
            this.RejectButton.Text = "Отклонить резюме";
            this.RejectButton.UseVisualStyleBackColor = false;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 559);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.AsseptButton);
            this.Controls.Add(this.ConsiderationButton);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ResumeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.ManagerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResumeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResumeDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Button ConsiderationButton;
        private System.Windows.Forms.Button AsseptButton;
        private System.Windows.Forms.Button RejectButton;
    }
}