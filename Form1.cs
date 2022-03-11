﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Ahoj 5já jsem 1 matěj12";
            int cifSoucet;
            int cifSoucetLich;
            int cifSoucetSud;
            if (Pocitani.obsahujeCislici(s, out cifSoucet, out cifSoucetLich, out cifSoucetSud)) MessageBox.Show("Obsahuje číslici\nCif Sou. je: " + cifSoucet + "\nCif. Sou. Lich. je: " + cifSoucetLich + "\nCif. Sou. Sud.: " + cifSoucetSud);
            else MessageBox.Show("Neobsahuje číslo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "Ahoj 5já jsem 1 matěj12";
            string novyretezec = "";
            MessageBox.Show("Počet slov je: " + Pocitani.PocetSlov1(s, out novyretezec) + "\nŘetězec bez číslic: " + novyretezec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string nejdelsi = "";
            string nejkratsi = "";
            if (Pocitani.ObsahujeSlovo(s, out nejdelsi, out nejkratsi)) MessageBox.Show("Text obsahuje slovo\nNejdelší slovo je: " + nejdelsi + "\nNejkratší slovo je: " + nejkratsi);
            else MessageBox.Show("Žádná slova");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pocVel;
            int pocMal;
            int pocJin;
            string s = "Ahoj 5já jsem 1 matěj12";
            if (Pocitani.JeAlfanum(s, out pocMal, out pocVel, out pocJin)) MessageBox.Show("Řetězec je alfanum\nPoc mal:" + pocMal + "\nPoc vel:" + pocVel + "\nPoc jin:" + pocJin);
            else MessageBox.Show("Řetězec není alfanumerický\nPoc mal:" + pocMal + "\nPoc vel:" + pocVel + "\nPoc jin:" + pocJin);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string s1 = "Ahoj 5já jsem 1 matěj12";
            string s2 = "Ahoj";
            int odlisPoz = 0;
            int prvniIndex = 0;
            if (Pocitani.Identicke(s1, s2, out odlisPoz, out prvniIndex)) MessageBox.Show("Řetězce jsou identické");
            else MessageBox.Show("Řetězce nejsou identické\nPočet odlišností: " + odlisPoz + "\nPrvní index odlišnosti: " + prvniIndex);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "Ahoj5jájsem 1matěj12";
            string novyretezec = "";
            MessageBox.Show("Počet slov je: " + Pocitani.PocetSlov1(s, out novyretezec) + "\nŘetězec bez číslic: " + novyretezec);

        }
    }
}
