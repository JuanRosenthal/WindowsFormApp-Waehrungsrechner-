using System;
using System.Windows.Forms;

namespace Währungsrechner_Formapp
{
    public partial class Form1 : Form
    {

        double b = 1.15; // Kurs Euro zu Dollar
        double c = 0.87; //Kurs Dollar zu Euro
       
        
        

        public Form1()
        {
            InitializeComponent();

        }
        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                double umrechnung1 = d * b;
                MessageBox.Show("Dein Betrag in Dollar ist: " + umrechnung1);
            }
            catch (Exception error)
            {
                MessageBox.Show("Nur Zahlen eingeben!\nErrornachricht: " + error.Message);
                
                textBox1.Clear();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                double umrechnung2 = d * c;
                MessageBox.Show("Dein Betrag in Euro ist: " + umrechnung2);
            }
            catch (Exception error)
            {
                MessageBox.Show("Nur Zahlen eingeben!\nErrornachricht: " + error.Message);

                textBox1.Clear();

            }
        }

        

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Umrechnungskurs ist nicht Live und er hat keine Verbindung zu einem API! er hat den Stand vom 23.10.2018 ");
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Währungsrechner wurde von Juan Rosenthal programmiert");
        }


        
    }
}
