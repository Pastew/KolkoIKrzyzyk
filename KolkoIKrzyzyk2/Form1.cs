using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIKrzyzyk2
{
    public partial class Form1 : Form
    {
        //zmienne ktore tu są, będą widoczne we wszystkich metodach w tej klasie
        private bool czyj_ruch = true; //true to X, false to Y

        public Form1()
        {
            InitializeComponent();
        }

        private void WstawZnak(object przycisk)
        {
            Button wcisnietyPrzycisk = (Button)przycisk;
            // sender to obiekt,który został wciśnięty, musimy go zrzutować
            // na typ Button(przycisk), aby mozna było ustawić mu znak i ew. wyłączyć

            if (czyj_ruch == true)
            {
                wcisnietyPrzycisk.Text = "X";
            }
            else
            {
                wcisnietyPrzycisk.Text = "O";
            }

            wcisnietyPrzycisk.Enabled = false;

            bool wynik = SprawdzCzyKtosWygral();
            if (wynik == true)
            {
                string tekstWygranej;
                if (czyj_ruch == true)
                {
                    tekstWygranej = "Wygrał Gracz X! Rozpocząć jeszcze raz?";
                }
                else
                {
                    tekstWygranej = "Wygrał Gracz O! Rozpocząć jeszcze raz?";
                }

                //Sprawdzamy, czy gracze chcą kontynuować czy nie
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana", MessageBoxButtons.YesNo);

                if (odpowiedz == DialogResult.No)
                {
                    WylaczWszystkiePrzyciski();
                }
                else
                {
                    WlaczWszystkiePrzyciskiIResetuj();
                }
            }

            czyj_ruch = !czyj_ruch; //zmieniamy z true na false lub z false na true,

            //zmieniemay aktualnego gracza
            if (czyj_ruch == true)
            {
                txtRuch.Text = "X";
            }
            else
            {
                txtRuch.Text = "O";
            }

        }
        private void WlaczWszystkiePrzyciskiIResetuj()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        private void WylaczWszystkiePrzyciski()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        private bool SprawdzCzyKtosWygral()
        {
            //Winning Condition For First Row   
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
            //wystarczy sprawdzić tylko jeden, czy nie jest pusty
            {
                return true;
            }
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
            {
                return true;
            }
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
            {
                return true;
            }
            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
            {
                return true;
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
            {
                return true;
            }
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
            {
                return true;
            }
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
            {
                return true;
            }
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
