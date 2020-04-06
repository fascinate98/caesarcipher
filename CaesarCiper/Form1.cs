using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //암호화
        {
            string plaintext;
            string key;

            plaintext = textBox1.Text;
            key = textBox2.Text;

            string crypto =  Encrypt.Encryption(plaintext, int.Parse(key));

            textBox3.Text = crypto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cryto;
            string key;

            cryto = textBox6.Text;
            key = textBox5.Text;

            string plaintext = Decrypt.Decryption(cryto, int.Parse(key));

            textBox4.Text = plaintext;
        }
    }
}
