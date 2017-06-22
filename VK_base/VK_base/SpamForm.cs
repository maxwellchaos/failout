using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.ObjectModel;

namespace WindowsFormsApplication1
{
    public partial class SpamForm : Form
    {
        public string access_token;

        public string usre_id;
        public string user_id;
        public string group_id;
        public string group_id_2;
        public string message;
        Collection<string> name;
        Collection<string> asd;

        public SpamForm()
        {
            InitializeComponent();
        }

        private void SpamForm_Load(object sender, EventArgs e)
        {

            asd = new Collection<string>();

            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5889617&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends+messages&response_type=token&v=5.37");
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string Url;

            Url = e.Url.ToString();
            if (Url.Contains("access_token"))
            {

                int index = Url.IndexOf("access_token");
                index = index + 13;
                int index1 = Url.IndexOf("&");
                access_token = Url.Substring(index, index1 - index);


            }
            if (Url.Contains("user_id="))
            {
                //string user_id;
                int index_id = Url.IndexOf("user_id=");
                index_id = index_id + 8;
                usre_id = Url.Substring(index_id);

            }
            ///////////////////////////////////////////////////////


            ///////////////////////////////////////////////
           


                    XmlDocument Doc1 = new XmlDocument();
                    Doc1.Load("https://api.vk.com/method/groups.get.xml?user_id=" + usre_id + "&access_token=" + access_token + "&extended=1" + "&v=5.62");
                    foreach (XmlNode level1 in Doc1.SelectNodes("response"))
                    {
                        foreach (XmlNode level2 in level1.SelectNodes("items"))
                        {

                            foreach (XmlNode level3 in level2.SelectNodes("group"))
                            {
                                string[] a = new string[3];


                                //foreach (XmlNode level4 in level3.SelectNodes("name"))
                                //{
                                //     name1 = level4.InnerText;
                                /// }

                                foreach (XmlNode level4 in level3.SelectNodes("name"))
                                {
                                    a[0] = level4.InnerText;
                                }
                                foreach (XmlNode level4 in level3.SelectNodes("photo_100"))
                                {
                                    pictureBox2.Load(level4.InnerText);
                                    a[1] = " " + level4.InnerText;
                                }
                                foreach (XmlNode level5 in level3.SelectNodes("id"))
                                {
                                    a[2] = level5.InnerText;
                                }


                                imageList2.Images.Add(pictureBox2.Image);
                                ListViewItem item = new ListViewItem(a, imageList2.Images.Count - 1);
                                listView3.Items.Add(item);
                                Application.DoEvents();

                            }
                        }
                    }








                }


            
        


        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox2.Text = group_id_2;//listView3.SelectedItems
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox2.Text = group_id_2;
            if (listView3.SelectedItems.Count > 0)
            {

                textBox2.Text = listView3.SelectedItems[0].SubItems[2].Text;
                group_id = textBox2.Text;
            }
        }

       /* private void spambaton2_Click(object sender, EventArgs e)
        {
            group_id = textBox2.Text;
            string urlo = ("https://api.vk.com/method/groups.getMembers.xml?user_id=" + usre_id + "&access_token=" + "&fields=photo_100,first_name,last_name" + access_token + "&group_id=" + group_id_2 + "&v=5.62");
            XmlDocument Doc2 = new XmlDocument();
            Doc2.Load("https://api.vk.com/method/groups.getMembers.xml?user_id=" + usre_id + "&access_token=" + "&fields=photo_100,first_name,last_name" + access_token + "&group_id=" + group_id_2 + "&v=5.62");
            foreach (XmlNode ud in Doc2.SelectNodes("response"))
            {
                foreach (XmlNode ud1 in ud.SelectNodes("items"))
                {
                    foreach (XmlNode ud2 in ud1.SelectNodes("uid"))
                    {
                        user_id = ud2.InnerText;
                        string name12 = "";
                        foreach (XmlNode ud3 in ud2.SelectNodes("first_name"))
                        {
                            label1.Text = ud3.InnerText;
                            name12 = ud3.InnerText;
                        }

                        foreach (XmlNode ud4 in ud2.SelectNodes("last_name"))
                        {
                            label1.Text = label1.Text + " " + ud4.InnerXml;
                            name12 = name12 + "" + ud4.InnerText;
                        }

                        foreach (XmlNode ud5 in ud2.SelectNodes("photo_100"))
                        {
                            // pictureBox1.Load(ud4.InnerText);

                        }

                        listView2.Items.Add(name12, imageList1.Images.Count - 1);
                        imageList1.Images.Add(pictureBox1.Image);


                        webBrowser1.Visible = false;

                    }
                }
            }

        }*/

