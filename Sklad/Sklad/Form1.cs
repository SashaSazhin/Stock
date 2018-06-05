using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Form1 : Form
    {
        List<Product> Products;
        DialogResult ok_cancel;
        DialogResult yesno;
        const int temp = 25;
        public Form1()
        {
            InitializeComponent();
            Products = new List<Product>();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ProductName n = new ProductName();
            n.Name = tbName.Text;

            ProductManufacturer m = new ProductManufacturer();
            m.Manuf = tbManf.Text;

            ProductPrice p = new ProductPrice();
            p.Price = tbPrice.Text;

            ProductQuantity q = new ProductQuantity();
            q.Quantity = tbQuantity.Text;

            Stock st = new Stock();
            st.Stocknm = tbStock.Text;

            Lot lt = new Lot();
            lt.Mlot = tbMinLot.Text;


            if (CheckManuf(tbManf.Text.ToString()) && CheckPrice(tbPrice.Text.ToString()) && CheckMinLot(tbMinLot.Text.ToString()))
            {
                if (n.IsCorrect(n.Name) == true && m.IsCorrect(m.Manuf) == true && p.IsCorrect(p.Price) == true && q.IsCorrect(q.Quantity) == true && st.IsCorrect(st.Stocknm) == true && lt.IsCorrect(lt.Mlot) == true) 
                {
                    Products.Add(new Product(tbName.Text, tbManf.Text, tbPrice.Text, tbQuantity.Text, tbStock.Text, tbMinLot.Text));
                    lbStock.Items.Add(Products[Products.Count - 1].ToString() + '\n');
                }
                else
                {
                    MessageBox.Show("Something has gone wrong.Check Price List,Stock List and Min Lot Info");
                }
            }
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tPrice list(hryvnas for 1kg)\n\n" +
                            "Coal:3 - Georgia,5 - China\n" +
                            "Gold:450000 - Mexico,520000 - Brazil\n" +
                            "Nickel:780 - Russia,1200 - Philippines\n" +
                            "Iron:25 - India,65 - Australia\n" +
                            "Aluminium:100 - Canada,Norway");
        }


        private void btnStockInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have access to th next stocks:\n" +
                            "0001,0002,0003,0004,0005,0006");
        }

        private void btnLotInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minimal lot for:\n" +
                            "Coal = 150\n" +
                            "Gold = 25\n" +
                            "Nickel = 50\n" +
                            "Iron = 200\n" +
                            "Aluminium = 100");
        }


        //China,Ukraine = Coal     Brazil,Mexico = Gold   Russia,Philippines - Nickel    India,Australia = Iron  Canada,Norway = Aluminium
        private bool CheckManuf(string manuf)
        {
            bool checkmanuf = false;

            if (tbName.Text == "Coal")
            {
                if (tbManf.Text == "Georgia" || tbManf.Text == "China")
                {
                    checkmanuf = true;
                }
            }
            else if (tbName.Text == "Gold")
            {
                if (tbManf.Text == "Mexico" || tbManf.Text == "Brazil")
                {
                    checkmanuf = true;
                }
            }
            else if (tbName.Text == "Nickel")
            {
                if (tbManf.Text == "Russia" || tbManf.Text == "Philippines")
                {
                    checkmanuf = true;
                }
            }
            else if (tbName.Text == "Iron")
            {
                if (tbManf.Text == "India" || tbManf.Text == "Australia")
                {
                    checkmanuf = true;
                }
            }
            else if (tbName.Text == "Aluminium")
            {
                if (tbManf.Text == "Canada" || tbManf.Text == "Norway")
                {
                    checkmanuf = true;
                }
            }
            else
                MessageBox.Show("This country does not deliver the specified product");

            return checkmanuf;
        }

        private bool CheckPrice(string price)
        {
            bool checkprice = false;

            //Coal Ukraine China
            if (tbManf.Text == "Georgia")
            {
                if (tbPrice.Text == "4")
                {
                    checkprice = true;
                }
            }
            if (tbManf.Text == "China")
            {
                if (tbPrice.Text == "5")
                {
                    checkprice = true;
                }
            }

            //Gold brazil mexico
            if (tbManf.Text == "Mexico")
            {
                if (tbPrice.Text == "450000")
                {
                    checkprice = true;
                }
            }
            if (tbManf.Text == "Brazil")
            {
                if (tbPrice.Text == "520000")
                {
                    checkprice = true;
                }
            }

            //Nickel Russia Philippines
            if (tbManf.Text == "Russia")
            {
                if (tbPrice.Text == "780")
                {
                    checkprice = true;
                }
            }
            if (tbManf.Text == "Philippines")
            {
                if (tbPrice.Text == "1200")
                {
                    checkprice = true;
                }
            }

            //iron india Australia
            if (tbManf.Text == "India")
            {
                if (tbPrice.Text == "25")
                {
                    checkprice = true;
                }
            }
            if (tbManf.Text == "Australia")
            {
                if (tbPrice.Text == "65")
                {
                    checkprice = true;
                }
            }

            //Aluminium Norway Canada
            if (tbManf.Text == "Canada" || tbManf.Text == "Norway")
            {
                if (tbPrice.Text == "100")
                {
                    checkprice = true;
                }
            }
            return checkprice;
        }

        private bool CheckMinLot(string mlot)
        {
            bool checkminlot = false;
            //   if (mlot == "25" || mlot == "50" || mlot == "100"|| mlot == "150" || mlot == "200")
            if (tbName.Text == "Coal")
            {
                if (tbMinLot.Text == "150")
                {
                    checkminlot = true;
                }
            }
            else if (tbName.Text == "Gold")
            {
                if (tbMinLot.Text == "25")
                {
                    checkminlot = true;
                }
            }
            else if (tbName.Text == "Nickel")
            {
                if (tbMinLot.Text == "50")
                {
                    checkminlot = true;
                }
            }
            else if (tbName.Text == "Iron")
            {
                if (tbMinLot.Text == "200")
                {
                    checkminlot = true;
                }
            }
            else if (tbName.Text == "Aluminium")
            {
                if (tbMinLot.Text == "100")
                {
                    checkminlot = true;
                }
            }

            return checkminlot;
        }

        private void lbProductName_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("List of products firm is interested in adding\n" +
                            "to one of its numerous stocks:\n" +
                            "Coal\n" +
                            "Iron\n" +
                            "Gold\n" +
                            "Nickel\n" +
                            "Aluminum");
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsLetter(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }

        }

        private void tbManf_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsLetter(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void lbQuantity_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Not more than 4 digits in the field");
        }

        private void tbStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void tbMinLot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void tbStNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(e.KeyChar) && k != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void btnStDelete_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            bool temp = false;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Stocknm == tbStNum.Text)
                {
                    if (tbStNum.Text == Products[i].Stocknm)
                    {
                        temp = true;
                    }
                }
            }
            if (temp == true)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].Stocknm == tbStNum.Text)
                    {
                        ok_cancel = MessageBox.Show("Products from the entered stock\n" + "are going to be deleted", "DeleteBox", MessageBoxButtons.OKCancel);
                        break;
                    }
                }
                if (ok_cancel == DialogResult.OK && tbPassword.Text == "123456789qwerty")
                {
                    lbStock.Items.Clear();
                    listBox1.Items.Clear();
                    for (int i = 0; i < Products.Count; i++)
                    {
                        if (Products[i].Stocknm == tbStNum.Text)
                        {
                            Products.RemoveAt(i);
                        } 
                        else if (Products[i].Stocknm != tbStNum.Text)
                        {
                            if (tbStNum.Text != Products[i].Stocknm)
                            {
                                lbStock.Items.Add(Products[i].ToString() + '\n');
                                //lbStock.Items.Add(Products[i].ToString());
                            }
                        }
                    }
                }
                else if(tbPassword.Text!="123456789qwerty")
                {
                    MessageBox.Show("You've entered the wrong password");
                }
                tbStNum.Clear();
                tbPassword.Clear();
            }
        }

        private void btnStInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool temp = false;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Stocknm == tbStNum.Text)
                {
                    if (tbStNum.Text == Products[i].Stocknm)
                    {
                        temp = true;
                    }

                }
            }
            if (temp == true)
            {
                for (int i = 0; i < Products.Count; i++) 
                {
                    if (Products[i].Stocknm == tbStNum.Text)
                    {
                        yesno = MessageBox.Show("Wanna see info about products on the entered stock?", "Info Box", MessageBoxButtons.YesNo);
                        break;
                    }
                }
                if (yesno == DialogResult.Yes) 
                {
                    for (int i = 0; i < Products.Count; i++) 
                    {
                        if (Products[i].Stocknm == tbStNum.Text)
                        {
                            listBox1.Items.Add(Products[i].Name + "\t" + Products[i].Quantity);
    
                        }
                    }
                }
            }

            if (tbPassword.Text == "123456")
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(Products[i].Mlot) > 50)
                    {
                        listBox1.Items.Add(Products[i].Name + "\t" + Products[i].Manuf + "\t" + Products[i].Mlot);
                    }

                }
            }
            tbStNum.Clear();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new System.IO.StreamWriter("C:\\название_файла.odt"))
            {
                for (int i = 0; i < lbStock.Items.Count; i++)
                    sw.WriteLine(lbStock.Items[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                lbStock.Items.Clear();
                using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\название_файла.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        lbStock.Items.Add(sr.ReadLine());
                    }
                }
            
        }
    }

}


/*
           private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> paths = new List<string>();
            foreach (string s in lbStock.Items)
            {
                paths.Add(s);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("Лаб.odt",FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, paths);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("MyFile.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream("Лаб.odt", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    List<string> paths = (List<string>)formatter.Deserialize(stream);
                    foreach (string s in paths)
                    {
                        listBox1.Items.Add(s);
                    }
                               this.Load += new System.EventHandler(this.Form1_Load);
                }
            }
        }
        */
