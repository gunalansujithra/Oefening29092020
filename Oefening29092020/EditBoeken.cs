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
    public partial class EditBoeken : Form
    {
        public EditBoeken()
        {
            InitializeComponent();
        }

        private void EditBoeken_Load(object sender, EventArgs e)
        {
            DisplayBoekenDropdown();
        }

        private void cbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBoekenDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string boekTitel = cbBoeken.Text;
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                int selectedBoekId = Convert.ToInt32(cbBoeken.SelectedValue);

                ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(x => x.BoekId == selectedBoekId));

                ctx.BoekenAuteurs.RemoveRange(ctx.BoekenAuteurs.Where(x => x.BoekId == selectedBoekId));

                ctx.Boekens.RemoveRange(ctx.Boekens.Where(x => x.Id == selectedBoekId));

                ctx.SaveChanges();

            }
            MessageBox.Show("Boek " + boekTitel + " is deleted");
            DisplayBoekenDropdown();
            DisplayBoekenDetails();
            

        }

        public void DisplayBoekenDropdown()
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                var boekenQuery = ctx.Boekens.Select(x => x);

                BindingList<Boeken> boekenLijst = new BindingList<Boeken>();

                cbBoeken.DisplayMember = "Titel";
                cbBoeken.ValueMember = "Id";

                foreach (var item in boekenQuery)
                {
                    Boeken boek = new Boeken()
                    {
                        Id = item.Id,
                        Titel = item.Titel,
                    };

                    boekenLijst.Add(boek);
                }

                cbBoeken.DataSource = boekenLijst;
            }
        }

        public void DisplayBoekenDetails()
        {
            if (cbBoeken.SelectedIndex >= 0)
            {
                int boekId = Convert.ToInt32(cbBoeken.SelectedValue);

                using (BoekenEntities1 ctx = new BoekenEntities1())
                {
                    //code for boeken and uitgever
                    var selectedBoek = ctx.Boekens
                                            .Join(ctx.Uitgeverijens,
                                                b => b.UitgeverId,
                                                u => u.Id,
                                                (b, u) => new { b, u }).Where(x => x.b.Id == boekId).FirstOrDefault();

                    txtTitel.Text = selectedBoek.b.Titel;
                    nudPublicatie.Value = (int)selectedBoek.b.Publicatie;
                    nudScore.Value = (int)selectedBoek.b.Score;
                    nudPaginas.Value = (int)selectedBoek.b.AantalPaginas;
                    int uitgeverId = (int)selectedBoek.u.Id;

                    //code for uitgever
                    var uitgeverLijst = ctx.Uitgeverijens.Select(x => new
                    {
                        Uitgever = x.Naam,
                        Id = x.Id
                    }).ToList();
                    cbUitgever.DisplayMember = "Uitgever";
                    cbUitgever.ValueMember = "Id";
                    cbUitgever.DataSource = uitgeverLijst;
                    cbUitgever.SelectedValue = uitgeverId;

                    //code for Genre
                    var genreLijst = ctx.Genres.Select(x => new
                    {
                        Genre = x.Genre1,
                        Id = x.Id
                    }).ToList();
                    lbGenres.DisplayMember = "Genre";
                    lbGenres.ValueMember = "Id";
                    lbGenres.DataSource = genreLijst;

                    var selectedGenre = ctx.BoekenGenres
                                            .Join(ctx.Genres,
                                                g => g.GenreId,
                                                bg1 => bg1.Id,
                                                (g, bg1) => new { g, bg1, Genre = bg1.Genre1 }).Where(x => x.g.BoekId == boekId).ToList();
                    
                    lbGenres.SelectedItems.Clear();
                    foreach(var alleGenre in genreLijst)
                    {
                        foreach(var selGenre in selectedGenre)
                        {
                            if (alleGenre.Id == selGenre.bg1.Id)
                            {
                                lbGenres.SelectedValue = selGenre.bg1.Id;
                            }
                        }
                    }

                    //code for auteurs
                    var auteursLijst = ctx.Auteurs.Select(x => new
                    {
                        Naam = x.Voornaam + " " + x.Achternaam,
                        Id = x.Id
                    }).ToList();
                    lbAuteurs.DisplayMember = "Naam";
                    lbAuteurs.ValueMember = "Id";
                    lbAuteurs.DataSource = auteursLijst;
                    
                    var selectedActeur = ctx.BoekenAuteurs.Where(ba => ba.BoekId == boekId)
                                           .Join(ctx.Auteurs,
                                               ba1 => ba1.AuteurId,
                                               a => a.Id,
                                               (ba1, a) => new { ba1, a, Auteurs = a.Voornaam + " " + a.Achternaam }).ToList();

                    lbAuteurs.SelectedItems.Clear();
                    foreach (var alleAuteur in auteursLijst)
                    {
                        foreach (var selAuteur in selectedActeur)
                        {
                            if (alleAuteur.Id == selAuteur.a.Id)
                            {
                                lbAuteurs.SelectedValue = selAuteur.a.Id;
                            }
                        }
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text.Trim();
            int uitgeverId = Convert.ToInt32(cbUitgever.SelectedValue);
            int publicatie = Convert.ToInt32(nudPublicatie.Value);
            int score = Convert.ToInt32(nudScore.Value);
            int paginas = Convert.ToInt32(nudPaginas.Value);
            int boekId = Convert.ToInt32(cbBoeken.SelectedValue);

            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault().Titel = titel;
                ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault().AantalPaginas = paginas;
                ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault().Score = score;
                ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault().Publicatie = publicatie;
                ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault().UitgeverId = uitgeverId;

                ctx.SaveChanges();

                ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(x => x.BoekId == boekId));

                ctx.BoekenAuteurs.RemoveRange(ctx.BoekenAuteurs.Where(x => x.BoekId == boekId));


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

                MessageBox.Show("Boek saved");
                DisplayBoekenDropdown();
                DisplayBoekenDetails();

            }
        }
    }
}
