using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Core;

namespace PasswordSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = textBox1.Text.ToString();

            var numbers = new List<string>();

            textBox1.Clear();

            foreach (char c in test)
            {
                numbers.Add(LetterToNumberDictionary.GetWheelNumber(c.ToString()).ToString());
            }

            textBox1.AppendText(numbers);
        }
    }
}
