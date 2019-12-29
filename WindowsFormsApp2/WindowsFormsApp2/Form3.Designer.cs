namespace WindowsFormsApp2
{
    partial class arena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arena));
            this.player = new System.Windows.Forms.PictureBox();
            this.canavar = new System.Windows.Forms.PictureBox();
            this.attack = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Button();
            this.flee = new System.Windows.Forms.Button();
            this.enemyhp = new System.Windows.Forms.ProgressBar();
            this.playerhp = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lv = new System.Windows.Forms.Label();
            this.nonme = new System.Windows.Forms.Label();
            this.moblv = new System.Windows.Forms.Label();
            this.moblvtext = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.attanim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canavar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attanim)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(363, 252);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(155, 176);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // canavar
            // 
            this.canavar.BackColor = System.Drawing.Color.Transparent;
            this.canavar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canavar.BackgroundImage")));
            this.canavar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canavar.Location = new System.Drawing.Point(524, 184);
            this.canavar.Name = "canavar";
            this.canavar.Size = new System.Drawing.Size(352, 244);
            this.canavar.TabIndex = 1;
            this.canavar.TabStop = false;
            this.canavar.Click += new System.EventHandler(this.canavar_Click);
            // 
            // attack
            // 
            this.attack.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack.Location = new System.Drawing.Point(12, 12);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(118, 44);
            this.attack.TabIndex = 2;
            this.attack.Text = "SALDIR";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // def
            // 
            this.def.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def.Location = new System.Drawing.Point(148, 12);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(118, 44);
            this.def.TabIndex = 3;
            this.def.Text = "SAVUN";
            this.def.UseVisualStyleBackColor = true;
            // 
            // flee
            // 
            this.flee.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flee.Location = new System.Drawing.Point(287, 12);
            this.flee.Name = "flee";
            this.flee.Size = new System.Drawing.Size(118, 44);
            this.flee.TabIndex = 4;
            this.flee.Text = "KAÇ";
            this.flee.UseVisualStyleBackColor = true;
            this.flee.Click += new System.EventHandler(this.flee_Click);
            // 
            // enemyhp
            // 
            this.enemyhp.Location = new System.Drawing.Point(524, 128);
            this.enemyhp.Name = "enemyhp";
            this.enemyhp.Size = new System.Drawing.Size(352, 33);
            this.enemyhp.TabIndex = 5;
            this.enemyhp.Value = 100;
            // 
            // playerhp
            // 
            this.playerhp.Location = new System.Drawing.Point(100, 207);
            this.playerhp.Maximum = 200;
            this.playerhp.Name = "playerhp";
            this.playerhp.Size = new System.Drawing.Size(154, 25);
            this.playerhp.TabIndex = 6;
            this.playerhp.Value = 200;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lv
            // 
            this.lv.AutoSize = true;
            this.lv.BackColor = System.Drawing.Color.Transparent;
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv.ForeColor = System.Drawing.Color.Red;
            this.lv.Location = new System.Drawing.Point(200, 176);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(27, 29);
            this.lv.TabIndex = 8;
            this.lv.Text = "1";
            // 
            // nonme
            // 
            this.nonme.AutoSize = true;
            this.nonme.BackColor = System.Drawing.Color.Transparent;
            this.nonme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nonme.ForeColor = System.Drawing.Color.Red;
            this.nonme.Location = new System.Drawing.Point(116, 175);
            this.nonme.Name = "nonme";
            this.nonme.Size = new System.Drawing.Size(83, 29);
            this.nonme.TabIndex = 7;
            this.nonme.Text = "Level:";
            // 
            // moblv
            // 
            this.moblv.AutoSize = true;
            this.moblv.BackColor = System.Drawing.Color.Transparent;
            this.moblv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moblv.ForeColor = System.Drawing.Color.Red;
            this.moblv.Location = new System.Drawing.Point(719, 97);
            this.moblv.Name = "moblv";
            this.moblv.Size = new System.Drawing.Size(27, 29);
            this.moblv.TabIndex = 10;
            this.moblv.Text = "1";
            // 
            // moblvtext
            // 
            this.moblvtext.AutoSize = true;
            this.moblvtext.BackColor = System.Drawing.Color.Transparent;
            this.moblvtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moblvtext.ForeColor = System.Drawing.Color.Red;
            this.moblvtext.Location = new System.Drawing.Point(635, 96);
            this.moblvtext.Name = "moblvtext";
            this.moblvtext.Size = new System.Drawing.Size(83, 29);
            this.moblvtext.TabIndex = 9;
            this.moblvtext.Text = "Level:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // attanim
            // 
            this.attanim.BackColor = System.Drawing.Color.Transparent;
            this.attanim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attanim.BackgroundImage")));
            this.attanim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attanim.Location = new System.Drawing.Point(99, 252);
            this.attanim.Name = "attanim";
            this.attanim.Size = new System.Drawing.Size(155, 176);
            this.attanim.TabIndex = 11;
            this.attanim.TabStop = false;
            this.attanim.Visible = false;
            this.attanim.Click += new System.EventHandler(this.attanim_Click);
            // 
            // arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.attanim);
            this.Controls.Add(this.moblv);
            this.Controls.Add(this.moblvtext);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.nonme);
            this.Controls.Add(this.playerhp);
            this.Controls.Add(this.enemyhp);
            this.Controls.Add(this.flee);
            this.Controls.Add(this.def);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.canavar);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "arena";
            this.Text = "Tale Of Nations - Arena";
            this.Load += new System.EventHandler(this.arena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canavar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attanim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        public System.Windows.Forms.PictureBox canavar;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button def;
        private System.Windows.Forms.Button flee;
        private System.Windows.Forms.ProgressBar enemyhp;
        private System.Windows.Forms.ProgressBar playerhp;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lv;
        public System.Windows.Forms.Label nonme;
        public System.Windows.Forms.Label moblv;
        public System.Windows.Forms.Label moblvtext;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox attanim;
    }
}