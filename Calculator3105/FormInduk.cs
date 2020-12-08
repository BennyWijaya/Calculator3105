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
    public partial class FormInduk : Form
    {
        public FormInduk()
        {
            InitializeComponent();
        }

        private void Proses_Click(object sender, EventArgs e)
        {
            FormAnak f7 = new FormAnak();
            f7.OnCreate += FormEntry_OnCreate;
            f7.ShowDialog();
        }
        private void FormEntry_OnCreate(Kalku kal)
        {
            listBox1.Items.Add("Hasil" + kal.Name + " " + kal.Nilaia + " " + kal.Operasi + " " + kal.Nilaib + " " + "=" + " " + kal.Hasil);
        }
    }
}
