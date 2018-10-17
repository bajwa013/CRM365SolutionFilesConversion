namespace CRMSolutionXMLReader
{
    partial class InputForm
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
            this.lblBrowseFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnProcessXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrowseFile
            // 
            this.lblBrowseFile.AutoSize = true;
            this.lblBrowseFile.Location = new System.Drawing.Point(24, 36);
            this.lblBrowseFile.Name = "lblBrowseFile";
            this.lblBrowseFile.Size = new System.Drawing.Size(153, 13);
            this.lblBrowseFile.TabIndex = 0;
            this.lblBrowseFile.Text = "Browse Customization.xml File: ";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(175, 32);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(343, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(517, 32);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnProcessXML
            // 
            this.btnProcessXML.Location = new System.Drawing.Point(547, 229);
            this.btnProcessXML.Name = "btnProcessXML";
            this.btnProcessXML.Size = new System.Drawing.Size(75, 23);
            this.btnProcessXML.TabIndex = 3;
            this.btnProcessXML.Text = "Proceed";
            this.btnProcessXML.UseVisualStyleBackColor = true;
            this.btnProcessXML.Click += new System.EventHandler(this.btnProcessXML_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 264);
            this.Controls.Add(this.btnProcessXML);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblBrowseFile);
            this.Name = "InputForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowseFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnProcessXML;
    }
}

