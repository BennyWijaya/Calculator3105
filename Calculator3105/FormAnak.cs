using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3105
{
    public partial class FormAnak : Form
    {
        public delegate void CreateUpdateEventHandler(Kalku kal);
        public event CreateUpdateEventHandler OnCreate;
        private Kalku kal; 
        public FormAnak()

        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            kal = new Kalku();
            kal.Name = this.comboBox1.Text.ToLower();
            kal.Operasi = string.Empty;
            kal.Hasil = 0;
            kal.Nilaia = Double.Parse(this.NilaiA.Text);
            kal.Nilaib = Double.Parse(this.NilaiB.Text);


            if (this.comboBox1.SelectedIndex == 0)
            {
                kal.Hasil = kal.Nilaia + kal.Nilaib;
                kal.Operasi = "+";
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                kal.Hasil = kal.Nilaia - kal.Nilaib;
                kal.Operasi = "-";
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                kal.Hasil = kal.Nilaia * kal.Nilaib;
                kal.Operasi = "*";
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                kal.Hasil = kal.Nilaia / kal.Nilaib;
                kal.Operasi = "/";
            }
            this.OnCreate(kal);
        }
    }
}
