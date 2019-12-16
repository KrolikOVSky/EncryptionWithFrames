namespace EncryptionWithFrames
{
    partial class WindowOfDecryption
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.Cancle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.OK_btn.Location = new System.Drawing.Point(12, 415);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(230, 38);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(470, 323);
            this.textBox1.TabIndex = 1;
            // 
            // info_lbl
            // 
            this.info_lbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_lbl.Location = new System.Drawing.Point(12, 9);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(470, 63);
            this.info_lbl.TabIndex = 2;
            this.info_lbl.Text = "Enter text for Encrypting";
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancle_btn
            // 
            this.Cancle_btn.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.Cancle_btn.Location = new System.Drawing.Point(248, 415);
            this.Cancle_btn.Name = "Cancle_btn";
            this.Cancle_btn.Size = new System.Drawing.Size(234, 38);
            this.Cancle_btn.TabIndex = 3;
            this.Cancle_btn.Text = "Cancle";
            this.Cancle_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cancle_btn.UseVisualStyleBackColor = true;
            this.Cancle_btn.Click += new System.EventHandler(this.Cancle_btn_Click);
            // 
            // WindowOfDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 465);
            this.Controls.Add(this.Cancle_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OK_btn);
            this.Name = "WindowOfDecryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Button Cancle_btn;
        private System.Windows.Forms.Label info_lbl;
    }
}