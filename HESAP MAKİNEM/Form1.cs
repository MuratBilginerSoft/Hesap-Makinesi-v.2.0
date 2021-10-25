using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAP_MAKİNEM
{
    public partial class Form1 : Form
    {

        #region Metodlar

        #region Toplam

        double toplam()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 + s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s2 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 + s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

        }

        #endregion

        #region Çıkarma

        double cıkarma()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 - s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s2 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 - s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

        }
        #endregion

        #region Çarpma

        double carpma()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s2 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 * s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

        }

        #endregion

        #region Bölme

        double bolme()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s2 = double.Parse(textBox1.Text);
                textBox1.Clear();
                sn = s1 / s2;
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

        }

        #endregion

        #region Üs Alma

        double usal()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s1 = double.Parse(textBox1.Text);
                sn = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s2 = double.Parse(textBox1.Text);
                textBox1.Clear();
                for (int i = 0; i < s2 - 1; i++)
                {
                    sn *= s1;
                }


                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }
        }

        #endregion

        #region KareKök Alma

        double kare()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + "√";

                s1 = double.Parse(textBox1.Text);
                sn = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text;

                sn = Math.Sqrt(s1);


                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }
        }
        #endregion

        #region Ters Alma

        double ters()
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + "r";

                s1 = double.Parse(textBox1.Text);
                sn = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }

            else
            {
                textBox2.Text = textBox2.Text;

                sn = 1 / s1;


                textBox3.Text = sn.ToString();
                sn = double.Parse(textBox3.Text);
                s1 = sn;

                return s1;
            }
        }
        #endregion

        #region Mod

        int mod()
        {


            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + s5;

                s7 = int.Parse(textBox1.Text);
                textBox1.Clear();

                textBox3.Text = s7.ToString();
                s9 = int.Parse(textBox3.Text);
                s7 = s9;


                return s7;
            }

            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + s5;
                s8 = int.Parse(textBox1.Text);
                textBox1.Clear();
                s9 = s7 % s8;
                textBox3.Text = s9.ToString();
                s9 = int.Parse(textBox3.Text);
                s7 = s9;

                return s7;
            }
        }

        #endregion

        #region Değer 1

        char deger()
        {

            int s9 = 0;
            char[] d = new char[100];

            foreach (char h in textBox1.Text)
            {
                d[s9] = h;
                s9++;
            }
            return d[0];
        }

        #endregion

        #region  Değer 2

        char deger1()
        {

            int s9 = 0;
            char[] d = new char[textBox1.Text.Length];

            foreach (char h in textBox1.Text)
            {
                d[s9] = h;
                s9++;
            }



            return d[textBox1.Text.Length];
        }

        #endregion

        #region Nesne Erişim Engelle

        public void NesneErişimEngelle()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button25.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            menuStrip1.Enabled = false;
        
        }
        #endregion

        #region Mod 2 Nesne Gizleme

        public void mod2nesnegizle()
        {
            button21.Visible = false;
            button22.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        #endregion

        #region Nesneleri Erişime İzin Ver

        public void Nesneleriaç()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;

            button25.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox2.Enabled = true;
            menuStrip1.Enabled = true;
        
        }

        #endregion

        #region  Temizlik

        public void Temizlik()

        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            s5 = "";
            s1 = 0; s2 = 0; sn = 0;
        }

        #endregion

        #region Hesaplama

        public void hesaplama(string d)
        {
            if (textBox1.Text == "" && textBox2.Text != "")
            {
                string x = textBox2.Text;
                x = x.Remove(x.Length - 1, 1);
                textBox2.Text = x + d;
                s5 = d;
            }

            else if (textBox1.Text == "" && textBox2.Text == "")
            { }
            else
            {

                #region Seçim

                switch (d)
                {
                    case "+":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                toplam();
                            }
                            break;
                        }

                    case "-":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                cıkarma();
                            }
                            break;
                        }

                    case "*":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                carpma();
                            }
                            break;
                        }

                    case "/":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                bolme();
                            }
                            break;
                        }

                    case "^":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                usal();
                            }
                            break;
                        }

                    case "√":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                kare();
                            }
                            break;
                        }

                    case "r":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                ters();
                            }
                            break;
                        }

                    case "%":
                        {
                            if (s5 == "" || s5 == d)
                            {
                                s5 = d;
                                mod();
                            }
                            break;
                        }

                }
                #endregion

                #region İşlem

                if (s5 == "-" && s5 != d)
                {
                    s5 = d;
                    cıkarma();

                }

                if (s5 == "+" && s5 != d)
                {
                    s5 = d;
                    toplam();

                }

                if (s5 == "*" && s5 != d)
                {
                    s5 = d;
                    carpma();

                }

                if (s5 == "/" && s5 != d)
                {
                    s5 = d;
                    bolme();

                }

                if (s5 == "^" && s5 != d)
                {
                    s5 = d;
                    usal();
                }
                if (s5 == "√" && s5 != d)
                {
                    s5 = d;
                    kare();

                }
                if (s5 == "r" && s5 != d)
                {
                    s5 = d;
                    ters();
                }
                if (s5 == "%" && s5 != d)
                {
                    s5 = d;
                    mod();
                }

                #endregion
            }
        }

        #endregion

        #region Eşittir 

        public void Eşittir(string r)
        {
            if (s5 == "" || s5 == "+")
            {
                s5 = r;
                toplam();

                textBox1.Text = "=" + s1;

            }

            else if (s5 == "" || s5 == "-")
            {
                s5 = r;
                cıkarma();
                textBox1.Text = "=" + s1;
            }

            else if (s5 == "" || s5 == "*")
            {
                s5 = r;
                carpma();
                textBox1.Text = "=" + s1;
            }

            else if (s5 == "" || s5 == "/")
            {
                s5 = r;
                bolme();
                textBox1.Text = "=" + s1;

            }
            else if (s5 == "" || s5 == "^")
            {
                s5 = r;
                usal();
                textBox1.Text = "=" + s1;

            }

            else if (s5 == "" || s5 == "√")
            {
                s5 = r;
                kare();
                textBox1.Text = "=" + s1;

            }

            else if (s5 == "" || s5 == "r")
            {
                s5 = r;
                ters();
                textBox1.Text = "=" + s1;

            }
            else if (s5 == "" || s5 == "%")
            {
                s5 = r;
                mod();
                textBox1.Text = "=" + s7;

            }
        
        }

        #endregion

        #region Form VE Nesne Boyutu

        public void ilkboyut()
        {
            textBox1.Size = new Size(300,33);
            textBox2.Size = new Size(174, 33);
            comboBox1.Size = new Size(300,75);
            this.Size = new Size(352,650);
            button19.Size = new Size(75, 75);
            button20.Size = new Size(75, 75);
            button25.Size = new Size(75, 75);
            button19.Location = new Point(92,199);
            button20.Location = new Point(167, 199);
            button25.Location = new Point(242, 199);
            button21.Visible = false;
            button22.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        
        }

        public void ikinciboyut()
        {
            textBox1.Size = new Size(381, 33);
            textBox2.Size = new Size(255, 33);
            comboBox1.Size = new Size(381, 75);
            this.Size = new Size(428, 650);
            button19.Size = new Size(102,75);
            button20.Size = new Size(102, 75);
            button25.Size = new Size(102, 75);
            button19.Location = new Point(92, 199);
            button20.Location = new Point(194, 199);
            button25.Location = new Point(296, 199);
            button21.Visible = true;
            button22.Visible = true;
            button17.Visible = true;
            button18.Visible = true;

        }
        #endregion

        #endregion

        #region Değişkenler

        int s7 = 0, s8 = 0, s9 = 0;
        int xx = 0;

        double s1 = 0, s2 = 0, sn = 0;

        string s5 = "";

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            ilkboyut();
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            s5 = "";

            NesneErişimEngelle();

            mod2nesnegizle();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "0";
            }

            else
            {

                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "0";
                }
                else

                    textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (xx == 0)
            {
                Nesneleriaç();
                xx++;
                textBox1.Focus();
            }
            else
            {
             DialogResult f=   MessageBox.Show("Hesap Makinesini Kapatmak İstiyormusunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

             if (f == DialogResult.Yes) this.Close();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "1";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "1";
                }
                else

                    textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "2";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "2";
                }
                else

                    textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "3";
            }


            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "3";
                }
                else

                    textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "4";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "4";
                }
                else

                    textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "5";
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "5";
                }
                else

                    textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "6";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "6";
                }
                else

                    textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "7";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "7";
                }
                else

                    textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "8";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "8";

                }
                else

                    textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                Temizlik();
                textBox1.Text = "9";
            }

            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = "9";
                }
                else

                    textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hesaplama("/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hesaplama("*");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hesaplama("-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hesaplama("+");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hesaplama("^");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hesaplama("√");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hesaplama("r");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hesaplama("%");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // EŞİTTİR BUTONU

            if (textBox1.Text == "" && textBox2.Text != "")
            {
                char t = 'a';

                foreach (char g in textBox2.Text)
                {
                    t = g;
                }

                if (t == '√')
                {
                    sn = Math.Sqrt(s1);
                    textBox1.Text = "=" + sn;
                }
                else if (t == 'r')

                {
                    sn = 1 / s1;
                    textBox1.Text = "=" + sn;
                }

                else
                    textBox1.Text = "=" + textBox3.Text;
            }
            else
            {
                Eşittir("=");

            }
        }

        private void mod2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ikinciboyut();
        }

        private void mod1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilkboyut();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Hesap Makinesini Kapatmak İstiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (f == DialogResult.Yes) this.Close();
        }

        private void toplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("+");
        }

        private void çıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("-");
        }

        private void çarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("*");
        }

        private void bölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("/");
        }

        private void üsAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("^");
        }

        private void çarpmayaGöreTersiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("r");
        }

        private void karekökAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("√");
        }

        private void kalanBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesaplama("%");  
        }

        private void button19_Click(object sender, EventArgs e)
        {
            s5 = "";
            textBox1.Text = "0";
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            s1 = 0; s2 = 0; sn = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (deger() != '=')
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0" + ",";
                else
                    textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                s5 = "";
                s1 = 0; s2 = 0; sn = 0;
                textBox1.Text ="0";
            }
            else
            {
                if (textBox1.Text == "")
                    textBox1.Text = "";
                else
                {
                    string x;
                    x = textBox1.Text;
                    x = x.Remove(x.Length - 1, 1);
                    textBox1.Text = x;
                }
            }
        }

        private void eşittirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text != "")
            {
                char t = 'a';

                foreach (char g in textBox2.Text)
                {
                    t = g;
                }

                if (t == '√')
                {
                    sn = Math.Sqrt(s1);
                    textBox1.Text = "=" + sn;
                }
                else if (t == 'r')
                {
                    sn = 1 / s1;
                    textBox1.Text = "=" + sn;
                }

                else
                    textBox1.Text = "=" + textBox3.Text;
            }
            else
            {
                Eşittir("=");

            }
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deger() == '=')
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                s5 = "";
                s1 = 0; s2 = 0; sn = 0;
                textBox1.Text = comboBox1.Text;
            }
            else
            
            textBox1.Text = comboBox1.Text;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = this.BackColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog1.Color != this.BackColor)
            {
                this.BackColor = colorDialog1.Color;
                comboBox1.BackColor = colorDialog1.Color;
                menuStrip1.BackColor = colorDialog1.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://muratbilginerncfkr.blogspot.com.tr/");
        }

        private void orijinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.MenuHighlight;
            comboBox1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.BackColor = SystemColors.MenuHighlight;
        }
    }
}
