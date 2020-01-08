using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login {
    public partial class MainSASCO : Form {
        public MainSASCO() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

            
        }
  
         private void button1_Click(object sender, EventArgs e)
        {
            Oder Customer = new Oder();
            Customer.Show();
        }
    }
}
