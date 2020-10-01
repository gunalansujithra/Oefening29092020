namespace Oefening29092020
{
    partial class DisplayBoeken
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
            this.lbName = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAantalPaginas = new System.Windows.Forms.Label();
            this.lblUitgever = new System.Windows.Forms.Label();
            this.lblPublicatie = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblActuer = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 16;
            this.lbName.Location = new System.Drawing.Point(61, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(298, 324);
            this.lbName.TabIndex = 0;
            this.lbName.SelectedIndexChanged += new System.EventHandler(this.lbName_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(397, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblAantalPaginas
            // 
            this.lblAantalPaginas.AutoSize = true;
            this.lblAantalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalPaginas.Location = new System.Drawing.Point(560, 309);
            this.lblAantalPaginas.Name = "lblAantalPaginas";
            this.lblAantalPaginas.Size = new System.Drawing.Size(53, 20);
            this.lblAantalPaginas.TabIndex = 2;
            this.lblAantalPaginas.Text = "label1";
            // 
            // lblUitgever
            // 
            this.lblUitgever.AutoSize = true;
            this.lblUitgever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitgever.Location = new System.Drawing.Point(500, 198);
            this.lblUitgever.Name = "lblUitgever";
            this.lblUitgever.Size = new System.Drawing.Size(53, 20);
            this.lblUitgever.TabIndex = 3;
            this.lblUitgever.Text = "label2";
            // 
            // lblPublicatie
            // 
            this.lblPublicatie.AutoSize = true;
            this.lblPublicatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicatie.Location = new System.Drawing.Point(515, 236);
            this.lblPublicatie.Name = "lblPublicatie";
            this.lblPublicatie.Size = new System.Drawing.Size(53, 20);
            this.lblPublicatie.TabIndex = 4;
            this.lblPublicatie.Text = "label3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(477, 275);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "label4";
            // 
            // lblActuer
            // 
            this.lblActuer.AutoSize = true;
            this.lblActuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuer.Location = new System.Drawing.Point(500, 120);
            this.lblActuer.Name = "lblActuer";
            this.lblActuer.Size = new System.Drawing.Size(53, 20);
            this.lblActuer.TabIndex = 6;
            this.lblActuer.Text = "label5";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(485, 157);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(53, 20);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Genre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Acteurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publicatie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uitgever:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Aantal Paginas:";
            // 
            // DisplayBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblActuer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPublicatie);
            this.Controls.Add(this.lblUitgever);
            this.Controls.Add(this.lblAantalPaginas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbName);
            this.Name = "DisplayBoeken";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DisplayBoeken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAantalPaginas;
        private System.Windows.Forms.Label lblUitgever;
        private System.Windows.Forms.Label lblPublicatie;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblActuer;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

