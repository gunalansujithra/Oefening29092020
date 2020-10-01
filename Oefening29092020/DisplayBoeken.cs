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
            using(BoekenEntities ctx = new BoekenEntities())
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

            using (BoekenEntities ctx = new BoekenEntities())
            {
                Boeken selectedBoek = ctx.Boekens.Where(b => b.Id == boekId).FirstOrDefault();

                Uitgeverijen selectedUitgever = ctx.Uitgeverijens.Where(u => u.Id == selectedBoek.UitgeverId).FirstOrDefault();

                var selectedGenre = ctx.BoekenGenres.Where(bg => bg.BoekId == boekId)
                                        .Join(ctx.Genres,
                                            g => g.GenreId,
                                            bg1 => bg1.Id,
                                            (g, bg1) => new { g, bg1 });

                var selectedActeur = ctx.BoekenAuteurs.Where(ba => ba.BoekId == boekId)
                                       .Join(ctx.Auteurs,
                                           ba1 => ba1.AuteurId,
                                           a => a.Id,
                                           (ba1, a) => new { ba1, a });

                lblTitle.Text = selectedBoek.Titel;

                string auter = "";
                string genre = "";

                foreach (var item in selectedActeur)
                {
                    auter += item.a.Voornaam + " " + item.a.Achternaam + ", ";
                }

                foreach (var item in selectedGenre)
                {
                    genre += item.bg1.Genre1 + ", ";
                }

                lblActuer.Text = auter.Substring(0, auter.Length - 2);
                lblGenre.Text = genre.Substring(0, genre.Length - 2);
                lblUitgever.Text = selectedUitgever.Naam;
                lblPublicatie.Text = selectedBoek.Publicatie.ToString();
                lblScore.Text = selectedBoek.Score.ToString();
                lblAantalPaginas.Text = selectedBoek.AantalPaginas.ToString();

            }
        }

    }
}
