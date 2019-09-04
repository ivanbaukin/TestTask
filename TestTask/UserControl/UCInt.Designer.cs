namespace TestTask
{
    partial class UCInt
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
            this.lblMyInt = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyInt
            // 
            this.lblMyInt.AutoSize = true;
            this.lblMyInt.Location = new System.Drawing.Point(4, 11);
            this.lblMyInt.Name = "lblMyInt";
            this.lblMyInt.Size = new System.Drawing.Size(33, 13);
            this.lblMyInt.TabIndex = 0;
            this.lblMyInt.Text = "MyInt";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(45, 9);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 1;
            // 
            // UCInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblMyInt);
            this.Name = "UCInt";
            this.Size = new System.Drawing.Size(176, 37);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyInt;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
