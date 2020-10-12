using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening29092020
{
    public partial class AddBoeken : Form
    {
        public AddBoeken()
        {
            InitializeComponent();
        }

        private void AddBoeken_Load(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                //code for autuers
                var auteursLijst = ctx.Auteurs.Select(x => new
                                                { 
                                                    Naam = x.Voornaam + " " + x.Achternaam,
                                                    Id = x.Id
                                                }).ToList();
                lbAuteurs.DisplayMember = "Naam";
                lbAuteurs.ValueMember = "Id";
                lbAuteurs.DataSource = auteursLijst;

                //code for genre
                var genreLijst = ctx.Genres.Select(x => new
                                                {
                                                    Genre = x.Genre1,
                                                    Id = x.Id
                                                }).ToList(); 
                lbGenres.DisplayMember = "Genre";
                lbGenres.ValueMember = "Id";
                lbGenres.DataSource = genreLijst;

                //code for uitgever
                var uitgeverLijst = ctx.Uitgeverijens.Select(x => new
                                                {
                                                    Uitgever = x.Naam,
                                                    Id = x.Id
                                                }).ToList();
                cbUitgever.DisplayMember = "Uitgever";
                cbUitgever.ValueMember = "Id";
                cbUitgever.DataSource = uitgeverLijst;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text.Trim();
            int uitgeverId = Convert.ToInt32(cbUitgever.SelectedValue);
            int publicatie = Convert.ToInt32(nudPublicatie.Value);
            int score = Convert.ToInt32(nudScore.Value);
            int paginas = Convert.ToInt32(nudPaginas.Value);

            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                Boeken newBoeken = new Boeken();
                newBoeken.Titel = titel;
                newBoeken.AantalPaginas = paginas;
                newBoeken.Score = score;
                newBoeken.Publicatie = publicatie;
                newBoeken.UitgeverId = uitgeverId;

                ctx.Boekens.Add(newBoeken);
                ctx.SaveChanges();

                int boekId = newBoeken.Id;

                

                foreach (var item in lbAuteurs.SelectedItems)
                {
                    BoekenAuteur newBoekenAuteur = new BoekenAuteur();
                    newBoekenAuteur.BoekId = boekId;
                    newBoekenAuteur.AuteurId = (Int32)item.GetType().GetProperty("Id").GetValue(item);
                    ctx.BoekenAuteurs.Add(newBoekenAuteur);
                    ctx.SaveChanges();

                }

                foreach (var item in lbGenres.SelectedItems)
                {
                    BoekenGenre newBoekenGenre = new BoekenGenre();                   
                    newBoekenGenre.GenreId = (Int32)item.GetType().GetProperty("Id").GetValue(item);
                    newBoekenGenre.BoekId = boekId;
                    ctx.BoekenGenres.Add(newBoekenGenre);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Boek toegevoegt");
                this.Close();
                                
                txtTitel.Clear();
                lbAuteurs.SelectedIndex = 0;
                lbGenres.SelectedIndex = 0;
                nudPaginas.Value = 200;
                nudPublicatie.Value = 2000;
                nudScore.Value = 0;

            }
        }
    }
}
