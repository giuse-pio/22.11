using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDiffDate.Text = "";
            lblDiffDate.Text = (dateTimePicker1.Value.Date - dateTimePicker2.Value.Date).TotalDays.ToString();
        }

        private void btmSomma_Click(object sender, EventArgs e)
        {
            lblNuovaData.Text = "";
            int giorni;
            if (!int.TryParse(txtGiorni.Text, out giorni))
            {
                lblNuovaData.Text = "Inserire un numero valido";
            }
            lblNuovaData.Text = dateTimePicker3.Value.AddDays(giorni).Date.ToShortDateString();
        }

        private void txtGiorni_MouseClick(object sender, MouseEventArgs e)
        {
            txtGiorni.SelectAll();
        }

        private void btmSottrai_Click(object sender, EventArgs e)
        {

            lblNuovaData.Text = "";
            int giorni;
            if (!int.TryParse(txtGiorni.Text, out giorni))
            {
                lblNuovaData.Text = "Inserire un numero valido";
            }
            lblNuovaData.Text = dateTimePicker3.Value.AddDays(-giorni).Date.ToShortDateString();
        }
    }
}
