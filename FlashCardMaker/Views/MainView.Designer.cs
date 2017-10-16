namespace FlashCardMaker
{
    partial class MainView
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
            this.btnBrowseAddToDatabase = new System.Windows.Forms.Button();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.txtbxAddToDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOutput = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseAddToDatabase
            // 
            this.btnBrowseAddToDatabase.Location = new System.Drawing.Point(441, 51);
            this.btnBrowseAddToDatabase.Name = "btnBrowseAddToDatabase";
            this.btnBrowseAddToDatabase.Size = new System.Drawing.Size(102, 23);
            this.btnBrowseAddToDatabase.TabIndex = 0;
            this.btnBrowseAddToDatabase.Text = "Browse...";
            this.btnBrowseAddToDatabase.UseVisualStyleBackColor = true;
            this.btnBrowseAddToDatabase.Click += new System.EventHandler(this.btnBrowseAddToDatabase_Click);
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Location = new System.Drawing.Point(549, 51);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(108, 23);
            this.btnAddToDatabase.TabIndex = 1;
            this.btnAddToDatabase.Text = "Add to Database";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            this.btnAddToDatabase.Click += new System.EventHandler(this.btnAddToDatabase_Click);
            // 
            // txtbxAddToDatabase
            // 
            this.txtbxAddToDatabase.Location = new System.Drawing.Point(12, 51);
            this.txtbxAddToDatabase.Name = "txtbxAddToDatabase";
            this.txtbxAddToDatabase.Size = new System.Drawing.Size(423, 20);
            this.txtbxAddToDatabase.TabIndex = 2;
            this.txtbxAddToDatabase.Text = "Please Choose Filepath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Subtitles to Database";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(12, 161);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(645, 276);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "No Output";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(768, 47);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 5;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 446);
            this.Controls.Add(this.test);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxAddToDatabase);
            this.Controls.Add(this.btnAddToDatabase);
            this.Controls.Add(this.btnBrowseAddToDatabase);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseAddToDatabase;
        private System.Windows.Forms.Button btnAddToDatabase;
        private System.Windows.Forms.TextBox txtbxAddToDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button test;
    }
}

