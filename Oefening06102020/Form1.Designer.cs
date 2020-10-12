namespace Oefening06102020
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
            this.lbTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.ItemHeight = 16;
            this.lbTest.Location = new System.Drawing.Point(112, 88);
            this.lbTest.Name = "lbTest";
            this.lbTest.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTest.Size = new System.Drawing.Size(230, 292);
            this.lbTest.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTest;
    }
}

