namespace EncryptionWithFrames
{
    partial class MainWindow
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
            this.Dencrypt_btn = new System.Windows.Forms.Button();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Space_for_code = new System.Windows.Forms.TextBox();
            this.Cancle_btn = new System.Windows.Forms.Button();
            this.Code_lbl = new System.Windows.Forms.Label();
            this.Key_lbl = new System.Windows.Forms.Label();
            this.Space_for_key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dencrypt_btn
            // 
            this.Dencrypt_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dencrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dencrypt_btn.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dencrypt_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dencrypt_btn.Location = new System.Drawing.Point(265, 388);
            this.Dencrypt_btn.Name = "Dencrypt_btn";
            this.Dencrypt_btn.Size = new System.Drawing.Size(250, 64);
            this.Dencrypt_btn.TabIndex = 1;
            this.Dencrypt_btn.Text = "Decrypt";
            this.Dencrypt_btn.UseVisualStyleBackColor = false;
            this.Dencrypt_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt_btn.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Encrypt_btn.Location = new System.Drawing.Point(13, 388);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(246, 64);
            this.Encrypt_btn.TabIndex = 0;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = false;
            this.Encrypt_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Space_for_code
            // 
            this.Space_for_code.AccessibleDescription = "";
            this.Space_for_code.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Space_for_code.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Space_for_code.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Space_for_code.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Space_for_code.HideSelection = false;
            this.Space_for_code.Location = new System.Drawing.Point(137, 12);
            this.Space_for_code.Multiline = true;
            this.Space_for_code.Name = "Space_for_code";
            this.Space_for_code.ReadOnly = true;
            this.Space_for_code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Space_for_code.Size = new System.Drawing.Size(633, 175);
            this.Space_for_code.TabIndex = 3;
            // 
            // Cancle_btn
            // 
            this.Cancle_btn.AccessibleDescription = "";
            this.Cancle_btn.AccessibleName = "";
            this.Cancle_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancle_btn.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancle_btn.Location = new System.Drawing.Point(521, 388);
            this.Cancle_btn.Name = "Cancle_btn";
            this.Cancle_btn.Size = new System.Drawing.Size(250, 64);
            this.Cancle_btn.TabIndex = 2;
            this.Cancle_btn.Text = "Cancle";
            this.Cancle_btn.UseVisualStyleBackColor = false;
            this.Cancle_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Code_lbl
            // 
            this.Code_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Code_lbl.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Italic);
            this.Code_lbl.Location = new System.Drawing.Point(13, 12);
            this.Code_lbl.Name = "Code_lbl";
            this.Code_lbl.Size = new System.Drawing.Size(119, 175);
            this.Code_lbl.TabIndex = 5;
            this.Code_lbl.Text = "Code";
            this.Code_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Key_lbl
            // 
            this.Key_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Key_lbl.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Italic);
            this.Key_lbl.Location = new System.Drawing.Point(11, 207);
            this.Key_lbl.Name = "Key_lbl";
            this.Key_lbl.Size = new System.Drawing.Size(120, 175);
            this.Key_lbl.TabIndex = 6;
            this.Key_lbl.Text = "Key";
            this.Key_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Space_for_key
            // 
            this.Space_for_key.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Space_for_key.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Space_for_key.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Space_for_key.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Space_for_key.HideSelection = false;
            this.Space_for_key.Location = new System.Drawing.Point(137, 207);
            this.Space_for_key.Multiline = true;
            this.Space_for_key.Name = "Space_for_key";
            this.Space_for_key.ReadOnly = true;
            this.Space_for_key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Space_for_key.Size = new System.Drawing.Size(633, 175);
            this.Space_for_key.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 464);
            this.Controls.Add(this.Space_for_key);
            this.Controls.Add(this.Key_lbl);
            this.Controls.Add(this.Code_lbl);
            this.Controls.Add(this.Cancle_btn);
            this.Controls.Add(this.Space_for_code);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Dencrypt_btn);
            this.Name = "MainWindow";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dencrypt_btn;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.TextBox Space_for_code;
        private System.Windows.Forms.Button Cancle_btn;
        private System.Windows.Forms.Label Code_lbl;
        private System.Windows.Forms.Label Key_lbl;
        private System.Windows.Forms.TextBox Space_for_key;
    }
}

