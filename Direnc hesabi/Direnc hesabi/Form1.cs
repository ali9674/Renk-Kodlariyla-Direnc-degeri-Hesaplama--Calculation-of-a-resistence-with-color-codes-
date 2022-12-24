using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Direnc_hesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox4.Checked = true;
            label51.Hide();
            label55.Hide();
            label17.Hide();
            label77.Hide(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Renk(comboBox1, button3); Renk(comboBox2, button4); Renk(comboBox3, button5); Renk(comboBox4, button6);
            yazdir(comboBox1, label5); yazdir(comboBox2, label6); yazdir(comboBox3, label7); yazdir(comboBox4, label8);
            //TAB PAGE 2

            Renk(comboBox5, button10); Renk(comboBox6, button11); Renk(comboBox7, button12); Renk(comboBox8, button13); Renk(comboBox9, button14);
            yazdir(comboBox5, label47); yazdir(comboBox6, label48); yazdir(comboBox7, label50); yazdir(comboBox8, label49); yazdir(comboBox9, label45);








         //   if (label16.Text == "NULL") label17.Hide();
          //  else label17.Show();


        }

        public void Renk(ComboBox a, Button b)
        {
            if (a.Text == "Siyah" || a.Text == "Black") b.BackColor = Color.Black;
            else if (a.Text == "Kahverengi" || a.Text == "Brown") b.BackColor = Color.Brown;
            else if (a.Text == "Kırmızı" || a.Text == "Red") b.BackColor = Color.Red;
            else if (a.Text == "Turuncu" || a.Text == "Orange") b.BackColor = Color.Orange;
            else if (a.Text == "Sarı" || a.Text == "Yellow") b.BackColor = Color.Yellow;
            else if (a.Text == "Yeşil" || a.Text == "Green") b.BackColor = Color.Green;
            else if (a.Text == "Mavi" || a.Text == "Blue") b.BackColor = Color.Blue;
            else if (a.Text == "Mor" || a.Text == "Purple") b.BackColor = Color.Purple;
            else if (a.Text == "Gri" || a.Text == "Grey") b.BackColor = Color.Gray;
            else if (a.Text == "Beyaz" || a.Text == "White") b.BackColor = Color.White;
            else if (a.Text == "Altın" || a.Text == "Gold") b.BackColor = Color.Gold;
            else if (a.Text == "Gümüş" || a.Text == "Silver") b.BackColor = Color.DarkGray;
            else if (a.Text == "BOS" || a.Text == "" || a.Text == "NULL") b.BackColor = Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        public void yazdir(ComboBox a, Label b)
        {
            if (a.Text == "Siyah" || a.Text == "Black") b.Text = "0";
            else if (a.Text == "Kahverengi" || a.Text == "Brown") b.Text = "1";
            else if (a.Text == "Kırmızı" || a.Text =="Red") b.Text = "2";
            else if (a.Text == "Turuncu"||a.Text=="Orange") b.Text = "3";
            else if (a.Text == "Sarı" || a.Text =="Yellow") b.Text = "4";
            else if (a.Text == "Yeşil" || a.Text=="Green") b.Text = "5";
            else if (a.Text == "Mavi" || a.Text =="Blue") b.Text = "6";
            else if (a.Text == "Mor" || a.Text =="Purple") b.Text = "7";
            else if (a.Text == "Gri"||a.Text=="Grey") b.Text = "8";
            else if (a.Text == "Beyaz" || a.Text =="White") b.Text = "9";
            else if (a.Text == "Altın"||a.Text=="Gold") b.Text = "5";
            else if (a.Text == "Gümüş"||a.Text=="Silver") b.Text = "10";
            else if (a.Text==null||a.Text=="") b.Text = "";




        }



        private void button7_Click(object sender, EventArgs e)
        {
            try
            {


                decimal tolerans, sayi, multiplier; //çarpan
                string tutucu;
                tutucu = label5.Text + label6.Text;

                sayi = Convert.ToInt16(tutucu);
                multiplier = (int)Math.Pow(10, Convert.ToInt16(label7.Text));
                label12.Text = Convert.ToString(sayi * multiplier);
                tolerans = Convert.ToInt16(label8.Text);
                Decimal gecici_ust = (multiplier * sayi) + ((multiplier * sayi) * tolerans) / 100;
                             
                Decimal gecici_alt = (multiplier * sayi) - ((multiplier * sayi) * tolerans) / 100;

                label16.Text = Convert.ToString((double)gecici_alt) + "-" + Convert.ToString((double)gecici_ust);

                timer2.Start();


                label17.Location = new Point(700 + Convert.ToInt16(label12.Text.Length * 2), 210);
                label17.Show();
                label77.Location = new Point(680 +Convert.ToInt16(label16.Text.Length*6) , 241);
                label77.Show();
                //DİĞERİNE YARIN YAP
               
            }
            catch
            {
                //Boş girdiler için hata vermemesi için... !!
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            decimal anasayi = Convert.ToDecimal(label12.Text);


            label24.Text = Convert.ToString(anasayi * 1000000000); label25.Text = Convert.ToString(anasayi * 1000000);
            label26.Text = Convert.ToString(anasayi * 1000); label27.Text = Convert.ToString(anasayi * ((decimal)1 / 1000));
            label28.Text = Convert.ToString(anasayi * ((decimal)1 / 1000000)); label29.Text = Convert.ToString(anasayi * ((decimal)1 / 1000000000));





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dilfonk(label1, "1 st Tape");
            dilfonk(label2, "2 nd Tape");
            dilfonk(label3, "3 rd Tape");
            dilfonk(label4, "4 th Tape");
            dilfonk(label14, "Resistance");
            dilfonk(label15, "Tolerance Range");
            button7.Text = "Calculate";
            groupBox1.Text = "Preview"; //ön izleme
            groupBox3.Text = "Auto Convert";
            tabPage1.Text = "4 Tapes";
            tabPage2.Text = "5 Tapes";
            checkBox1.Checked = false;
            checkBox2.Checked = true;


            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
           
            comboBox4.Items.Clear();  //  Tolerans  comboboxı  için düzenleme
            comboBox4.Items.Add("Gold");
            comboBox4.Items.Add("Silver");

            En_language_convert(comboBox1);
            En_language_convert(comboBox2);
            En_language_convert(comboBox3);
  


        }
        public void dilfonk(Label lab, string s)  //diilleri ayarlar
        {
            lab.Text = s;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dilfonk(label1, "1.Bant");
            dilfonk(label2, "2.Bant");
            dilfonk(label3, "3.Bant");
            dilfonk(label4, "4.Bant");
            dilfonk(label14, "Direnç");
            dilfonk(label15, "Tolerans Aralığı");
            button7.Text = "Hesapla";
            groupBox1.Text = "Önizleme"; //ön izleme
            groupBox3.Text = "Dönüşüm";
            tabPage1.Text = "4 Bantlı";
            tabPage2.Text = "5 Bantlı ";

            checkBox1.Checked = true;
            checkBox2.Checked = false;

            Tr_language_convert(comboBox1); //COMBOBOX İŞLEMLERİ
            Tr_language_convert(comboBox2);
            Tr_language_convert(comboBox3);
          
            comboBox4.Items.Clear();  //  
            comboBox4.Items.Add("Altın");
            comboBox4.Items.Add("Gümüş");  // Tolerans comboboxı

            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         
            
                }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {


                decimal tolerans, sayi, multiplier; //çarpan
                string tutucu;
                tutucu = label47.Text + label48.Text + label50.Text;
                sayi = Convert.ToDecimal(tutucu);
                multiplier = (decimal)Math.Pow(10, Convert.ToInt16(label49.Text));
                label56.Text = Convert.ToString(sayi * multiplier);
                tolerans = Convert.ToInt16(label45.Text);
                Decimal gecici_ust = (multiplier * sayi) + ((multiplier * sayi) * tolerans) / 100;
                Decimal gecici_alt = (multiplier * sayi) - ((multiplier * sayi) * tolerans) / 100;

                label52.Text = Convert.ToString(gecici_alt) + " - " + Convert.ToString(gecici_ust);
                convert3.Start();

                label55.Location = new Point(700 + Convert.ToInt16(label56.Text.Length * 2), 210);
                label55.Show();
                label51.Location = new Point(680 + Convert.ToInt16(label52.Text.Length * 6), 241);
                label51.Show();
            }
            catch
            {
                //Boş girdi hatası için !!
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dilfonk(label38, "1.Bant");
            dilfonk(label40, "2.Bant");
            dilfonk(label41, "3.Bant");
            dilfonk(label39, "4.Bant");
            dilfonk(label42, "5.Bant");
            dilfonk(label54, "Direnç");
            dilfonk(label53, "Tolerans Aralığı");
            button15.Text = "Hesapla";
            groupBox2.Text = "Önizleme"; //ön izleme
            groupBox4.Text = "Dönüşüm";
            tabPage1.Text = "4 Bantlı";
            tabPage2.Text = "5 Bantlı";
            checkBox3.Checked = false;
            checkBox4.Checked = true;

            Tr_language_convert(comboBox6);
            Tr_language_convert(comboBox5);
            Tr_language_convert(comboBox7);
            Tr_language_convert(comboBox8);
            comboBox9.Items.Clear();  //  
            comboBox9.Items.Add("Altın");
            comboBox9.Items.Add("Gümüş");
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox8.Text = null;
            comboBox9.Text = null;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dilfonk(label38, "1 st Tape");
            dilfonk(label40, "2 nd Tape");
            dilfonk(label41, "3 rd Tape");
            dilfonk(label39, "4 th Tape");
            dilfonk(label42, "5 th Tape");
            dilfonk(label54, "Resistance");
            dilfonk(label53, "Tolerance range ");
            button15.Text = "Calculate";
            groupBox2.Text = "Preview"; //ön izleme
            groupBox4.Text = "Convert";
            tabPage1.Text = "4 Tapes";
            tabPage2.Text = "5 Tapes";
            checkBox3.Checked = true;
            checkBox4.Checked = false;

            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox8.Text = null;
            comboBox9.Text = null;
            comboBox9.Items.Clear();  //  Tolerans  comboboxı  için düzenleme
            comboBox9.Items.Add("Gold");
            comboBox9.Items.Add("Silver");

            En_language_convert(comboBox5);
       En_language_convert(comboBox6);
       En_language_convert(comboBox7);
       En_language_convert(comboBox8);

        }

        private void convert3_Tick(object sender, EventArgs e)
        {
            decimal anasayi2 = Convert.ToDecimal(label56.Text);

            label68.Text = Convert.ToString(anasayi2 * 1000000000); label67.Text = Convert.ToString(anasayi2 * 1000000);
            label66.Text = Convert.ToString(anasayi2 * 1000); label65.Text = Convert.ToString(anasayi2 * ((decimal)1 / 1000));
            label64.Text = Convert.ToString(anasayi2 * ((decimal)1 / 1000000)); label63.Text = Convert.ToString(anasayi2 * ((decimal)1 / 1000000000));
        }

      
        void label_Delete(Label[] lab)
        {
            for (int i = 0; i < lab.Length; i++)
                lab[i].Text = "NULL";
            timer2.Stop();
        }

      
        public void Tr_language_convert(ComboBox a)
        {
            String[] karakter = { "Siyah", "Kahverengi", "Turuncu", "Sarı", "Yeşil", "Mavi", "Mor", "Gri", "Beyaz" };

            a.Items.Clear();
            a.Items.AddRange(karakter);
        }
        public void En_language_convert(ComboBox a)
        {
            String[] karakter = { "Black", "Brown", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey", "White" };

            a.Items.Clear();
            a.Items.AddRange(karakter);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Label[] a = new Label[8] { label12, label16, label24, label25, label26, label27, label28, label29 };

            comboBox1.Text = null; comboBox2.Text = null; comboBox3.Text = null; comboBox4.Text = null;
            label5.Text = ""; label6.Text = ""; label7.Text = ""; label8.Text = "";
            label_Delete(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Label[] a = new Label[8] { label56, label52, label63, label64, label65, label66, label67, label68 };

            comboBox5.Text = null; comboBox6.Text = null; comboBox7.Text = null; comboBox8.Text = null; comboBox9.Text = "";
            label5.Text = ""; label6.Text = ""; label7.Text = ""; label8.Text = "";
            label_Delete(a);
            convert3.Stop();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            button16_Click(sender, e);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            button17_Click(sender, e);
        }
    }
}
