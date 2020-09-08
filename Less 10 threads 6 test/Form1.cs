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

namespace Less_10_threads_6_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

         async  void P()
            {     
                while (i < 100_000_000)
                {

                    progressBar1.Value = i;
                    i++;
                  if (i % 100000 == 0)  await Task.Delay(1);
                }
            }

            P();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0; 
            while (i < 100_000_000)
            {

                progressBar1.Value = i;
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
