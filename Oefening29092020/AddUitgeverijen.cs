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
    public partial class AddUitgeverijen : Form
    {
        public AddUitgeverijen()
        {
            InitializeComponent();
        }

        private void AddUitgeverijen_Load(object sender, EventArgs e)
        {
            DisplayUitgever();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Uitgeverijens.Add(new Uitgeverijen() { Naam = txtNaam.Text });
                ctx.SaveChanges();
            }
            txtNaam.Clear();
            DisplayUitgever();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                ctx.Uitgeverijens.RemoveRange(ctx.Uitgeverijens.Where(x => x.Id == (int)lbUitgever.SelectedValue));
                ctx.SaveChanges();
            }

            DisplayUitgever();
        }

        public void DisplayUitgever()
        {
            using (BoekenEntities1 ctx = new BoekenEntities1())
            {
                //code for autuers
                var uitgeverLijst = ctx.Uitgeverijens.Select(x => new
                {
                    Naam = x.Naam,
                    Id = x.Id
                }).ToList();
                lbUitgever.DisplayMember = "Naam";
                lbUitgever.ValueMember = "Id";
                lbUitgever.DataSource = uitgeverLijst;
            }
        }
    }
}
