
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(724, 245);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Location = new System.Drawing.Point(184, 319);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 177);
            this.tabControl1.TabIndex = 1;
            // 
            // tabResults
            // 
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
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(723, 74);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
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
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(26, 68);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(121, 21);
            this.cbDatabases.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Databases:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query Window";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label2;
    }
}