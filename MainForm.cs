using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Projektni_Zadatak_03_Vjezbe.Dal;
using Projektni_Zadatak_03_Vjezbe.Models;

namespace Projektni_Zadatak_03_Vjezbe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => LoadDatabases();

        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            LbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            LbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void Clear()
        {
            LbTableColums.DataSource = null;
            LbViewColumns.DataSource = null;
            TbProcedure.Text = string.Empty;
            LbProcedureParameters.DataSource = null;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e) => LbTableColums.DataSource = (LbTables.SelectedItem as DBEntity).Columns;

        private void LbViews_SelectedIndexChanged(object sender, EventArgs e) => LbViewColumns.DataSource = (LbViews.SelectedItem as DBEntity).Columns;

        private void LbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbProcedure.Text = (LbProcedures.SelectedItem as Procedure).Definition;
            LbProcedureParameters.DataSource = (LbProcedures.SelectedItem as Procedure).Parameters;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //DBEntity dbEntity;
            //switch ((sender as Button).Name)
            //{
            //    case nameof(BtnNewQuery):
            //        dbEntity = LbTables.SelectedItem as DBEntity;
            //        break;
            //    case nameof(BtnSelectView):
            //        dbEntity = LbViews.SelectedItem as DBEntity;
            //        break;
            //    default:
            //        throw new Exception("Wrong wiring");
            //}
           // DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(dbEntity);
            //new SelectResultsForm(ds.Tables[0]).ShowDialog();
        }

        private void BtnNewQuery_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.SelectedDatabase = (Database)CbDatabases.SelectedItem;
            queryForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        
    }
}

