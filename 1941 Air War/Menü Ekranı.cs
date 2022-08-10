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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyun oyun = new oyun();
            oyun.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nasıl_oynanır oyun = new Nasıl_oynanır();
            oyun.Show();  // form2 göster diyoruz
            this.Hide();
        }
    }
}
