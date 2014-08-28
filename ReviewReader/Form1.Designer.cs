namespace TextReader
{
    partial class Form1
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
            this.fileSelect = new System.Windows.Forms.Button();
            this.loadDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(79, 56);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(105, 23);
            this.fileSelect.TabIndex = 0;
            this.fileSelect.Text = "Select File";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // loadDb
            // 
            this.loadDb.Location = new System.Drawing.Point(79, 85);
            this.loadDb.Name = "loadDb";
            this.loadDb.Size = new System.Drawing.Size(105, 23);
            this.loadDb.TabIndex = 1;
            this.loadDb.Text = "Load File to DB";
            this.loadDb.UseVisualStyleBackColor = true;
            this.loadDb.Click += new System.EventHandler(this.loadDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loadDb);
            this.Controls.Add(this.fileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button loadDb;
    }
}

