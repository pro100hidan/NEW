using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_PROGET
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

        private void CALL_Click(object sender, EventArgs e)
        {
            //TextBox
            //OpenFileDialog(ShowDialog);
            this.Close();
        }

        private void OpenFileDialog(Func<DialogResult> showDialog)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
