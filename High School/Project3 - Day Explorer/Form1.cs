using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt2
{
    public partial class Form1 : Form
    {
       
        private DateTime Dzisiaj;
        private int NumerDnia;
        string[] DniTygodnia = { "niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota" };
        public Form1()
        {
            InitializeComponent();
            Dzisiaj = DateTime.Now;
            NumerDnia = (int)Dzisiaj.DayOfWeek;
        }

        private void biezacy_Click(object sender, EventArgs e)
        {

            zmiana();
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void poprzedni_Click(object sender, EventArgs e)
        {
            NumerDnia--;
            if (NumerDnia < 0)
            {
                NumerDnia = 6;
            }
            zmiana();



        }

        private void nastepny_Click(object sender, EventArgs e)
        {
            NumerDnia++;
            if (NumerDnia > 6)
            {
                NumerDnia = 0;
            }
            zmiana();

        }

        private void zmiana()
        {

            if (NumerDnia == 0)
            {
                NumerDnia = 6;
                label1.Text = ("wczoraj: ") + DniTygodnia[NumerDnia];
                NumerDnia = 0;
            }
            else
            {
                label1.Text = ("wczoraj: ") + DniTygodnia[NumerDnia - 1];
            }
            label2.Text = ("dzisiaj: ") + DniTygodnia[NumerDnia];
            if (NumerDnia == 6)
            {
                NumerDnia = 0;
                label3.Text = ("jutro: ") + DniTygodnia[NumerDnia];
                NumerDnia = 6;
            }
            else
            {
                label3.Text = ("jutro: ") + DniTygodnia[NumerDnia + 1];
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = label1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
                label2.Font = fontDialog1.Font;
                label2.ForeColor = fontDialog1.Color;
                label3.Font = fontDialog1.Font;
                label3.ForeColor = fontDialog1.Color;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Text = "" + System.DateTime.Now.ToString("yyyy/MM/dd" + " " + "HH:mm:ss");
        }

        private void ZmianaKoloruPierwszoplanowego_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button1.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) ForeColor = colorDialog1.Color;
        }

        private void ZmianaKoloruTla_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button2.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) BackColor = colorDialog1.Color;
        }

        private void ZmianaCzcionki_Click(object sender, EventArgs e)
        {
            {
                fontDialog1.ShowColor = true;
                fontDialog1.Font = label1.Font;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Font = fontDialog1.Font;
                    label1.ForeColor = fontDialog1.Color;
                    label2.Font = fontDialog1.Font;
                    label2.ForeColor = fontDialog1.Color;
                    label3.Font = fontDialog1.Font;
                    label3.ForeColor = fontDialog1.Color;
                }
            }
        }
    }
}
