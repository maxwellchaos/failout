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
    public partial class Spisok_freands : Form
    {
        public string name;
        public string fam;
        public string id;
        public string access_token;
        public Spisok_freands()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Kogodobavili forma = new Kogodobavili();
            XmlDocument doc = new XmlDocument();
            string ttg = "https://api.vk.com/method/friends.getRequests.xml?&access_token=" + access_token + "&v=5.62";
            doc.Load(ttg);
            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {

                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("user_id"))
                    {
                        id = level3.InnerText;
                        XmlDocument doc11 = new XmlDocument();
                        string ttg11 = "https://api.vk.com/method/users.get.xml?&user_ids=" + id + "&v=5.62";
                        doc11.Load(ttg11);
                        foreach (XmlNode level11 in doc11.SelectNodes("response"))
                        {
                            foreach (XmlNode level22 in level11.SelectNodes("user"))
                            {
                                foreach (XmlNode level33 in level22.SelectNodes("first_name"))
                                {
                                    name = level33.InnerText;
                                    
                                }
                                foreach (XmlNode level44 in level22.SelectNodes("last_name"))
                                {
                                    name = name + level44.InnerText;
                                }
                                forma.listView1.Items.Add(name);
                            }
                        }

                                listView1.Items.Add(id);
                            XmlDocument doc1 = new XmlDocument();
                            string ttg1 = "https://api.vk.com/method/friends.add.xml?&access_token=" + access_token + "&user_id=" + id + "&v=5.62";
                            doc1.Load(ttg1);
                        
                    }


                }

                
            }
              forma.ShowDialog();
                this.Close();
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

