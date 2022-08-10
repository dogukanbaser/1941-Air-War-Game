using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogukanBaser
{
    public partial class Nasıl_oynanır : Form
    {
        public Nasıl_oynanır()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 oyun = new Form2();
            oyun.Show();  // form2 göster diyoruz
            this.Hide();
        }
    }
}
