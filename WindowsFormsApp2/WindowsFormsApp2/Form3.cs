using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
 

    public partial class arena : Form
    {
      
        public int counter = 0;
        Timer t = new Timer();
        oyuncu oyuncu = new oyuncu();
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        
        public arena()
        {
            InitializeComponent();
            
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            player.Visible = false;
            playerhp.Visible = true;
            attanim.Visible = true;
        }


        private void InitializeTimer()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
            t.Interval = 800;
            t.Enabled = true;
            
            t.Tick += new EventHandler(timer2_Tick_1);
        }


        void canavar_Click(object sender, EventArgs e)
        {

        }

        private void attack_Click(object sender, EventArgs e)
        {
          
                
                backgroundWorker1.RunWorkerAsync();
            
            Kale kaleyedon = new Kale() { Owner = this };

            if (enemyhp.Value>0 && playerhp.Value>0)
            {

                player.Visible = false;
                playerhp.Visible = false;
                InitializeTimer();
                
                attanim.Visible = false;
                player.Visible = true;
                playerhp.Visible = true;
              
                if (enemyhp.Value - oyuncu.attack < 0)
                    enemyhp.Value = 0;
                else
            enemyhp.Value -= oyuncu.attack;

                

            
            playerhp.Value -= 10;
            player.Visible = true;
            playerhp.Visible = true;
            }else if(playerhp.Value>0 && enemyhp.Value<=0)
            {
                
                oyuncu.exp += 20;
                oyuncu.gold += 10;
                inventory inv = new inventory();
                inv.para.Text = Convert.ToString(oyuncu.gold);
               // inv.Show();
                MessageBox.Show(Convert.ToString(oyuncu.exp + "Exp kazandınız!"));
                
                if (oyuncu.exp >= 100)
                {
                    
                    oyuncu.level++;
                    MessageBox.Show("Tebrikler seviye atladınız! Yeni seviye:" + oyuncu.level);
                    playerhp.Value = playerhp.Maximum;
                    oyuncu.exp = 0;
                    
                }

               

              

                switch(oyuncu.level)
                { 
                    case 1:
                        this.lv.Text = "1";
                        oyuncu.levelhasar = 3;
                        break;
                    case 2:
                        this.lv.Text = "2";
                        oyuncu.levelhasar = 4;
                        break;
                    case 3:
                        this.lv.Text = "3";
                        oyuncu.levelhasar = 5;
                        break;
                    case 4:
                        this.lv.Text = "4";
                        oyuncu.levelhasar = 6;
                        break;
                    case 5:
                        this.lv.Text = "5";
                        oyuncu.levelhasar = 7;
                        break;
                    case 6:
                        this.lv.Text = "6";
                        oyuncu.levelhasar = 8;
                        break;
                    case 7:
                        this.lv.Text = "7";
                        oyuncu.levelhasar = 9;
                        break;
                    case 8:
                        this.lv.Text = "8";
                        oyuncu.levelhasar = 10;
                        break;
                    case 9:
                        this.lv.Text = "9";
                        oyuncu.levelhasar = 11;
                        break;
                    case 10:
                        this.lv.Text = "10";
                        oyuncu.levelhasar = 12;
                        break;
                    case 11:
                        this.lv.Text = "11";
                        oyuncu.levelhasar = 13;
                        break;
                    case 12:
                        this.lv.Text = "12";
                        oyuncu.levelhasar = 14;
                        break;
                    case 13:
                        this.lv.Text = "13";
                        oyuncu.levelhasar = 15;
                        break;
                    case 14:
                        this.lv.Text = "14";
                        oyuncu.levelhasar = 16;
                        break;
                    case 15:
                        this.lv.Text = "15";
                        oyuncu.levelhasar = 17;
                        break;
                    case 16:
                        this.lv.Text = "16";
                        oyuncu.levelhasar = 18;
                        break;
                    case 17:
                        this.lv.Text = "17";
                        oyuncu.levelhasar = 19;
                        break;
                    case 18:
                        this.lv.Text = "18";
                        oyuncu.levelhasar = 20;
                        break;
                    case 19:
                        this.lv.Text = "19";
                        oyuncu.levelhasar = 21;
                        break;
                    case 20:
                        this.lv.Text = "20";
                        oyuncu.levelhasar = 22;
                        break;

                        

                }

                //kazanirsak
                enemyhp.Value = enemyhp.Maximum;
                Random rnd = new Random();
                int cnv = rnd.Next(1, 5);


                Image c1 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c1.png");
                Image c2 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c2.png");
                Image c3 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c3.png");
                Image c4 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c4.png");

                if (cnv == 1)
                {
                    canavar.BackgroundImage = c1;
                    moblv.Text = "1";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 2)
                {
                    canavar.BackgroundImage = c2;
                    moblv.Text = "3";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 3)
                {
                    canavar.BackgroundImage = c3;
                    moblv.Text = "5";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 4)
                {
                    canavar.BackgroundImage = c4;
                    moblv.Text = "10";
                    enemyhp.Maximum += 2;
                    enemyhp.Value = enemyhp.Maximum;
                }

                this.Hide();
                
                kaleyedon.Show();

            }
            else if(playerhp.Value<=0)
            {
                //olursek
                enemyhp.Value = enemyhp.Maximum;
                playerhp.Value = playerhp.Maximum;
                Random rnd = new Random();
                int cnv = rnd.Next(1, 5);


                Image c1 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c1.png");
                Image c2 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c2.png");
                Image c3 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c3.png");
                Image c4 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c4.png");

                if (cnv == 1)
                {
                    canavar.BackgroundImage = c1;
                    moblv.Text = "1";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 2)
                {
                    canavar.BackgroundImage = c2;
                    moblv.Text = "3";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 3)
                {
                    canavar.BackgroundImage = c3;
                    moblv.Text = "5";
                    enemyhp.Maximum += 1;
                    enemyhp.Value = enemyhp.Maximum;
                }
                else if (cnv == 4)
                {
                    canavar.BackgroundImage = c4;
                    moblv.Text = "10";
                    enemyhp.Maximum += 2;
                    enemyhp.Value = enemyhp.Maximum;
                }

                this.Hide();
                
                kaleyedon.Show();
                
            }
        }

        private void flee_Click(object sender, EventArgs e)
        {
            Kale kaleyedon = new Kale() { Owner = this };
            
            this.Hide();
            
            kaleyedon.Show();
            enemyhp.Value = 100;
            Random rnd = new Random();
            int cnv = rnd.Next(1, 5);


            Image c1 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c1.png");
            Image c2 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c2.png");
            Image c3 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c3.png");
            Image c4 = Image.FromFile("C:\\Users\\emir_\\OneDrive\\Belgeler\\Visual Studio 2017\\Projects\\WindowsFormsApp2\\WindowsFormsApp2\\c4.png");

            if (cnv == 1)
            {
                canavar.BackgroundImage = c1;
                moblv.Text = "1";
                enemyhp.Maximum += 1;
                enemyhp.Value = enemyhp.Maximum;
            }
            else if (cnv == 2)
            {
                canavar.BackgroundImage = c2;
                moblv.Text = "3";
                enemyhp.Maximum += 1;
                enemyhp.Value = enemyhp.Maximum;
            }
            else if (cnv == 3)
            {
                canavar.BackgroundImage = c3;
                moblv.Text = "5";
                enemyhp.Maximum += 1;
                enemyhp.Value = enemyhp.Maximum;
            }
            else if (cnv == 4)
            {
                canavar.BackgroundImage = c4;
                moblv.Text = "10";
                enemyhp.Maximum += 2;
                enemyhp.Value = enemyhp.Maximum;
            }
        }
        
        private void arena_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Kale kaleyedon = new Kale() { Owner = this };
            if (oyuncu.isFirst == true)
            {
                
                
            }
            else
            {

                
                kaleyedon.Show();
                timer1.Stop();
                this.Hide();
                oyuncu.isFirst = true;
                
            }
        }



        public void timer2_Tick_1(object sender, EventArgs e)
        {
            player.Visible = false;
            
            playerhp.Visible = true;
            
            attanim.Visible = true;
            counter++;
           
            
        }

        private void attanim_Click(object sender, EventArgs e)
        {

        }
    }

}
