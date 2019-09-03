namespace TestTask
{
    partial class UCText
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
            this.lblMyText = new System.Windows.Forms.Label();
            this.MyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMyText
            // 
            this.lblMyText.AutoSize = true;
            this.lblMyText.Location = new System.Drawing.Point(33, 10);
            this.lblMyText.Name = "lblMyText";
            this.lblMyText.Size = new System.Drawing.Size(42, 13);
            this.lblMyText.TabIndex = 0;
            this.lblMyText.Text = "MyText";
            // 
            // MyTextBox
            // 
            this.MyTextBox.Location = new System.Drawing.Point(36, 26);
            this.MyTextBox.Name = "MyTextBox";
            this.MyTextBox.Size = new System.Drawing.Size(100, 20);
            this.MyTextBox.TabIndex = 1;
            // 
            // UCText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MyTextBox);
            this.Controls.Add(this.lblMyText);
            this.Name = "UCText";
            this.Size = new System.Drawing.Size(181, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyText;
        private System.Windows.Forms.TextBox MyTextBox;
    }
}
