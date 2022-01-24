using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validation
{
    public partial class Form1 : Form
    {
        public string FirstName // ФАмилия
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }
        public string MidleName // Имя
        {
            get { return maskedTextBox2.Text; }
            set { maskedTextBox2.Text = value; }
        }

        public string LastName // Очество
        {
            get { return maskedTextBox3.Text; }
            set { maskedTextBox3.Text = value; }
        }
        public string Date // Дата рождения
        {
            get { return maskedTextBox4.Text; }
            set { maskedTextBox4.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            maskedTextBox1.Clear();
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            maskedTextBox2.Clear();
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            maskedTextBox3.Clear();
        }

        private void maskedTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            maskedTextBox4.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = maskedTextBox1.Text + "\n" + maskedTextBox2 + "\n" + maskedTextBox3 + "\n" + maskedTextBox4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text ="Ваши данные: \n" + maskedTextBox1.Text + "\n";
            richTextBox1.Text = maskedTextBox2 + "\n";
            richTextBox1.Text = maskedTextBox3 + "\n" + maskedTextBox4;
        }
    }
}
