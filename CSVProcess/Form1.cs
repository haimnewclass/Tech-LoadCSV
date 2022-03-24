using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace CSVProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mng mng = new Mng();
            mng.Run();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Mng mng = new Mng();
            mng.Run();
            int n = mng.GetNumerOfTimesThat4ExistedInFirstNumer();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mng mng = new Mng();
            mng.Run();
            byte digit = byte.Parse(textBox1.Text);
            int n = mng.GetNumerOfTimesThatExistedInFirstNumer(digit);
            label1.Text = n.ToString();
        }
    }
}
