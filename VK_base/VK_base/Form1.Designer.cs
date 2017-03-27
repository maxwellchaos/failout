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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpamButton = new System.Windows.Forms.Button();
            this.DogPatulButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассылкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискУдаленныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoLike_button = new System.Windows.Forms.Button();
            this.autoadd = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.find_groups_box = new System.Windows.Forms.TextBox();
            this.find_groups_button = new System.Windows.Forms.Button();
            this.addFriends_button = new System.Windows.Forms.Button();
            this.gropssercbaton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(945, 446);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 130);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SpamButton
            // 
            this.SpamButton.Location = new System.Drawing.Point(709, 39);
            this.SpamButton.Name = "SpamButton";
            this.SpamButton.Size = new System.Drawing.Size(184, 25);
            this.SpamButton.TabIndex = 4;
            this.SpamButton.Text = "Рассылка";
            this.SpamButton.UseVisualStyleBackColor = true;
            this.SpamButton.Click += new System.EventHandler(this.SpamButton_Click);
            // 
            // DogPatulButton
            // 
            this.DogPatulButton.Location = new System.Drawing.Point(709, 80);
            this.DogPatulButton.Name = "DogPatulButton";
            this.DogPatulButton.Size = new System.Drawing.Size(184, 23);
            this.DogPatulButton.TabIndex = 5;
            this.DogPatulButton.Text = "Собачий патруль";
            this.DogPatulButton.UseVisualStyleBackColor = true;
            this.DogPatulButton.Click += new System.EventHandler(this.DogPatulButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассылкаToolStripMenuItem,
            this.поискУдаленныхToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // рассылкаToolStripMenuItem
            // 
            this.рассылкаToolStripMenuItem.Name = "рассылкаToolStripMenuItem";
            this.рассылкаToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.рассылкаToolStripMenuItem.Text = "Рассылка";
            // 
            // поискУдаленныхToolStripMenuItem
            // 
            this.поискУдаленныхToolStripMenuItem.Name = "поискУдаленныхToolStripMenuItem";
            this.поискУдаленныхToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.поискУдаленныхToolStripMenuItem.Text = "Поиск удаленных";
            // 
            // AutoLike_button
            // 
            this.AutoLike_button.Location = new System.Drawing.Point(709, 124);
            this.AutoLike_button.Name = "AutoLike_button";
            this.AutoLike_button.Size = new System.Drawing.Size(182, 23);
            this.AutoLike_button.TabIndex = 7;
            this.AutoLike_button.Text = "Авто-лайк";
            this.AutoLike_button.UseVisualStyleBackColor = true;
            this.AutoLike_button.Click += new System.EventHandler(this.AutoLike_button_Click);
            // 
            // autoadd
            // 
            this.autoadd.AutoSize = true;
            this.autoadd.Location = new System.Drawing.Point(25, 418);
            this.autoadd.Name = "autoadd";
            this.autoadd.Size = new System.Drawing.Size(198, 17);
            this.autoadd.TabIndex = 8;
            this.autoadd.Text = "Принимать все запросы в друзья";
            this.autoadd.UseVisualStyleBackColor = true;
            // 
            // find_groups_box
            // 
            this.find_groups_box.Location = new System.Drawing.Point(709, 215);
            this.find_groups_box.Name = "find_groups_box";
            this.find_groups_box.Size = new System.Drawing.Size(191, 20);
            this.find_groups_box.TabIndex = 9;
            this.find_groups_box.Text = "Введите тему";
            // 
            // find_groups_button
            // 
            this.find_groups_button.Location = new System.Drawing.Point(711, 241);
            this.find_groups_button.Name = "find_groups_button";
            this.find_groups_button.Size = new System.Drawing.Size(184, 33);
            this.find_groups_button.TabIndex = 10;
            this.find_groups_button.Text = "Найти соответствия";
            this.find_groups_button.UseVisualStyleBackColor = true;
            // 
            // addFriends_button
            // 
            this.addFriends_button.Location = new System.Drawing.Point(711, 372);
            this.addFriends_button.Name = "addFriends_button";
            this.addFriends_button.Size = new System.Drawing.Size(152, 48);
            this.addFriends_button.TabIndex = 13;
            this.addFriends_button.Text = "Добавление в список";
            this.addFriends_button.UseVisualStyleBackColor = true;
            this.addFriends_button.Click += new System.EventHandler(this.addFriends_Click);
            // 
            // gropssercbaton
            // 
            this.gropssercbaton.Location = new System.Drawing.Point(709, 153);
            this.gropssercbaton.Name = "gropssercbaton";
            this.gropssercbaton.Size = new System.Drawing.Size(182, 33);
            this.gropssercbaton.TabIndex = 14;
            this.gropssercbaton.Text = "поиск груп";
            this.gropssercbaton.UseVisualStyleBackColor = true;
            this.gropssercbaton.Click += new System.EventHandler(this.gropssercbaton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Список запросов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(660, 33);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(250, 250);
            this.webBrowser2.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gropssercbaton);
            this.Controls.Add(this.addFriends_button);
            this.Controls.Add(this.find_groups_button);
            this.Controls.Add(this.find_groups_box);
            this.Controls.Add(this.autoadd);
            this.Controls.Add(this.AutoLike_button);
            this.Controls.Add(this.DogPatulButton);
            this.Controls.Add(this.SpamButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SpamButton;
        private System.Windows.Forms.Button DogPatulButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассылкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискУдаленныхToolStripMenuItem;
        private System.Windows.Forms.Button AutoLike_button;
        private System.Windows.Forms.CheckBox autoadd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox find_groups_box;
        private System.Windows.Forms.Button find_groups_button;
        private System.Windows.Forms.Button addFriends_button;
        private System.Windows.Forms.Button gropssercbaton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button button2;
    }
}

