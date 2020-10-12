using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening29092020
{
    public partial class DisplayBoeken : Form
    {
        public DisplayBoeken()
        {
            InitializeComponent();
        }

        private void DisplayBoeken_Load(object sender, EventArgs e)
        {
            using(BoekenEntities1 ctx = new BoekenEntities1())
            {
                var boekenQuery = ctx.Boekens.Select(x => x);

                BindingList<Boeken> boekenLijst = new BindingList<Boeken>();

                lbName.DisplayMember = "Titel";
                lbName.ValueMember = "Id";

                foreach (var item in boekenQuery)
                {
                    Boeken boek = new Boeken()
                    {
                        Id = item.Id,
                        Titel = item.Titel,
                    };

                    boekenLijst.Add(boek);
                }

                lbName.DataSource = boekenLijst;
            }
        }

        private void lbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int boekId = Convert.ToInt32(lbName.SelectedValue);

            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                //code for boeken and uitgever
                var selectedBoek = ctx.Boekens
                                        .Join(ctx.Uitgeverijens,
                                            b => b.UitgeverId,
                                            u => u.Id,
                                            (b, u) => new { b, u }).Where(x => x.b.Id == boekId).FirstOrDefault();

                lblTitle.Text = selectedBoek.b.Titel;
                lblUitgever.Text = selectedBoek.u.Naam;
                lblPublicatie.Text = selectedBoek.b.Publicatie.ToString();
                lblScore.Text = selectedBoek.b.Score.ToString();
                lblAantalPaginas.Text = selectedBoek.b.AantalPaginas.ToString();

                //code for Genre
                var selectedGenre = ctx.BoekenGenres
                                        .Join(ctx.Genres,
                                            g => g.GenreId,
                                            bg1 => bg1.Id,
                                            (g, bg1) => new { g, bg1, Genre = bg1.Genre1 }).Where(x => x.g.BoekId == boekId).ToList();

                lbGenre.DisplayMember = "Genre";
                lbGenre.DataSource = selectedGenre;

                //code to display genre in label
                string genre = "";
                foreach (var item in selectedGenre)
                {
                    genre += item.bg1.Genre1 + ", ";
                }
                lblGenre.Text = genre.Substring(0, genre.Length - 2);

                //code for auteurs
                var selectedActeur = ctx.BoekenAuteurs.Where(ba => ba.BoekId == boekId)
                                       .Join(ctx.Auteurs,
                                           ba1 => ba1.AuteurId,
                                           a => a.Id,
                                           (ba1, a) => new { ba1, a, Auteurs = a.Voornaam + " " + a.Achternaam }).ToList();

                lbAuteurs.DisplayMember = "Auteurs";
                lbAuteurs.DataSource = selectedActeur;

                //code to display auters in label
                string auter = "";
                foreach (var item in selectedActeur)
                {
                    auter += item.a.Voornaam + " " + item.a.Achternaam + ", ";
                }
                lblActuer.Text = auter.Substring(0, auter.Length - 2);
                
            }
        }

    }
}
