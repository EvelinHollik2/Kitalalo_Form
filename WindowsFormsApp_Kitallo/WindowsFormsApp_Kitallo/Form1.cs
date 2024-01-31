using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_Kitallo
{
    public partial class Form1 : Form
    {
        string[] data = File.ReadAllLines("szavak.txt");
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxkitalalo_TextChanged(object sender, EventArgs e)
        {

           int pos1 = rnd.Next(data.Length);
           int pos2 = rnd.Next(data.Length);
           int pos3 = rnd.Next(data.Length);
           int pos4 = rnd.Next(data.Length);
           
           string word = data[];
           
           word = word.Remove(pos1, 1).Insert(pos1, ".");
           word = word.Remove(pos2, 1).Insert(pos2, ".");
           word = word.Remove(pos3, 1).Insert(pos3, ".");
           word = word.Remove(pos3, 1).Insert(pos4, ".");

        }

        private void buttonTip_Click(object sender, EventArgs e)
        {
            listBoxTip.Items.Add($"{textBoxTip}");
        }

        private void textBoxTip_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTip == textBoxkitalalo)
            {
                MessageBox.Show("Helyes megoldás");
            }
        }
    }
}
