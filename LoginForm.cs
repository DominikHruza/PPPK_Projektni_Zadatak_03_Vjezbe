using Projektni_Zadatak_03_Vjezbe.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektni_Zadatak_03_Vjezbe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(
                        tbServer.Text.Trim(),
                        tbUserName.Text.Trim(),
                        tbPassword.Text.Trim());

                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;       
            }
        }

       
    }
}
