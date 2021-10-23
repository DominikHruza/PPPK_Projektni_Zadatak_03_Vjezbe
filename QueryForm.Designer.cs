
namespace Projektni_Zadatak_03_Vjezbe
{
    partial class QueryForm
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
            this.tbQueryText = new System.Windows.Forms.RichTextBox();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tbMsgs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRunQuery = new System.Windows.Forms.Button();
            this.DgResults = new System.Windows.Forms.DataGridView();
            this.tabPanel.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.tabMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQueryText
            // 
            this.tbQueryText.Location = new System.Drawing.Point(184, 68);
            this.tbQueryText.Name = "tbQueryText";
            this.tbQueryText.Size = new System.Drawing.Size(724, 245);
            this.tbQueryText.TabIndex = 0;
            this.tbQueryText.Text = "";
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabResults);
            this.tabPanel.Controls.Add(this.tabMessages);
            this.tabPanel.Location = new System.Drawing.Point(184, 319);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(731, 177);
            this.tabPanel.TabIndex = 1;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.DgResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(723, 151);
            this.tabResults.TabIndex = 0;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.tbMsgs);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(723, 151);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // tbMsgs
            // 
            this.tbMsgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMsgs.Location = new System.Drawing.Point(3, 3);
            this.tbMsgs.Multiline = true;
            this.tbMsgs.Name = "tbMsgs";
            this.tbMsgs.Size = new System.Drawing.Size(717, 145);
            this.tbMsgs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write query:";
            // 
            // BtnRunQuery
            // 
            this.BtnRunQuery.Location = new System.Drawing.Point(23, 68);
            this.BtnRunQuery.Name = "BtnRunQuery";
            this.BtnRunQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnRunQuery.TabIndex = 3;
            this.BtnRunQuery.Text = "Run Query";
            this.BtnRunQuery.UseVisualStyleBackColor = true;
            this.BtnRunQuery.Click += new System.EventHandler(this.BtnRunQuery_Click);
            // 
            // DgResults
            // 
            this.DgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgResults.Location = new System.Drawing.Point(3, 3);
            this.DgResults.Name = "DgResults";
            this.DgResults.Size = new System.Drawing.Size(717, 145);
            this.DgResults.TabIndex = 0;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 536);
            this.Controls.Add(this.BtnRunQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.tbQueryText);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query Window";
            this.tabPanel.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            this.tabMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbQueryText;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRunQuery;
        private System.Windows.Forms.TextBox tbMsgs;
        private System.Windows.Forms.DataGridView DgResults;
    }
}