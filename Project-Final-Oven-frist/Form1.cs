using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login {
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            Form2 fr = new Form2();
            if (u == "admin") {
                if (p == "12345678") {
                    fr.ShowDialog();
                } else {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง!!!");

                }
            } else {
                MessageBox.Show("Username ผิด!!!");
            }
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
