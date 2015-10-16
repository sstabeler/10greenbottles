namespace _10greenbottles
{
    partial class Form1
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
            this.lstBoxoutput = new System.Windows.Forms.ListBox();
            this.btnWriteSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxoutput
            // 
            this.lstBoxoutput.FormattingEnabled = true;
            this.lstBoxoutput.Location = new System.Drawing.Point(419, 65);
            this.lstBoxoutput.Name = "lstBoxoutput";
            this.lstBoxoutput.Size = new System.Drawing.Size(224, 186);
            this.lstBoxoutput.TabIndex = 0;
            // 
            // btnWriteSong
            // 
            this.btnWriteSong.Location = new System.Drawing.Point(784, 131);
            this.btnWriteSong.Name = "btnWriteSong";
            this.btnWriteSong.Size = new System.Drawing.Size(102, 53);
            this.btnWriteSong.TabIndex = 1;
            this.btnWriteSong.Text = "10 green Bottles";
            this.btnWriteSong.UseVisualStyleBackColor = true;
            this.btnWriteSong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWriteSong_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 622);
            this.Controls.Add(this.btnWriteSong);
            this.Controls.Add(this.lstBoxoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxoutput;
        private System.Windows.Forms.Button btnWriteSong;
    }
}

