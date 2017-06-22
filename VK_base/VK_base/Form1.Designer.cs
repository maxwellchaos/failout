namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();

  this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();          
  this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассылкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискУдаленныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автолайкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискГруппСПохожимКонтентомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоДругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.autoadd = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pirat_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();

            this.SuspendLayout();
            // 
            // webBrowser1
            // 

            this.webBrowser1.Location = new System.Drawing.Point(344, 424);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(563, 248);




            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Niagara Solid", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить всех в друзья";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);

            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1047, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1047, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1203, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 

            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассылкаToolStripMenuItem,
            this.поискУдаленныхToolStripMenuItem,
            this.автолайкToolStripMenuItem,
            this.поискГруппToolStripMenuItem,
            this.поискГруппСПохожимКонтентомToolStripMenuItem,
            this.автоДругToolStripMenuItem});
            this.менюToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // рассылкаToolStripMenuItem
            // 
            this.рассылкаToolStripMenuItem.Name = "рассылкаToolStripMenuItem";
            this.рассылкаToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.рассылкаToolStripMenuItem.Text = "Рассылка";
            this.рассылкаToolStripMenuItem.Click += new System.EventHandler(this.рассылкаToolStripMenuItem_Click);
            // 
            // поискУдаленныхToolStripMenuItem
            // 
            this.поискУдаленныхToolStripMenuItem.Name = "поискУдаленныхToolStripMenuItem";
            this.поискУдаленныхToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.поискУдаленныхToolStripMenuItem.Text = "Поиск удаленных";
            this.поискУдаленныхToolStripMenuItem.Click += new System.EventHandler(this.поискУдаленныхToolStripMenuItem_Click);
            // 
            // автолайкToolStripMenuItem
            // 
            this.автолайкToolStripMenuItem.Name = "автолайкToolStripMenuItem";
            this.автолайкToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.автолайкToolStripMenuItem.Text = "Авто-лайк";
            this.автолайкToolStripMenuItem.Click += new System.EventHandler(this.автолайкToolStripMenuItem_Click);
            // 
            // поискГруппToolStripMenuItem
            // 
            this.поискГруппToolStripMenuItem.Name = "поискГруппToolStripMenuItem";
            this.поискГруппToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.поискГруппToolStripMenuItem.Text = "Поиск групп";
            this.поискГруппToolStripMenuItem.Click += new System.EventHandler(this.поискГруппToolStripMenuItem_Click);
            // 
            // поискГруппСПохожимКонтентомToolStripMenuItem
            // 
            this.поискГруппСПохожимКонтентомToolStripMenuItem.Name = "поискГруппСПохожимКонтентомToolStripMenuItem";
            this.поискГруппСПохожимКонтентомToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.поискГруппСПохожимКонтентомToolStripMenuItem.Text = "Поиск групп с похожим контентом";
            // 
            // автоДругToolStripMenuItem

            // 
            this.автоДругToolStripMenuItem.Name = "автоДругToolStripMenuItem";
            this.автоДругToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.автоДругToolStripMenuItem.Text = "Авто друг";
            // 
            // autoadd
            // 
            this.autoadd.AutoSize = true;
            this.autoadd.BackColor = System.Drawing.Color.White;
            this.autoadd.Location = new System.Drawing.Point(1047, 210);
            this.autoadd.Name = "autoadd";
            this.autoadd.Size = new System.Drawing.Size(198, 17);
            this.autoadd.TabIndex = 8;
            this.autoadd.Text = "Принимать все запросы в друзья";
            this.autoadd.UseVisualStyleBackColor = false;
            // 
            // Pirat_button
            // 

            this.Pirat_button.BackColor = System.Drawing.Color.White;
            this.Pirat_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pirat_button.BackgroundImage")));
            this.Pirat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pirat_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pirat_button.Location = new System.Drawing.Point(1101, 267);

            this.Pirat_button.Name = "Pirat_button";
            this.Pirat_button.Size = new System.Drawing.Size(184, 77);
            this.Pirat_button.TabIndex = 11;
            this.Pirat_button.Text = "News";
            this.Pirat_button.UseVisualStyleBackColor = false;

            this.Pirat_button.Click += new System.EventHandler(this.Pirat_button_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1012, 381);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 348);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1047, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "UNLOG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(997, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(357, 710);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);

            this.Controls.Add(this.Pirat_button);
            this.Controls.Add(this.autoadd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);

            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);

            this.MainMenuStrip = this.menuStrip1;
          
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);

            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассылкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискУдаленныхToolStripMenuItem;

        private System.Windows.Forms.CheckBox autoadd;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button Pirat_button;
        private System.Windows.Forms.ToolStripMenuItem автолайкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискГруппСПохожимКонтентомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоДругToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

