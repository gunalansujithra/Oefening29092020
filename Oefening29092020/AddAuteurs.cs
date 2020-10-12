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
    public partial class AddAuteurs : Form
    {
        public AddAuteurs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Auteurs.Add(new Auteur() { Voornaam = txtVoornaam.Text, Achternaam = txtAchternaam.Text });
                ctx.SaveChanges();
            }
            txtVoornaam.Clear();
            txtAchternaam.Clear();
            DisplayAuteurs();
        }

        public void DisplayAuteurs()
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
            }
        }

        private void AddAuteurs_Load(object sender, EventArgs e)
        {
            DisplayAuteurs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Auteurs.RemoveRange(ctx.Auteurs.Where(x => x.Id == (int)lbAuteurs.SelectedValue));
                ctx.SaveChanges();
            }

            DisplayAuteurs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
