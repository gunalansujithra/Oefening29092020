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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnBoeken_Click(object sender, EventArgs e)
        {
            AddBoeken addBoeken = new AddBoeken();
            addBoeken.Show();
        }

        private void btnViewBoeken_Click(object sender, EventArgs e)
        {
            DisplayBoeken displayBoeken = new DisplayBoeken();
            displayBoeken.Show();
        }

        private void btnAuteurs_Click(object sender, EventArgs e)
        {
            AddAuteurs addAuterus = new AddAuteurs();
            addAuterus.Show();
        }

        private void btnUitgeverijen_Click(object sender, EventArgs e)
        {
            AddUitgeverijen uitgerverijen = new AddUitgeverijen();
            uitgerverijen.Show();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            AddGenres genres = new AddGenres();
            genres.Show();
        }
    }
}
