using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject4
{
    public partial class Form4 : Form
    {
        Form3 form3;
        public Form4(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }
    }
}
