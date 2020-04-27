using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolacja_Newtona
{
    public partial class Form1 : Form
    {
        List<Punkt> punkty = new List<Punkt>();
        bool pierwszaInterpolacja = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void dodajPunkt_BTN_Click(object sender, EventArgs e)
        {
            



            /*float x = float.Parse(x_TB.Text);
            float y = float.Parse(y_TB.Text);

            listBox1.Items.Add(x.ToString());
            listBox2.Items.Add(y.ToString());
            punkty.Add(new Punkt(x, y));
            x_TB.Clear();
            y_TB.Clear();*/
        }

        private void oblicz_BTN_Click(object sender, EventArgs e)
        {
            string punktyStr = punkty_TB.Text;
            string[] punktySplit = punktyStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < punktySplit.Length; i += 2)
            {
                punkty.Add(new Punkt(float.Parse(punktySplit[i]), float.Parse(punktySplit[i + 1])));
            }


            pierwszaInterpolacja = true;
            double roznica = punkty[1].Y - punkty[0].Y;
            for (int i = 1; i < punkty.Count; i++)
            {
                if (punkty[i].Y-punkty[i-1].Y != roznica)
                {
                    pierwszaInterpolacja = false;
                    break;
                }
            }

            if (pierwszaInterpolacja == true)
            {
                wynik_TB.Text = interpolacjaPierwsza().ToString();
            }
            else
            {
                wynik_TB.Text = interpolacjaDruga().ToString();
            }
        }

        public double interpolacjaPierwsza() //rownoodglegle
        {
            double h = punkty[1].X - punkty[0].X;
            double W_x;
            double[][] roznice=new double[punkty.Count - 1][];

            for (int i = 0, j=roznice.Length; i < roznice.Length; i++, j--)
            {
                roznice[i] = new double[j];
            }

            for (int i = 0; i < roznice[0].Length; i++)
            {
                roznice[0][i] = punkty[i + 1].Y - punkty[i].Y;
            }

            for (int i = 1; i < roznice.Length; i++)
            {
                for (int j = 0; j < roznice[i].Length; j++)
                {
                    roznice[i][j] = roznice[i - 1][j + 1] - roznice[i - 1][j];
                }
            }

            W_x = punkty[0].Y;
            Wzor_TB.Text = W_x.ToString() + " + ";
            for (int i = 0; i < punkty.Count; i++)
            {
                double pom= roznice[i][0] / h;
                Wzor_TB.Text += pom.ToString();
                for (int j = 0; j <= i; j++)
                {
                    pom *= (double.Parse(X_TB.Text) - punkty[j].X);
                    Wzor_TB.Text += "(x - " + punkty[j].X + ")";
                }
                Wzor_TB.Text += " + ";
                W_x += pom;
            }


            return W_x;

        }

        public double interpolacjaDruga() //nierownoodlegle
        {
            double h = punkty[1].X - punkty[0].X;
            double W_x;
            double[][] roznice = new double[punkty.Count - 1][];

            for (int i = 0, j = roznice.Length; i < roznice.Length; i++, j--)
            {
                roznice[i] = new double[j];
            }

            for (int i = 0; i < roznice[0].Length; i++)
            {
                roznice[0][i] = (punkty[i + 1].Y - punkty[i].Y) / (punkty[i+1].X-punkty[i].X);
            }

            for (int i = 1; i < roznice.Length; i++)
            {
                for (int j = 0; j < roznice[i].Length; j++)
                {
                    roznice[i][j] = (roznice[i - 1][j + 1] - roznice[i - 1][j]) / (punkty[j+i+1].X - punkty[j].X);
                }
            }

            W_x = punkty[0].Y;
            Wzor_TB.Text = W_x.ToString() + " + ";
            for (int i = 0; i < punkty.Count-1; i++)
            {
                double pom = roznice[i][0];
                Wzor_TB.Text += pom.ToString();
                for (int j = 0; j <= i; j++)
                {
                    pom *= (double.Parse(X_TB.Text) - punkty[j].X);
                    Wzor_TB.Text += "(x - " + punkty[j].X + ")";
                }
                Wzor_TB.Text += " + ";
                W_x += pom;
            }


            return W_x;
        }

        private static int silnia(int i)
        {
            if (i <= 1)
                return 1;
            else
                return i * silnia(i - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
