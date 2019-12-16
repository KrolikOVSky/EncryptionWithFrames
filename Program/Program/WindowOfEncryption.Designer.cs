namespace EncryptionWithFrames
{
    partial class WindowOfEncryption
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
            this.EnterTextSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancle_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.OK_btn.Location = new System.Drawing.Point(12, 415);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(230, 38);
            this.OK_btn.TabIndex = 1;
            this.OK_btn.Text = "OK";
            this.OK_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // EnterTextSpace
            // 
            this.EnterTextSpace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EnterTextSpace.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.EnterTextSpace.Location = new System.Drawing.Point(12, 86);
            this.EnterTextSpace.Multiline = true;
            this.EnterTextSpace.Name = "EnterTextSpace";
            this.EnterTextSpace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EnterTextSpace.Size = new System.Drawing.Size(470, 323);
            this.EnterTextSpace.TabIndex = 0;
            this.EnterTextSpace.Text = "New line";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter text for Encrypting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "first",
            "second",
            "third",
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(619, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // WindowOfEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 465);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cancle_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterTextSpace);
            this.Controls.Add(this.OK_btn);
            this.Name = "WindowOfEncryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox EnterTextSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancle_btn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}