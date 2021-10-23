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
    public partial class QueryForm : Form
    {
        public Database SelectedDatabase { get; set; }

        List<string> supportedDdlQueries = new List<string>
        {
            "CREATE TABLE",
            "ALTER TABLE",
            "DELETE TABLE"
        };

        List<string> supportedDmlQueries = new List<string>
        {
            "UPDATE",
            "DELETE",
            "INSERT"
        };

        public QueryForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
           
        }

        private void BtnRunQuery_Click(object sender, EventArgs e)
        {

            string queryText = tbQueryText.Text;
            string command = ParseQueryCommandType(queryText);
            if (command.Equals(""))
            {
                tbMsgs.Text = "";
                tbMsgs.Text = "Unsuopported opperation!";
                tabPanel.SelectedIndex = 1;
            }


            if(supportedDdlQueries.Exists(q => q.Equals(command) || supportedDmlQueries.Exists(d => d.Equals(command))))
            {
                HandleNonQuerys(queryText);
            }

            if (command.Equals("SELECT"))
            {
                HandleSelect(queryText);
            }
        }

        private void HandleSelect(string queryText)
        {
            try
            {
                DataSet dataSet = RepositoryFactory.GetRepository().CreateDataSet(queryText);
                DgResults.DataSource = dataSet.Tables[0];
                tbMsgs.Text = "";
                tbMsgs.Text = $"Rows fetched {dataSet.Tables[0].Rows.Count}";
              
            }
            catch (Exception ex)
            {
                tbMsgs.Text = "";
                tbMsgs.Text = ex.Message;
                tabPanel.SelectedIndex = 1;

            }
        }

        private void HandleNonQuerys(string queryText)
        {
            try
            {
                long rowsAffected = RepositoryFactory.GetRepository().RunNonQuery(queryText);
                tbMsgs.Text = "";
                tbMsgs.Text = "Operation Success. Rows affected " + rowsAffected;
                tabPanel.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                tbMsgs.Text = "";
                tbMsgs.Text = ex.Message;
                tabPanel.SelectedIndex = 1;
            }
        }

        private string ParseQueryCommandType(string queryText)
        {
            if (queryText.ToUpper().StartsWith("SELECT"))
            {
                return "SELECT";
            }

            foreach (string sq in supportedDdlQueries)
            {
                if (queryText.ToUpper().StartsWith(sq))
                {
                    return sq;
                }

            }


            foreach (string sq in supportedDmlQueries)
            {
                if (queryText.ToUpper().StartsWith(sq))
                {
                    return sq;
                }

            }
            return "";
        }
    }
}
