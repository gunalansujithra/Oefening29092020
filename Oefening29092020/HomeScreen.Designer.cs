namespace Oefening29092020
{
    partial class HomeScreen
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
            this.btnBoeken = new System.Windows.Forms.Button();
            this.btnViewBoeken = new System.Windows.Forms.Button();
            this.btnAuteurs = new System.Windows.Forms.Button();
            this.btnUitgeverijen = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.btnEditBoeken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoeken
            // 
            this.btnBoeken.Location = new System.Drawing.Point(197, 41);
            this.btnBoeken.Name = "btnBoeken";
            this.btnBoeken.Size = new System.Drawing.Size(199, 44);
            this.btnBoeken.TabIndex = 0;
            this.btnBoeken.Text = "Add Boeken";
            this.btnBoeken.UseVisualStyleBackColor = true;
            this.btnBoeken.Click += new System.EventHandler(this.btnBoeken_Click);
            // 
            // btnViewBoeken
            // 
            this.btnViewBoeken.Location = new System.Drawing.Point(197, 110);
            this.btnViewBoeken.Name = "btnViewBoeken";
            this.btnViewBoeken.Size = new System.Drawing.Size(199, 44);
            this.btnViewBoeken.TabIndex = 1;
            this.btnViewBoeken.Text = "View Boeken";
            this.btnViewBoeken.UseVisualStyleBackColor = true;
            this.btnViewBoeken.Click += new System.EventHandler(this.btnViewBoeken_Click);
            // 
            // btnAuteurs
            // 
            this.btnAuteurs.Location = new System.Drawing.Point(197, 182);
            this.btnAuteurs.Name = "btnAuteurs";
            this.btnAuteurs.Size = new System.Drawing.Size(199, 44);
            this.btnAuteurs.TabIndex = 2;
            this.btnAuteurs.Text = "Add Auteurs";
            this.btnAuteurs.UseVisualStyleBackColor = true;
            this.btnAuteurs.Click += new System.EventHandler(this.btnAuteurs_Click);
            // 
            // btnUitgeverijen
            // 
            this.btnUitgeverijen.Location = new System.Drawing.Point(197, 261);
            this.btnUitgeverijen.Name = "btnUitgeverijen";
            this.btnUitgeverijen.Size = new System.Drawing.Size(199, 44);
            this.btnUitgeverijen.TabIndex = 3;
            this.btnUitgeverijen.Text = "Add Uitgeverijen ";
            this.btnUitgeverijen.UseVisualStyleBackColor = true;
            this.btnUitgeverijen.Click += new System.EventHandler(this.btnUitgeverijen_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Location = new System.Drawing.Point(197, 335);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(199, 44);
            this.btnGenres.TabIndex = 4;
            this.btnGenres.Text = "Add Genres ";
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // btnEditBoeken
            // 
            this.btnEditBoeken.Location = new System.Drawing.Point(197, 403);
            this.btnEditBoeken.Name = "btnEditBoeken";
            this.btnEditBoeken.Size = new System.Drawing.Size(199, 44);
            this.btnEditBoeken.TabIndex = 5;
            this.btnEditBoeken.Text = "Edit / Delete Boeken";
            this.btnEditBoeken.UseVisualStyleBackColor = true;
            this.btnEditBoeken.Click += new System.EventHandler(this.btnEditBoeken_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 595);
            this.Controls.Add(this.btnEditBoeken);
            this.Controls.Add(this.btnGenres);
            this.Controls.Add(this.btnUitgeverijen);
            this.Controls.Add(this.btnAuteurs);
            this.Controls.Add(this.btnViewBoeken);
            this.Controls.Add(this.btnBoeken);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoeken;
        private System.Windows.Forms.Button btnViewBoeken;
        private System.Windows.Forms.Button btnAuteurs;
        private System.Windows.Forms.Button btnUitgeverijen;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Button btnEditBoeken;
    }
}