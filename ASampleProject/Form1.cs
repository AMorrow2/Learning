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

namespace ASampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader file;
            string line;
            try
            {
                file = new System.IO.StreamReader("names.txt");
            }
            catch
            {
                MessageBox.Show("Unable to open file: names.txt");
                return;
            }
            int counter = 0;
            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
            }
            catch
            {
                MessageBox.Show("Error encountered reading data from file");
                return;
            }
            Console.WriteLine("Read {0} names from the file", counter);
        }
    }
}
