using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Calculatrice_Form
{
    public partial class Calculatrice : Form
    {
        double calcul, tempcalcul;
        bool plus, moins, fois, divide;
        bool virgule = false;

        public Calculatrice()
        {
            InitializeComponent();
        }
        private void bouton7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bouton8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bouton9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bouton4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bouton5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bouton6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bouton0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void soustraction_Click(object sender, EventArgs e)
        {
            less();
        }

        private void multiplier_Click(object sender, EventArgs e)
        {
            multiply();
        }

        private void diviser_Click(object sender, EventArgs e)
        {
            ditvide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }


        private void keycontrol(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                textBox1.Text += 0;
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                textBox1.Text += 1;
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                textBox1.Text += 2;
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                textBox1.Text += 3;
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                textBox1.Text += 4;
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                textBox1.Text += 5;
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                textBox1.Text += 6;
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                textBox1.Text += 7;
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                textBox1.Text += 8;
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                textBox1.Text += 9;
     
            if (e.KeyCode == Keys.Decimal || e.KeyValue == 188)
                comma();
            // RESULT
            if (e.KeyCode == Keys.Space)
                result();
            // MULTIPLY
            if (e.KeyCode == Keys.Multiply || e.KeyValue == 220)
                multiply();
            //DIVIDE
            if (e.KeyCode == Keys.Divide || e.KeyValue == 192)
                ditvide();
            //PLUS
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                add();
            //MOINS
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                less();
            if(e.KeyCode == Keys.Escape || e.KeyValue == 67 )
                clean();
            if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                delete();
            
        }

        private void boutonvirgule_Click(object sender, EventArgs e)
        {
            comma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void addition_Click(object sender, EventArgs e)
        {
            add();

        }

        private void resultat_Click(object sender, EventArgs e)
        {
            result();  
        }

        private void result()
        {
            virgule = false;

            if (plus == true)
            {
                calcul += Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(calcul);
                textBox2.Text = "";
                tempcalcul = calcul;
                calcul = 0;
                plus = false;
            }
            else if (moins == true)
            {
                calcul -= Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(calcul);
                textBox2.Text = "";
                tempcalcul = calcul;
                calcul = 0;
                moins = false;
            }
            else if (fois == true)
            {
                calcul *= Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(calcul);
                textBox2.Text = "";
                calcul = 0;
                fois = false;
            }
            else if (divide == true)
            {
                calcul /= Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(calcul);
                textBox2.Text = "";
                tempcalcul = calcul;
                calcul = 0;
                divide = false;
            }
            else
            {
                try
                {
                    calcul = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(calcul);
                }
                catch { }
            }
        }
        private void add()
        {
            try
            {
                calcul = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                plus = true;
            }
            catch (FormatException) { }
        }
        private void less()
        {
            try
            {
                if (moins == false)
                {
                    calcul = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    virgule = false;
                    moins = true;
                }
            }
            catch (FormatException) { }
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Il faut cliquer sur la touche CLAVIER, puis utiliser le clavier \n\n Egal ------------------------- \"Barre d'espace\" \n Diviser ---------------------- \"%\" or \"/\" \n Addition ------------------- \"+\" or \"=\" \n Soustraction -------------- \"-\" \n Multiplication ------------ \"*\" \n Supprimer ----------------- \"Backspace\" \n Nettoyer ------------------- \"Escape\" or \"c\" \n Virgule --------------------- \".\" or \",\" ", "Utilisation Clavier");
        }

        private void ditvide()
        {
            try
            {
                calcul = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                divide = true;
            }
            catch (FormatException) { }
        }

        private void multiply()
        {
            try
            {
                if (fois == false)
                {
                    calcul = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    virgule = false;
                    fois = true;
                }
            }
            catch (FormatException) { }
        }
        private void clean()
        {
            virgule = false;
            fois = false;
            plus = false;
            moins = false;
            divide = false;
            textBox1.Clear();
            textBox2.Clear();
        }
        private void delete()
        {
            try
            {
                int lastc = textBox1.Text.Length;
                textBox1.Text = textBox1.Text.Substring(0, lastc - 1);
                virgule = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = "";
                    virgule = false;
                    fois = false;
                    divide = false;
                    plus = false;
                    moins = false;
                }
                catch (FormatException) { }
            }
        }
        private void comma()
        {
            if (virgule == false)
            {
                if (textBox1.TextLength == 0)
                    textBox1.Text += "0,";
                else
                    textBox1.Text += ",";
                virgule = true;
            }
        }

    }
}
