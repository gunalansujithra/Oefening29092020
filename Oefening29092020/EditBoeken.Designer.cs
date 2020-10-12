namespace Oefening29092020
{
    partial class EditBoeken
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
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.nudPublicatie = new System.Windows.Forms.NumericUpDown();
            this.cbUitgever = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoeken = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicatie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.ItemHeight = 16;
            this.lbGenres.Location = new System.Drawing.Point(254, 173);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbGenres.Size = new System.Drawing.Size(177, 180);
            this.lbGenres.TabIndex = 51;
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.ItemHeight = 16;
            this.lbAuteurs.Location = new System.Drawing.Point(61, 173);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAuteurs.Size = new System.Drawing.Size(177, 180);
            this.lbAuteurs.TabIndex = 50;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(128, 93);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(294, 22);
            this.txtTitel.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Titel:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 45);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudPaginas
            // 
            this.nudPaginas.Location = new System.Drawing.Point(212, 525);
            this.nudPaginas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaginas.Name = "nudPaginas";
            this.nudPaginas.Size = new System.Drawing.Size(181, 22);
            this.nudPaginas.TabIndex = 46;
            this.nudPaginas.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(140, 475);
            this.nudScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(181, 22);
            this.nudScore.TabIndex = 45;
            // 
            // nudPublicatie
            // 
            this.nudPublicatie.Location = new System.Drawing.Point(162, 420);
            this.nudPublicatie.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudPublicatie.Name = "nudPublicatie";
            this.nudPublicatie.Size = new System.Drawing.Size(181, 22);
            this.nudPublicatie.TabIndex = 44;
            this.nudPublicatie.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbUitgever
            // 
            this.cbUitgever.FormattingEnabled = true;
            this.cbUitgever.Location = new System.Drawing.Point(162, 371);
            this.cbUitgever.Name = "cbUitgever";
            this.cbUitgever.Size = new System.Drawing.Size(250, 24);
            this.cbUitgever.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Genre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Auteurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Publicatie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Uitgever:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Aantal Paginas:";
            // 
            // cbBoeken
            // 
            this.cbBoeken.FormattingEnabled = true;
            this.cbBoeken.Location = new System.Drawing.Point(223, 45);
            this.cbBoeken.Name = "cbBoeken";
            this.cbBoeken.Size = new System.Drawing.Size(250, 24);
            this.cbBoeken.TabIndex = 52;
            this.cbBoeken.SelectedIndexChanged += new System.EventHandler(this.cbBoeken_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Select Boeken";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 45);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 45);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditBoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBoeken);
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
            this.Name = "EditBoeken";
            this.Text = "EditBoeken";
            this.Load += new System.EventHandler(this.EditBoeken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.NumericUpDown nudPublicatie;
        private System.Windows.Forms.ComboBox cbUitgever;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoeken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}