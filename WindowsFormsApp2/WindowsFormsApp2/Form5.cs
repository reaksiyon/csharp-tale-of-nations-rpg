using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Kale : Form
    {
        public oyuncu oyuncu = new oyuncu();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\emir_\Desktop\TALE OF NATIONS\music\town.wav");

        public Kale()
        {
            InitializeComponent();

            sp.PlayLooping();
        }

        private void Kale_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\emir_\Desktop\TALE OF NATIONS\music\arena.wav");
            sp.Play();
            this.Hide();
            Owner.Show();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventory inv = new inventory();
            inv.Show();
        }

        private void nonme_Click(object sender, EventArgs e)
        {
            
        }



        private void lv_Click(object sender, EventArgs e)
        {

        }
    }
}
