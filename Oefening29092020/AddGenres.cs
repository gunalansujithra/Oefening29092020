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
    public partial class AddGenres : Form
    {
        public AddGenres()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGenres_Load(object sender, EventArgs e)
        {
            DisplayGenres();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Genres.Add(new Genre() { Genre1 = txtNaam.Text});
                ctx.SaveChanges();
            }
            txtNaam.Clear();
            DisplayGenres();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Genres.RemoveRange(ctx.Genres.Where(x => x.Id == (int)lbGenre.SelectedValue));
                ctx.SaveChanges();
            }

            DisplayGenres();
        }

        public void DisplayGenres()
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                //code for autuers
                var genresLijst = ctx.Genres.Select(x => new
                {
                    Naam = x.Genre1,
                    Id = x.Id
                }).ToList();
                lbGenre.DisplayMember = "Naam";
                lbGenre.ValueMember = "Id";
                lbGenre.DataSource = genresLijst;
            }
        }
    }
}
