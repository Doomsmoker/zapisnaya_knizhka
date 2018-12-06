using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zapisnaya_knizhka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int iTry = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (iTry > -1)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "Flayaracea")
                {
                    this.Hide();

                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                    this.Close();
                }
                else

                    if (iTry == 0)
                    {
                        MessageBox.Show("Попытки закончились!");
                        Application.Exit();
                    }
                    else MessageBox.Show("Логин/пароль неверен! Попыток осталось: " + iTry + ".");
                iTry--;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
                
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (iTry > -1)
                {
                    if (textBox1.Text == "admin" && textBox2.Text == "Flayaracea")
                    {
                        this.Hide();

                        Form2 form2 = new Form2();
                        form2.ShowDialog();

                        this.Close();
                    }
                    else

                        if (iTry == 0)
                        {
                            MessageBox.Show("Попытки закончились!");
                            Application.Exit();
                        }
                        else MessageBox.Show("Логин/пароль неверен! Попыток осталось: " + iTry + ".");
                    iTry--;
                }
            }
        }
    }
}
