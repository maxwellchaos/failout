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
    public partial class AutoLike_form : Form
    {
        public string user_id;
        public string access_token;
        public AutoLike_form()
        {
            InitializeComponent();
        }

        private void AutoLike_form_Load(object sender, EventArgs e)
        {
             webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5896620&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.62");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = e.Url.ToString();
            if (url.Contains("access_token"))
            {
                int IndexA = url.IndexOf("access_token");
                IndexA = IndexA + 13;
                int index1 = url.IndexOf("&");
                string acsess_token = url.Substring(IndexA, index1 - IndexA);
                int IndexB = url.IndexOf("user_id");
                IndexB = IndexB + 8;
                string user_id = url.Substring(IndexB);
                XmlDocument Doc = new XmlDocument();
                string request = "https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + acsess_token + "&v=5,62";
                Doc.Load(request);
                if (Doc.InnerXml.Contains("error"))
                {
                    MessageBox.Show("Ошибка получения данных о пользователе");
                }
                foreach (XmlNode tag in Doc.SelectNodes("response"))
                {
                    foreach (XmlNode tag1 in tag.SelectNodes("user"))
                    {
                        foreach (XmlNode tag2 in tag1.SelectNodes("first_name"))
                        {
                            name.Text = tag2.InnerXml;
                        }
                        foreach (XmlNode tag2 in tag1.SelectNodes("last_name"))
                        {
                            surname.Text = tag2.InnerXml;
                        }
                        foreach (XmlNode tag2 in tag1.SelectNodes("photo_100"))
                        {
                            avatar.ImageLocation = tag2.InnerText;
                        }
                    }
                }
                string request2 = "https://api.vk.com/method/friends.get.xml?user_id=" + user_id + "&fields=photo_100&access_token" + access_token +"&v=5.62";
                Doc.Load(request2);
                if (Doc.InnerXml.Contains("error"))
                {
                    MessageBox.Show("Error 404");
                }
                Friend_list.Items.Clear();
                foreach (XmlNode tag in Doc.SelectNodes("response"))
                {
                    foreach (XmlNode tag1 in tag.SelectNodes("items"))
                    {
                        foreach (XmlNode tag2 in tag1.SelectNodes("user"))
                        {
                            string name = "";
                            foreach (XmlNode tag3 in tag2.SelectNodes("first_name"))
                            {
                                name = tag3.InnerText;
                            }
                            foreach (XmlNode tag3 in tag2.SelectNodes("last_name"))
                            {
                                name = name + " " + tag3.InnerText;
                            }
                            foreach (XmlNode tag3 in tag2.SelectNodes("photo_100"))
                            {
                                //Friend_list.Text = Friend_list.Text + tag3.InnerText;
                            }
                            Friend_list.Items.Add(name);
                        }
                    }
                }
                webBrowser1.Visible = false;

            }


        }
        }
    }

