using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login {
    public partial class Login : Form 
    {
        public Login() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            MainSASCO fr = new MainSASCO();    
            if (u == "admin") 
            {
                if (p == "12345678") 
                {
                    this.Hide();
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง!!!","คำเตือน",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Usernameผิด!!!","คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
