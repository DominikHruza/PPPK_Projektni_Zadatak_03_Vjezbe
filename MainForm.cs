using Projektni_Zadatak_03_Vjezbe.Dal;
using Projektni_Zadatak_03_Vjezbe.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            LoadDatabases();
        }

        private void LoadDatabases()
        {
            cbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }
    }
}
