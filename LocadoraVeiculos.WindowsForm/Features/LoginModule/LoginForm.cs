using LocadoraVeiculos.WindowsForm.Features.LoginModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StatusLogin.Text = "Entre com o seu Login";
        }

        public static string login;

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
