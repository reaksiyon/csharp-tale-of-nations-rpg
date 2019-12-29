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
    public partial class menu : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\emir_\Desktop\TALE OF NATIONS\music\menu.wav");
        public menu()
        {
            InitializeComponent();
            
            sp.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            arena arena = new arena();
            arena.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