        private void spambaton3_Click(object sender, EventArgs e)
        {
            XmlDocument Doc7 = new XmlDocument();
            Doc7.Load("https://api.vk.com/method/groups.getMembers.xml?access_token=" + access_token + "&group_id=" + group_id + "&fields=photo_100");
            listView4.Items.Clear();
            foreach (XmlNode ta in Doc7.SelectNodes("response"))
            {
                foreach (XmlNode ta2 in ta.SelectNodes("users"))
                {
                    foreach (XmlNode ta3 in ta2.SelectNodes("user"))
                    {
                        string name2 = "";
                        foreach (XmlNode ta4 in ta3.SelectNodes("first_name"))
                        {
                            label3.Text = ta2.InnerText;
                            name2 = ta4.InnerText;
                            //name.Add(ta4.InnerText);


                        }

                        foreach (XmlNode ta4 in ta3.SelectNodes("last_name"))
                        {
                            label3.Text = label3.Text + " " + ta2.InnerXml;
                            name2 = name2 + "" + ta4.InnerText;
                        }

                        foreach (XmlNode tag5 in ta3.SelectNodes("photo_100"))
                        {
                            //pictureBox3.Load(tag5.InnerText);

                        }
                        foreach (XmlNode tag6 in ta3.SelectNodes("uid"))
                        {
                            //pictureBox3.Load(tag5.InnerText);
                            user_id = tag6.InnerText;
                             asd.Add(user_id);
                            //textBox4.Text = user_id;
                            
                        }
                        //if (pictureBox3.Image == null)
                        //{
                        listView4.Items.Add(name2/*, imageList1.Images.Count - 1*/);
                        //imageList3.Images.Add(pictureBox3.Image);
                        //}
                        Application.DoEvents();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message = textBox3.Text;
           // foreach (string name1 in name)
           // {
                foreach (string i in asd)
                {
                    XmlDocument Doc8 = new XmlDocument();
                    Doc8.Load("https://api.vk.com/method/messages.send.xml?access_token=" + access_token + "&user_id=" + i + "&message="  + message);
                    System.Threading.Thread.Sleep(1000);
                }
          //  }
            Application.DoEvents();

            //XmlDocument Doc8 = new XmlDocument();
            //Doc8.Load("https://api.vk.com/method/messages.get.xml?access_token=" + access_token + "&user_id=147924331" /*+ user_id *//*+ "&message=" + message*/);
            int h = 7;
        }

        private void spam_Click(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
            {
                listView5.Items.Add(listView4.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void spambaton1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument Doc88 = new XmlDocument();
            Doc88.Load("https://api.vk.com/method/groups.getMembers.xml?access_token=" + access_token + "&group_id=" + group_id + "&fields=photo_100");
            listView5.Items.Clear();
            foreach (XmlNode ta in Doc88.SelectNodes("response"))
            {
                foreach (XmlNode ta2 in ta.SelectNodes("users"))
                {
                    foreach (XmlNode ta3 in ta2.SelectNodes("user"))
                    {
                        string name2 = "";
                        foreach (XmlNode ta4 in ta3.SelectNodes("first_name"))
                        {
                            label3.Text = ta2.InnerText;
                            name2 = ta4.InnerText;
                        }

                        foreach (XmlNode ta4 in ta3.SelectNodes("last_name"))
                        {
                            label3.Text = label3.Text + " " + ta2.InnerXml;
                            name2 = name2 + "" + ta4.InnerText;
                        }

                        foreach (XmlNode tag5 in ta3.SelectNodes("photo_100"))
                        {
                            //pictureBox3.Load(tag5.InnerText);

                        }
                        foreach (XmlNode tag6 in ta3.SelectNodes("uid"))
                        {
                            //pictureBox3.Load(tag5.InnerText);
                            user_id = tag6.InnerText;
                            asd.Add(user_id);
                            //textBox4.Text = user_id;

                        }
                        //if (pictureBox3.Image == null)
                        //{
                        listView5.Items.Add(name2/*, imageList1.Images.Count - 1*/);
                        //imageList3.Images.Add(pictureBox3.Image);
                        //}
                        Application.DoEvents();
                    }
                }

            }
        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
                        // private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
                        //{

                        //}


                    
                
           // }
        //}
   // }
//}
