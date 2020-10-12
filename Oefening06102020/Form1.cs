using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening06102020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> vergelijkeValueMember = new List<int>() { 11, 18, 24, 29, 34 };
            Dictionary<int, string> mijnDictionary = new Dictionary<int, string>();
            mijnDictionary.Add(12, "Ken");
            mijnDictionary.Add(16, "Geert");
            mijnDictionary.Add(18, "Stef");
            mijnDictionary.Add(20, "Lisa");
            mijnDictionary.Add(23, "Tom");
            mijnDictionary.Add(29, "Ashe");
            mijnDictionary.Add(33, "Dylan");

            lbTest.DisplayMember = "Value";
            lbTest.ValueMember = "Key";
            lbTest.DataSource = mijnDictionary.ToList();
            lbTest.SelectedItems.Clear();

            foreach(var x in vergelijkeValueMember)
            {
                foreach (var y in mijnDictionary)
                {
                    if (y.Key == x)
                    {
                        lbTest.SelectedValue = x;
                    }
                }
            }
            
        }
    }
}
