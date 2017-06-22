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
   
    public partial class Form1 : Form
    {
        public string access_token;

        public string user_id;

        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
                
                webBrowser1.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5114880&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+wall&response_type=token&v=5.37");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       /* private void SpamButton_Click(object sender, EventArgs e)
        {
            SpamForm frm = new SpamForm();
            frm.access_token = access_token;
            frm.usre_id = user_id;
            frm.ShowDialog();
        }*/

        

        

        private void addFriends_Click(object sender, EventArgs e)
        {

        }

        /*private void gropssercbaton_Click(object sender, EventArgs e)
        {
            Gropsserc serc = new Gropsserc();
            serc.ShowDialog();
        }*/

        

        private void Pirat_button_Click(object sender, EventArgs e)
        {

        }


        private void рассылкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpamForm frm = new SpamForm();
            frm.access_token = access_token;
            frm.usre_id = user_id;
}

        private void AutoLike_button_Click(object sender, EventArgs e)
        {
            AutoLike_form frm = new AutoLike_form();
            frm.access_token = access_token;
            frm.user_id = user_id;

            frm.ShowDialog();
        }

        private void поискУдаленныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DogPatrulForm frm = new DogPatrulForm();
            frm.ShowDialog();

        }

        private void поискГруппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gropsserc serc = new Gropsserc();
            serc.ShowDialog();
        }

        private void автолайкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoLike_form frm = new AutoLike_form();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Добыываем путь, где искать кукиз 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies); //Собитраем все файлы кукиз
            string[] cookies = System.IO.Directory.GetFiles(path); //Удаляем все найденные файлы кукиз
            foreach (string cookie in cookies) { try { System.IO.File.Delete(cookie); } catch (Exception e1) { } } //Перезапуск приложения
            Application.Restart();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Spisok_freands ttg = new Spisok_freands();
            ttg.access_token = access_token;
            ttg.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Добыываем путь, где искать кукиз 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies); //Собитраем все файлы кукиз 
            string[] cookies = System.IO.Directory.GetFiles(path); //Удаляем все найденные файлы кукиз 
            foreach (string cookie in cookies) 
            {
                try { System.IO.File.Delete(cookie); } catch (Exception e1) { } 
            } 
            Application.Restart();
        }

    }
}
