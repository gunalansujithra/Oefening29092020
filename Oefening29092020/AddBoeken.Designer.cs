namespace Oefening29092020
{
    partial class AddBoeken
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUitgever = new System.Windows.Forms.ComboBox();
            this.nudPublicatie = new System.Windows.Forms.NumericUpDown();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Genre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Auteurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Publicatie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Uitgever:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Aantal Paginas:";
            // 
            // cbUitgever
            // 
            this.cbUitgever.FormattingEnabled = true;
            this.cbUitgever.Location = new System.Drawing.Point(142, 378);
            this.cbUitgever.Name = "cbUitgever";
            this.cbUitgever.Size = new System.Drawing.Size(250, 24);
            this.cbUitgever.TabIndex = 28;
            // 
            // nudPublicatie
            // 
            this.nudPublicatie.Location = new System.Drawing.Point(142, 427);
            this.nudPublicatie.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudPublicatie.Name = "nudPublicatie";
            this.nudPublicatie.Size = new System.Drawing.Size(181, 22);
            this.nudPublicatie.TabIndex = 29;
            this.nudPublicatie.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(120, 482);
            this.nudScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(181, 22);
            this.nudScore.TabIndex = 30;
            // 
            // nudPaginas
            // 
            this.nudPaginas.Location = new System.Drawing.Point(179, 533);
            this.nudPaginas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaginas.Name = "nudPaginas";
            this.nudPaginas.Size = new System.Drawing.Size(181, 22);
            this.nudPaginas.TabIndex = 31;
            this.nudPaginas.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 45);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Titel:";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(108, 100);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(294, 22);
            this.txtTitel.TabIndex = 34;
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.ItemHeight = 16;
            this.lbAuteurs.Location = new System.Drawing.Point(41, 180);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAuteurs.Size = new System.Drawing.Size(177, 180);
            this.lbAuteurs.TabIndex = 35;
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.ItemHeight = 16;
            this.lbGenres.Location = new System.Drawing.Point(234, 180);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbGenres.Size = new System.Drawing.Size(177, 180);
            this.lbGenres.TabIndex = 36;
            // 
            // AddBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbAuteurs);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudPaginas);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.nudPublicatie);
            this.Controls.Add(this.cbUitgever);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "AddBoeken";
            this.Text = "AddBoeken";
            this.Load += new System.EventHandler(this.AddBoeken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUitgever;
        private System.Windows.Forms.NumericUpDown nudPublicatie;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.ListBox lbGenres;
    }
}