using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Xoan" && txtPassword.Text == "Pass")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            } else if (txtUsername.Text == "quoccanh" && txtPassword.Text == "123456")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "quoccanh123" && txtPassword.Text == "123456")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "quanly123" && txtPassword.Text == "123456")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "123456")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
        }
    }
}
