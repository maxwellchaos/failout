using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class friends : Form
    {
        
        decimal strok;
        public string access_token;
        public string user_id;
        public string message_id;
        public string message;
        public string like;
        public string friend;
        public string title;
        public string bdate;
        public string sex;
        public friends()
          
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
            toolStripTextBox3.Text = listView1.SelectedItems[0].SubItems[1].Text;
            toolStripTextBox4.Text = listView1.SelectedItems[0].SubItems[2].Text;
            toolStripTextBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            toolStripTextBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            pictureBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
             
           

            pictureBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;

            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
             
        
        private void friends_Load(object sender, EventArgs e)
        {
            textBox2.Text = Properties.Settings.Default.Text;
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5114880&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+messages&response_type=token&v=5.37");
            timer1.Start();
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void рассылкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string request = "https://api.vk.com/method/friends.get.xml?user_id=" + user_id + "&fields=photo_100&access_token " + access_token + "&v=5.62";
            doc.Load(request);
            if (doc.InnerXml.Contains("error"))
            {
                MessageBox.Show("Ошибка получения данных о пользователе!");
            }
            listView1.Items.Clear();

            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {
                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("user"))
                    {

                        string[] a = new string[5];

                        foreach (XmlNode level4 in level3.SelectNodes("first_name"))
                        {
                            a[0] = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("last_name"))
                        {
                            a[1] = level4.InnerXml;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("id"))
                        {
                            a[2] = level4.InnerXml;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("photo_100"))
                        {
                            a[4] = level4.InnerXml;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("photo_100"))
                        {
                            a[3] = level4.InnerXml;
                            pictureBox4.Load(level4.InnerText);
                        }
                        imageList1.Images.Add(pictureBox4.Image);

                        ListViewItem item = new ListViewItem(a, imageList1.Images.Count - 1);
                        listView1.Items.Add(item);
                        Application.DoEvents();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поискУдаленныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            XmlDocument doc = new XmlDocument();
            string request = "https://api.vk.com/method/messages.get.xml?fields=photo_100&access_token=" + access_token + "&v=5.62";
            doc.Load(request);
            if (doc.InnerXml.Contains("error"))
            {
                MessageBox.Show("Ошибка получения данных о пользователе!");
            }
            listView1.Items.Clear();
            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {
                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("message"))
                    {

                        string[] a = new string[4];
                        string user_id;
                        foreach (XmlNode level4 in level3.SelectNodes("user_id"))
                        {
                            user_id = level4.InnerText;
                            message = textBox2.Text;
                            XmlDocument Doc8 = new XmlDocument();
                           Doc8.Load("https://api.vk.com/method/messages.send.xml?access_token=" + access_token + "&user_id=" + level4.InnerText + "&message=" + message);
                           

                            textBox1.Text = textBox1.Text + level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("read_state"))
                        {
                            if (level4.InnerText == "0")
                            {      
                                message = textBox2.Text;
                                XmlDocument Doc8 = new XmlDocument();
                                Doc8.Load("https://api.vk.com/method/messages.send.xml?access_token=" + access_token + "&user_id=" + level4.InnerText + "&message=" + message);
                            }
                        }
                        {
                            textBox2.Text = textBox2.Text +"\r\n" ;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("body"))
                        {
                            textBox1.Text = textBox1.Text + level4.InnerXml;
                        }
                        {
                            textBox1.Text = textBox1.Text + "\r\n";
                        }

                        ListViewItem item = new ListViewItem(a, imageList1.Images.Count - 1);
                        listView1.Items.Add(item);

                        Application.DoEvents();

                    }
                }
            }
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            message = textBox3.Text;
            XmlDocument Doc8 = new XmlDocument();
            Doc8.Load("https://api.vk.com/method/messages.send.xml?access_token=" + access_token + "&user_id=" + toolStripTextBox4.Text + "&message=" + message);
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = e.Url.ToString();
            if (url.Contains("access_token"))
            {

                int index = url.IndexOf("access_token=");
                int index2 = url.IndexOf("&expires_in");
                access_token = url.Substring(index + 13, index2 - index - 13);
                index = url.IndexOf("user_id=");
                user_id = url.Substring(index + 8);
                XmlDocument doc = new XmlDocument();
                string request = "https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + access_token + "&v=5.62";
                doc.Load(request);
                if (doc.InnerXml.Contains("error"))
                {
                    MessageBox.Show("Ошибка получения данных о пользователе!");
                }
                foreach (XmlNode level1 in doc.SelectNodes("response"))
                {
                    foreach (XmlNode level2 in level1.SelectNodes("user"))
                    {
                        foreach (XmlNode level3 in level2.SelectNodes("first_name"))
                        {
                            label1.Text = level3.InnerText;
                        }
                        foreach (XmlNode level3 in level2.SelectNodes("last_name"))
                        {
                            label2.Text = level3.InnerText;
                        }
                        foreach (XmlNode level3 in level2.SelectNodes("id"))
                        {
                            textBox5.Text = level3.InnerText;
                        }
                        foreach (XmlNode level3 in level2.SelectNodes("photo_100"))
                        {
                            pictureBox3.ImageLocation = level3.InnerText;
                        }
                        
                    }
                }
                webBrowser1.Visible = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void friends_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Text = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            friend = textBox3.Text;
            XmlDocument Doc8 = new XmlDocument();
            Doc8.Load("https://api.vk.com/method/friends.add.xml?access_token=" + access_token + "&user_id=" + toolStripTextBox4.Text + "&friends" + friend);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            friend = textBox3.Text;
            XmlDocument Doc8 = new XmlDocument();
            Doc8.Load("https://api.vk.com/method/friends.delete.xml?access_token=" + access_token + "&user_id=" + toolStripTextBox4.Text + "&friends" + friend);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            friend = textBox3.Text;
            XmlDocument Doc8 = new XmlDocument();
            Doc8.Load("https://api.vk.com/method/account.banUser.xml?access_token=" + access_token + "&user_id=" + toolStripTextBox4.Text + "&friends" + friend);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            friend = textBox3.Text;
            XmlDocument Doc8 = new XmlDocument();
            Doc8.Load("https://api.vk.com/method/account.unbanUser.xml?access_token=" + access_token + "&user_id=" + textBox6.Text + "&friends" + friend);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void помощьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string request = "https://api.vk.com/method/account.getBanned.xml?user_id=" + user_id + "&fields=photo_100&access_token " + access_token + "&v=5.62";
            doc.Load(request);
            if (doc.InnerXml.Contains("error"))
            {
                MessageBox.Show("Ошибка получения данных о пользователе!");
            }
            listView1.Items.Clear();

            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {
                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("user"))
                    {

                        string[] a = new string[4];

                        foreach (XmlNode level4 in level3.SelectNodes("first_name"))
                        {
                            a[0] = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("last_name"))
                        {
                            a[1] = level4.InnerXml;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("id"))
                        {
                            a[2] = level4.InnerXml;
                        }


                        foreach (XmlNode level4 in level3.SelectNodes("photo_100"))
                        {
                            a[3] = level4.InnerXml;
                            pictureBox2.Load(level4.InnerText);

                        }
                        imageList1.Images.Add(pictureBox2.Image);

                        ListViewItem item = new ListViewItem(a, imageList1.Images.Count - 1);
                        listView1.Items.Add(item);

                        Application.DoEvents();

                    }
                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
        }
    }

