using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double result = 0;
        double results = 0;
        double celsius = 0;
        double results1 = 0;
        double fare = 0;
        double kelvin = 0;
        string operation1 = "";
        string operation = "";
        string ioperation = "";
        bool enter_value = false;
        bool enter_value1 = false;
        public Form1()
        {
            InitializeComponent();
        }






        public void Colorhover()
        {
            Butoncolor color = new Butoncolor();
            Butonothercolor color1 = new Butonothercolor();
            button5.MouseHover += delegate
            {
                button5.BackColor = color.color2();
            };
            button6.MouseHover += delegate
            {
                button6.BackColor = color.color2();
            };

            button7.MouseHover += delegate
            {
                button7.BackColor = color.color2();
            };
            button9.MouseHover += delegate
            {
                button9.BackColor = color.color2();
            };

            button11.MouseHover += delegate
            {
                button11.BackColor = color.color2();
            };
            button10.MouseHover += delegate
            {
                button10.BackColor = color.color2();
            };

            button14.MouseHover += delegate
            {
                button14.BackColor = color.color2();
            };
            button15.MouseHover += delegate
            {
                button15.BackColor = color.color2();
            };

            button19.MouseHover += delegate
            {
                button19.BackColor = color.color2();
            };
            button20.MouseHover += delegate
            {
                button20.BackColor = color.color2();
            };
            button16.MouseHover += delegate
            {
                button16.BackColor = color.color2();
            };
            button1.MouseHover += delegate
             {
                 button1.BackColor = color.color4();
             };
            button18.MouseHover += delegate
            {
                button18.BackColor = color.color4();
            };
            button2.MouseHover += delegate
            {
                button2.BackColor = color.color3();
            };
            button3.MouseHover += delegate
            {
                button3.BackColor = color.color3();
            };
            button13.MouseHover += delegate
            {
                button13.BackColor = color1.color4();
            };
            button12.MouseHover += delegate
            {
                button12.BackColor = color1.color4();
            };
            button4.MouseHover += delegate
            {
                button4.BackColor = color1.color4();
            };
            button8.MouseHover += delegate
            {
                button8.BackColor = color1.color4();
            };
            button17.MouseHover += delegate
            {
                button17.BackColor = color1.color4();
            };


        }




        public void Colorchange()
        {
            Butoncolor color = new Butoncolor();
            Butonothercolor color1 = new Butonothercolor();
            Acces colortext = new Acces();
            button5.BackColor = color.color1();
            button6.BackColor = color.color1();
            button7.BackColor = color.color1();
            button9.BackColor = color.color1();
            button10.BackColor = color.color1();
            button11.BackColor = color.color1();
            button19.BackColor = color.color1();
            button14.BackColor = color.color1();
            button15.BackColor = color.color1();
            button16.BackColor = color.color1();
            button17.BackColor = color1.color3();
            button20.BackColor = color.color1();
            button18.BackColor = color1.color1();
            button1.BackColor = color1.color1();
            button2.BackColor = color1.color2();
            button3.BackColor = color1.color2();
            button8.BackColor = color1.color3();
            button12.BackColor = color1.color3();
            button13.BackColor = color1.color3();
            button4.BackColor = color1.color3();
            button8.ForeColor = colortext.color();
            button12.ForeColor = colortext.color();
            button13.ForeColor = colortext.color();
            button17.ForeColor = colortext.color();
        }




        private void button1_MouseHover(object sender, EventArgs e)
        {
            Colorhover();
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {

            Colorchange();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            open();
            Colorchange();
            panel1.Visible = false;
            this.Width = 287;
            textBox1.Height = 30;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarimeaFerestrei marimea = new MarimeaFerestrei();
            marimea.Width = 285;
            this.Width = marimea.Width;
            this.Height = 507;
            textBox1.Height = 30;
            listBox1.Width = 246;
            textBox1.Width = 246;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarimeaFerestrei marimea = new MarimeaFerestrei();
            marimea.Width = 412;
            this.Height = 634;
            this.Width = marimea.Width;
            // textBox1.Height =;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            listBox1.Width = 380;
            textBox1.Width = 380;
        }

        private void buton_click(object sender, EventArgs e)
        {
            Acces space = new Acces();
            if ((textBox1.Text == "0") || enter_value) textBox1.Text = space.Space();
            enter_value = false;
            // listBox1.Items.Add(textBox1.Text);
            Button num = (Button)sender;
            if (num.Text == ",")
            { if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else textBox1.Text = textBox1.Text + num.Text;
            //listBox1.Items.Add(textBox1.Text);        
        }
        private void buton_clicks(object sender, EventArgs e)
        {
            Acces space = new Acces();
            if ((textBox2.Text == "0") || enter_value1) textBox2.Text = space.Space();
            enter_value1 = false;
            // listBox1.Items.Add(textBox1.Text);
            Button num = (Button)sender;
            if (num.Text == ",")
            {
                if (!textBox2.Text.Contains(","))
                    textBox2.Text = textBox2.Text + num.Text;
            }
            else textBox2.Text = textBox2.Text + num.Text;
            //listBox1.Items.Add(textBox1.Text);        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void artimetic_operation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;

            results = float.Parse(textBox1.Text.ToString());
            enter_value = true;


        }
        private void button18_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    listBox1.Items.Add(results + " + " + textBox1.Text + "=");
                    listBox1.Items.Add(results + double.Parse(textBox1.Text));
                    results += double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(results);
                    save();
                    break;
                case "-":
                    {
                        listBox1.Items.Add(results + " - " + textBox1.Text + "=");
                        listBox1.Items.Add(results - double.Parse(textBox1.Text));
                        results -= double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(results);
                        save();
                    }


                    break;
                case "*":
                    listBox1.Items.Add(results + " * " + textBox1.Text + "=");
                    listBox1.Items.Add(results * double.Parse(textBox1.Text));
                    results *= double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(results);
                    save();
                    break;
                case "/":
                    listBox1.Items.Add(results + " / " + textBox1.Text + "=");
                    listBox1.Items.Add(results / double.Parse(textBox1.Text));
                    results /= double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(results);
                    save();
                    break;

            }



        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double chk = Convert.ToDouble(this.textBox1.Text);
                chk = -chk;
                textBox1.Text = chk.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem.ToString().Contains("="))
            {
                int i = listBox1.SelectedIndex;
                textBox1.Text = listBox1.Items[i + 1].ToString();
            }
            else textBox1.Text = listBox1.SelectedItem.ToString();

        }
        public void save()
        {
            string sPath = "file2.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }
        public void open() {
            try
            {
                try
                {
                    string[] file = System.IO.File.ReadAllLines("file2.txt");
                    foreach (string line in file)
                    {
                        listBox1.Items.Add(line);
                        listBox2.Items.Add(line);
                    }

                }
                catch { }
            }
            catch { }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 & textBox2.Text != "0")
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }
        private void artimetic_operations(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation1 = num.Text;

            results1 = float.Parse(textBox2.Text.ToString());
            enter_value1 = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void save1()
        {
            string sPath = "file2.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox2.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }

      public string RemoveBrackets(string text)
        {
            while(text.Contains('(')&& text.Contains(')'))
            {
                int openindex = 0;
                int closeindex = 0;
                for(int i=0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        openindex = i;
                    }
                    if (text[i] == ')')
                    {
                        closeindex = i;
                text = text.Remove(openindex, closeindex - openindex + 1).Insert(openindex, Resolve(openindex, closeindex, text));
                        break;
                    }
                }
            }return Calculate(text);
        }

        private string Resolve(int openindex, int closeindex, string text)
        {
            string answer = Calculate(text.Substring(openindex + 1, closeindex - openindex - 1));
            return answer;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
          textBox2.Text=RemoveBrackets(textBox2.Text);
          
        }
        private string Calculate(string text)
        {
            double final = substract(text);
          return final.ToString();
            
        }
        public double substract(string expression)
        {
            
            

                        string[] expressions = expression.Split('+');
                        if (expressions.Length > 1)
                        {
                            result = 0;
                            foreach (string expr in expressions)
                                result += substract(expr);
                            return result;
                        }
                        expressions = expression.Split('-');
                        if (expressions.Length > 1)
                        {
                            result = substract(expressions[0]);
                            for (int i = 1; i < expressions.Length; i++)
                                result -= Convert.ToDouble(substract(expressions[i]));
                            return result;
                        }
                        expressions = expression.Split('*');
                        if (expressions.Length > 1)
                        {
                            result = 1;
                            foreach (string expr in expressions)
                                result *= substract(expr);
                            return result;
                        }
                        expressions = expression.Split('/');
                        if (expressions.Length > 1)
                        {
                            result = substract(expressions[0]);
                            for (int i = 1; i < expressions.Length; i++)
                                result /= substract(expressions[i]);
                            return result;
                        }
           
            if (!double.TryParse(expression, out result))
                            throw new ArgumentException("Expression was not nummeric", "expression");
                    
           
                  return result;
        }
        private void button51_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3,453453454654434354689";
        }

        private void button44_Click(object sender, EventArgs e)
        {   textBox1.Text =textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Log10(ilog);
            textBox2.Text= Convert.ToString(ilog);
            listBox2.Items.Add(" Log( " + textBox1.Text +")"+ "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Sqrt(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Sqrt( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Cos(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Cos( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Sin(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Sin( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Tan(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Tan( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Sinh(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Sinh( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Tanh(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Tanh( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Log10(ilog);
            textBox2.Text = Convert.ToString(ilog);
            listBox2.Items.Add(" Cot( " + textBox1.Text + ")" + "=");
            listBox2.Items.Add(textBox2.Text);
            results1 = double.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(results1);
            save1();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox2.Text);
            ilog = Math.Acos(ilog);
            textBox2.Text = Convert.ToString(ilog);
            save1();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem.ToString().Contains("="))
            {
                int i = listBox2.SelectedIndex;
                textBox2.Text = listBox2.Items[i + 1].ToString();
            }
            else textBox2.Text = listBox2.SelectedItem.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "C";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "F";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = "K";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            switch (ioperation)
            {
                case "C":
                    celsius = float.Parse(textBox3.Text);
                    textBox4.Text = ((((9 * celsius) / 5) + 32).ToString());
                    break;
                case "F":

                    fare = float.Parse(textBox3.Text);
                    textBox4.Text = ((((9 * fare) - 32) /9).ToString());

                    break;
                case "K":
                    kelvin = float.Parse(textBox3.Text);
                    textBox4.Text = ((((9 * kelvin)/5) + 273.15).ToString());
                    break;
               
            }

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarimeaFerestrei marimea = new MarimeaFerestrei();
            marimea.Width = 412;
            this.Height = 634;
            this.Width = marimea.Width;
            // textBox1.Height =;
            panel1.Visible = false;
            panel3.Visible = false;
         
          
        }

        private void temperatureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MarimeaFerestrei marimea = new MarimeaFerestrei();
            marimea.Width = 412;
            this.Height = 634;
            this.Width = marimea.Width;
            // textBox1.Height =;
            panel3.Visible = true;
           
           


        }

        private void button66_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test executat cu succes!!!");
        }
    }
}