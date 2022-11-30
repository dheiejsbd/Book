using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using MyHash;

namespace Book
{
    public partial class Form1 : Form
    {
        public static string FilePath = "C:\\test.csv";
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += (object sneder, KeyEventArgs e) => { if (e.KeyCode != Keys.Enter) return; SerchButton_Click(sneder, e); };
            LoadData();
        }
        MyHash.SimpleHashTable hashTable = new SimpleHashTable();
        private void SerchButton_Click(object sender, EventArgs e)
        {
            var l = serch(textBox1.Text);
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (var item in l)
            {
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
            if(l.Count == 0) MessageBox.Show($"{textBox1.Text}에 대한 검색결과가 없습니다.","NotFound",  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        List<ListViewItem> serch(string serchName, int serchCount = 10, bool resetImage = true)
        {
            var returnValue = new List<ListViewItem>();
            string url = $"https://openapi.naver.com/v1/search/book.xml?query={serchName}&display={serchCount}";
            string responseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("X-Naver-Client-Id", "********_***********");
            request.Headers.Add("X-Naver-Client-Secret", "**********");

            using (WebResponse response = request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                responseText = reader.ReadToEnd();
            }

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(responseText);
            XmlNodeList nodes = xml.GetElementsByTagName("item");
            if(resetImage)imageList1.Images.Clear();
            int i = 0;
            foreach (XmlNode xnl in nodes)
            {
                ListViewItem listViewItem = new ListViewItem("");
                listViewItem.SubItems.Add(xnl["title"].InnerText);
                listViewItem.SubItems.Add(xnl["author"].InnerText);
                listViewItem.SubItems.Add(xnl["publisher"].InnerText);
                listViewItem.SubItems.Add(xnl["isbn"].InnerText);
                listViewItem.SubItems.Add(xnl["pubdate"].InnerText);
                listViewItem.SubItems.Add(hashTable.Contains(xnl["isbn"].InnerText)? "O":"X");
                listViewItem.ImageIndex = (resetImage)? i : imageList1.Images.Count;

                using (WebClient client = new WebClient())
                {
                    byte[] imgArray;
                    imgArray = client.DownloadData(xnl["image"].InnerText);

                    using (MemoryStream memstr = new MemoryStream(imgArray))
                    {
                        Image img = Image.FromStream(memstr);

                            imageList1.Images.Add(img);
                    }
                }

                returnValue.Add(listViewItem);
                i++;
            }
            return returnValue;
        }


        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        void LoadData()
        {
            if(!new FileInfo(FilePath).Exists) return;
            StreamReader SR = new StreamReader(FilePath);
            string result = "";
            result = SR.ReadToEnd();
            SR.Close();

            string[] vs = result.Split('\n');
            for (int i = 0; i < vs.Length; i++)
            {
                var lsbn = vs[i].Split(',');
                foreach (var item in lsbn)
                {
                    hashTable.Put(item);
                }
            }
        }
        void SaveData()
        {
            StreamWriter writer_;
            writer_ = File.CreateText(FilePath);
            writer_.Write(hashTable.ToString());
            writer_.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void AddData(int ID)
        {
            hashTable.Put(listView1.Items[ID].SubItems[4].Text);
            listView1.Items[ID].SubItems[6].Text = "O";
        }
        void RemoveData(int ID)
        {
            hashTable.Out(listView1.Items[ID].SubItems[4].Text);
            listView1.Items[ID].SubItems[6].Text = "X";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                AddData(item.Index);
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                RemoveData(item.Index);
            }
        }

        private void HasButton_Click(object sender, EventArgs e)
        {
            var items = hashTable.GetAllItem();
                listView1.BeginUpdate();
                listView1.Items.Clear();
            imageList1.Images.Clear();
            foreach (var item in items)
            {
                var list = serch(item,1,false);

                listView1.Items.Add(list[0]);
            }
                listView1.EndUpdate();
        }
    }
}
