using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO02
{
    public partial class Form2 : Form
    {
        public Form2(DataGridViewRow Dset)
        {
            InitializeComponent();
            print(Dset);

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }
        private void print(DataGridViewRow Dset)
        {
            code.Text = Dset.Cells[0].Value.ToString();
            stopcode.Text = Dset.Cells[1].Value.ToString();
            stopname.Text = Dset.Cells[2].Value.ToString();
            XLine.Text = Dset.Cells[5].Value.ToString();
            YLine.Text = Dset.Cells[4].Value.ToString();
            place.Text = Dset.Cells[6].Value.ToString();


        }

        private void GoogleMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + YLine.Text + "," + XLine.Text);
        }

        private void down_Click(object sender, EventArgs e)
        {

        }
    }
}
