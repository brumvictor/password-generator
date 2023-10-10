
namespace PasswordGenerator
{
    partial class FormPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasswordGenerator));
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(131, 151);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(405, 53);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLengthLabel.Location = new System.Drawing.Point(147, 216);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(389, 53);
            this.PasswordLengthLabel.TabIndex = 1;
            this.PasswordLengthLabel.Text = "Password Length: 5 ";
            this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLengthLabel.Click += new System.EventHandler(this.PasswordLengthLabel_Click);
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.Location = new System.Drawing.Point(135, 284);
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Size = new System.Drawing.Size(401, 45);
            this.PasswordLengthSlider.TabIndex = 2;
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.BackColor = System.Drawing.Color.White;
            this.CopyPasswordButton.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordButton.Location = new System.Drawing.Point(141, 359);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(395, 51);
            this.CopyPasswordButton.TabIndex = 3;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = false;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(685, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.TrackBar PasswordLengthSlider;
        private System.Windows.Forms.Button CopyPasswordButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

