
namespace Projektni_Zadatak_03_Vjezbe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNewQuery = new System.Windows.Forms.Button();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbProcedure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbTableColums = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNewQuery
            // 
            this.BtnNewQuery.Location = new System.Drawing.Point(255, 24);
            this.BtnNewQuery.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewQuery.Name = "BtnNewQuery";
            this.BtnNewQuery.Size = new System.Drawing.Size(82, 27);
            this.BtnNewQuery.TabIndex = 37;
            this.BtnNewQuery.Text = "New Query";
            this.BtnNewQuery.UseVisualStyleBackColor = true;
            this.BtnNewQuery.Click += new System.EventHandler(this.BtnNewQuery_Click);
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.Location = new System.Drawing.Point(979, 374);
            this.LbProcedureParameters.Margin = new System.Windows.Forms.Padding(2);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(142, 251);
            this.LbProcedureParameters.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(859, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Procedure parameters:";
            // 
            // TbProcedure
            // 
            this.TbProcedure.Location = new System.Drawing.Point(444, 374);
            this.TbProcedure.Margin = new System.Windows.Forms.Padding(2);
            this.TbProcedure.Multiline = true;
            this.TbProcedure.Name = "TbProcedure";
            this.TbProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbProcedure.Size = new System.Drawing.Size(396, 251);
            this.TbProcedure.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Procedure definition:";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.Location = new System.Drawing.Point(73, 374);
            this.LbProcedures.Margin = new System.Windows.Forms.Padding(2);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(239, 251);
            this.LbProcedures.TabIndex = 31;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Procedures:";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.Location = new System.Drawing.Point(979, 76);
            this.LbViewColumns.Margin = new System.Windows.Forms.Padding(2);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(142, 251);
            this.LbViewColumns.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(901, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "View Columns:";
            // 
            // LbTableColums
            // 
            this.LbTableColums.FormattingEnabled = true;
            this.LbTableColums.Location = new System.Drawing.Point(444, 76);
            this.LbTableColums.Margin = new System.Windows.Forms.Padding(2);
            this.LbTableColums.Name = "LbTableColums";
            this.LbTableColums.Size = new System.Drawing.Size(142, 251);
            this.LbTableColums.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Table Columns:";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.Location = new System.Drawing.Point(655, 76);
            this.LbViews.Margin = new System.Windows.Forms.Padding(2);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(185, 251);
            this.LbViews.TabIndex = 25;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Views:";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.Location = new System.Drawing.Point(73, 76);
            this.LbTables.Margin = new System.Windows.Forms.Padding(2);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(239, 251);
            this.LbTables.TabIndex = 23;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tables:";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(73, 28);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(142, 21);
            this.CbDatabases.TabIndex = 21;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Databases:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 691);
            this.Controls.Add(this.BtnNewQuery);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbProcedure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbTableColums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNewQuery;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbProcedure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbTableColums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label1;
    }
}