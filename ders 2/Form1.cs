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

namespace ders_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void arama_Click(object sender, EventArgs e)
        {
            StreamReader  read  = new StreamReader("C:\\Users\\ceng10\\Downloads\\ürünler.txt");
            string okunan = read.ReadLine();
            string urunkodu = null;
            
            while (!read.EndOfStream)
            {
                okunan = read.ReadLine();
                string[] satir = okunan.Split('-');
                if (satir[1]==textBox1.Text)
                {
                    urunkodu= satir[0]; 
                }
            }
            StreamReader satis = new StreamReader("C:\\Users\\ceng10\\Downloads\\adet.txt");
            string okunan1 = read.ReadLine();
            string [] liste= new string[1];
            int i = 0;
            while (!satis.EndOfStream)
            {
                okunan1 = satis.ReadLine();
                string[] satir = okunan1.Split('-');
                if (satir[1] == urunkodu)
                {
                    liste [i]=satir[2] + " " + satir[4];
                    i++;
                    Array.Resize(ref liste,liste.Length+1);
                }
                for (int j = 0; j < liste.Length-1; j++)
                {
                  listBox1.Items.Add(liste[j]);
                }
            }

           



        }
    }
}
