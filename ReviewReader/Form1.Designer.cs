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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.upload = new System.Windows.Forms.TabPage();
            this.selectTitle = new System.Windows.Forms.Label();
            this.textFileGenButton = new System.Windows.Forms.Button();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.statistic = new System.Windows.Forms.TabPage();
            this.noRatingGen = new System.Windows.Forms.Button();
            this.unhelpfulVoteTableGen = new System.Windows.Forms.Button();
            this.voteGoodTableGen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userVoteGood = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxRatTableGen = new System.Windows.Forms.Button();
            this.minRatTableGen = new System.Windows.Forms.Button();
            this.maxRevTableGen = new System.Windows.Forms.Button();
            this.minRevTableGen = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maximumRating = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.minimumRating = new System.Windows.Forms.Label();
            this.groupTitle = new System.Windows.Forms.Label();
            this.userTitle = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.TabPage();
            this.tableGen = new System.Windows.Forms.Button();
            this.tableDisplay = new System.Windows.Forms.DataGridView();
            this.tableComboB = new System.Windows.Forms.ComboBox();
            this.Tables = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Label();
            this.userComboB = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.upload.SuspendLayout();
            this.statistic.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(350, 73);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(105, 23);
            this.fileSelect.TabIndex = 0;
            this.fileSelect.Text = "Select File";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // loadDb
            // 
            this.loadDb.Location = new System.Drawing.Point(37, 211);
            this.loadDb.Name = "loadDb";
            this.loadDb.Size = new System.Drawing.Size(105, 23);
            this.loadDb.TabIndex = 1;
            this.loadDb.Text = "Load File to DB";
            this.loadDb.UseVisualStyleBackColor = true;
            this.loadDb.Click += new System.EventHandler(this.loadDb_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.upload);
            this.tabControl1.Controls.Add(this.statistic);
            this.tabControl1.Controls.Add(this.table);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 446);
            this.tabControl1.TabIndex = 2;
            // 
            // upload
            // 
            this.upload.Controls.Add(this.selectTitle);
            this.upload.Controls.Add(this.textFileGenButton);
            this.upload.Controls.Add(this.filePathTextbox);
            this.upload.Controls.Add(this.fileSelect);
            this.upload.Controls.Add(this.loadDb);
            this.upload.Location = new System.Drawing.Point(4, 22);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(3);
            this.upload.Size = new System.Drawing.Size(600, 420);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // selectTitle
            // 
            this.selectTitle.AutoSize = true;
            this.selectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTitle.Location = new System.Drawing.Point(33, 36);
            this.selectTitle.Name = "selectTitle";
            this.selectTitle.Size = new System.Drawing.Size(222, 24);
            this.selectTitle.TabIndex = 5;
            this.selectTitle.Text = "Select Review Text file";
            // 
            // textFileGenButton
            // 
            this.textFileGenButton.Location = new System.Drawing.Point(180, 211);
            this.textFileGenButton.Name = "textFileGenButton";
            this.textFileGenButton.Size = new System.Drawing.Size(105, 23);
            this.textFileGenButton.TabIndex = 3;
            this.textFileGenButton.Text = "Generate text file";
            this.textFileGenButton.UseVisualStyleBackColor = true;
            this.textFileGenButton.Click += new System.EventHandler(this.textFileGenButton_Click);
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(42, 76);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.Size = new System.Drawing.Size(292, 20);
            this.filePathTextbox.TabIndex = 6;
            this.filePathTextbox.Text = "../Amazon Review Dataset.txt";
            // 
            // statistic
            // 
            this.statistic.Controls.Add(this.noRatingGen);
            this.statistic.Controls.Add(this.unhelpfulVoteTableGen);
            this.statistic.Controls.Add(this.voteGoodTableGen);
            this.statistic.Controls.Add(this.label6);
            this.statistic.Controls.Add(this.label5);
            this.statistic.Controls.Add(this.userVoteGood);
            this.statistic.Controls.Add(this.label3);
            this.statistic.Controls.Add(this.maxRatTableGen);
            this.statistic.Controls.Add(this.minRatTableGen);
            this.statistic.Controls.Add(this.maxRevTableGen);
            this.statistic.Controls.Add(this.minRevTableGen);
            this.statistic.Controls.Add(this.textBox5);
            this.statistic.Controls.Add(this.maximumRating);
            this.statistic.Controls.Add(this.textBox4);
            this.statistic.Controls.Add(this.minimumRating);
            this.statistic.Controls.Add(this.groupTitle);
            this.statistic.Controls.Add(this.userTitle);
            this.statistic.Controls.Add(this.textBox3);
            this.statistic.Controls.Add(this.label2);
            this.statistic.Controls.Add(this.label1);
            this.statistic.Controls.Add(this.textBox2);
            this.statistic.Location = new System.Drawing.Point(4, 22);
            this.statistic.Name = "statistic";
            this.statistic.Padding = new System.Windows.Forms.Padding(3);
            this.statistic.Size = new System.Drawing.Size(600, 420);
            this.statistic.TabIndex = 1;
            this.statistic.Text = "Statistic";
            this.statistic.UseVisualStyleBackColor = true;
            // 
            // noRatingGen
            // 
            this.noRatingGen.Location = new System.Drawing.Point(145, 338);
            this.noRatingGen.Name = "noRatingGen";
            this.noRatingGen.Size = new System.Drawing.Size(100, 23);
            this.noRatingGen.TabIndex = 20;
            this.noRatingGen.Text = "Generate Table";
            this.noRatingGen.UseVisualStyleBackColor = true;
            this.noRatingGen.Click += new System.EventHandler(this.noRatingGen_Click);
            // 
            // unhelpfulVoteTableGen
            // 
            this.unhelpfulVoteTableGen.Location = new System.Drawing.Point(145, 309);
            this.unhelpfulVoteTableGen.Name = "unhelpfulVoteTableGen";
            this.unhelpfulVoteTableGen.Size = new System.Drawing.Size(100, 23);
            this.unhelpfulVoteTableGen.TabIndex = 19;
            this.unhelpfulVoteTableGen.Text = "Generate Table";
            this.unhelpfulVoteTableGen.UseCompatibleTextRendering = true;
            this.unhelpfulVoteTableGen.UseVisualStyleBackColor = true;
            this.unhelpfulVoteTableGen.Click += new System.EventHandler(this.unhelpfulVoteTableGen_Click);
            // 
            // voteGoodTableGen
            // 
            this.voteGoodTableGen.Location = new System.Drawing.Point(145, 280);
            this.voteGoodTableGen.Name = "voteGoodTableGen";
            this.voteGoodTableGen.Size = new System.Drawing.Size(100, 23);
            this.voteGoodTableGen.TabIndex = 18;
            this.voteGoodTableGen.Text = "Generate Table";
            this.voteGoodTableGen.UseCompatibleTextRendering = true;
            this.voteGoodTableGen.UseVisualStyleBackColor = true;
            this.voteGoodTableGen.Click += new System.EventHandler(this.voteGoodTableGen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Users with no Rating";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Users voted not helpful";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // userVoteGood
            // 
            this.userVoteGood.AutoSize = true;
            this.userVoteGood.Location = new System.Drawing.Point(41, 285);
            this.userVoteGood.Name = "userVoteGood";
            this.userVoteGood.Size = new System.Drawing.Size(98, 13);
            this.userVoteGood.TabIndex = 15;
            this.userVoteGood.Text = "Users voted helpful";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Groups based on Review Helpfulness Ratings\r\n";
            // 
            // maxRatTableGen
            // 
            this.maxRatTableGen.Location = new System.Drawing.Point(241, 190);
            this.maxRatTableGen.Name = "maxRatTableGen";
            this.maxRatTableGen.Size = new System.Drawing.Size(100, 23);
            this.maxRatTableGen.TabIndex = 13;
            this.maxRatTableGen.Text = "Generate Table";
            this.maxRatTableGen.UseCompatibleTextRendering = true;
            this.maxRatTableGen.UseVisualStyleBackColor = true;
            this.maxRatTableGen.Click += new System.EventHandler(this.maxRatTableGen_Click);
            // 
            // minRatTableGen
            // 
            this.minRatTableGen.Location = new System.Drawing.Point(241, 164);
            this.minRatTableGen.Name = "minRatTableGen";
            this.minRatTableGen.Size = new System.Drawing.Size(100, 23);
            this.minRatTableGen.TabIndex = 12;
            this.minRatTableGen.Text = "Generate Table";
            this.minRatTableGen.UseCompatibleTextRendering = true;
            this.minRatTableGen.UseVisualStyleBackColor = true;
            this.minRatTableGen.Click += new System.EventHandler(this.minRatTableGen_Click);
            // 
            // maxRevTableGen
            // 
            this.maxRevTableGen.Location = new System.Drawing.Point(241, 77);
            this.maxRevTableGen.Name = "maxRevTableGen";
            this.maxRevTableGen.Size = new System.Drawing.Size(100, 23);
            this.maxRevTableGen.TabIndex = 11;
            this.maxRevTableGen.Text = "Generate Table";
            this.maxRevTableGen.UseCompatibleTextRendering = true;
            this.maxRevTableGen.UseVisualStyleBackColor = true;
            this.maxRevTableGen.Click += new System.EventHandler(this.maxRevTableGen_Click);
            // 
            // minRevTableGen
            // 
            this.minRevTableGen.Location = new System.Drawing.Point(241, 49);
            this.minRevTableGen.Name = "minRevTableGen";
            this.minRevTableGen.Size = new System.Drawing.Size(100, 23);
            this.minRevTableGen.TabIndex = 10;
            this.minRevTableGen.Text = "Generate Table";
            this.minRevTableGen.UseCompatibleTextRendering = true;
            this.minRevTableGen.UseVisualStyleBackColor = true;
            this.minRevTableGen.Click += new System.EventHandler(this.minRevTableGen_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 9;
            // 
            // maximumRating
            // 
            this.maximumRating.AutoSize = true;
            this.maximumRating.Location = new System.Drawing.Point(41, 192);
            this.maximumRating.Name = "maximumRating";
            this.maximumRating.Size = new System.Drawing.Size(66, 13);
            this.maximumRating.TabIndex = 8;
            this.maximumRating.Text = "Max Ratings";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 7;
            // 
            // minimumRating
            // 
            this.minimumRating.AutoSize = true;
            this.minimumRating.Location = new System.Drawing.Point(41, 164);
            this.minimumRating.Name = "minimumRating";
            this.minimumRating.Size = new System.Drawing.Size(63, 13);
            this.minimumRating.TabIndex = 6;
            this.minimumRating.Text = "Min Ratings";
            // 
            // groupTitle
            // 
            this.groupTitle.AutoSize = true;
            this.groupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTitle.Location = new System.Drawing.Point(25, 130);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(491, 24);
            this.groupTitle.TabIndex = 5;
            this.groupTitle.Text = "User Groups based on Min/Max Ratings per Review";
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitle.Location = new System.Drawing.Point(25, 20);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(475, 24);
            this.userTitle.TabIndex = 4;
            this.userTitle.Text = "User Groups based on Min/Max Reviews per User";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Reviews";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min Reviews";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 0;
            // 
            // table
            // 
            this.table.Controls.Add(this.userComboB);
            this.table.Controls.Add(this.Users);
            this.table.Controls.Add(this.Tables);
            this.table.Controls.Add(this.tableComboB);
            this.table.Controls.Add(this.tableGen);
            this.table.Controls.Add(this.tableDisplay);
            this.table.Location = new System.Drawing.Point(4, 22);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(600, 420);
            this.table.TabIndex = 2;
            this.table.Text = "Table";
            this.table.UseVisualStyleBackColor = true;
            // 
            // tableGen
            // 
            this.tableGen.Location = new System.Drawing.Point(16, 337);
            this.tableGen.Name = "tableGen";
            this.tableGen.Size = new System.Drawing.Size(113, 36);
            this.tableGen.TabIndex = 2;
            this.tableGen.Text = "Generate Table";
            this.tableGen.UseVisualStyleBackColor = true;
            this.tableGen.Click += new System.EventHandler(this.tableGen_Click);
            // 
            // tableDisplay
            // 
            this.tableDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDisplay.Location = new System.Drawing.Point(142, 20);
            this.tableDisplay.Name = "tableDisplay";
            this.tableDisplay.Size = new System.Drawing.Size(437, 369);
            this.tableDisplay.TabIndex = 0;
            // 
            // tableComboB
            // 
            this.tableComboB.FormattingEnabled = true;
            this.tableComboB.Location = new System.Drawing.Point(16, 45);
            this.tableComboB.Name = "tableComboB";
            this.tableComboB.Size = new System.Drawing.Size(113, 21);
            this.tableComboB.TabIndex = 3;
            // 
            // Tables
            // 
            this.Tables.AutoSize = true;
            this.Tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables.Location = new System.Drawing.Point(16, 21);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(73, 24);
            this.Tables.TabIndex = 4;
            this.Tables.Text = "Tables";
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(16, 112);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(63, 24);
            this.Users.TabIndex = 6;
            this.Users.Text = "Users";
            // 
            // userComboB
            // 
            this.userComboB.FormattingEnabled = true;
            this.userComboB.Location = new System.Drawing.Point(16, 140);
            this.userComboB.Name = "userComboB";
            this.userComboB.Size = new System.Drawing.Size(112, 21);
            this.userComboB.TabIndex = 7;
            this.userComboB.SelectedIndexChanged += new System.EventHandler(this.userComboB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(609, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Review Data Processing";
            this.tabControl1.ResumeLayout(false);
            this.upload.ResumeLayout(false);
            this.upload.PerformLayout();
            this.statistic.ResumeLayout(false);
            this.statistic.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button loadDb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage upload;
        private System.Windows.Forms.TabPage statistic;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.Button textFileGenButton;
        private System.Windows.Forms.Label selectTitle;
        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button maxRatTableGen;
        private System.Windows.Forms.Button minRatTableGen;
        private System.Windows.Forms.Button maxRevTableGen;
        private System.Windows.Forms.Button minRevTableGen;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label maximumRating;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label minimumRating;
        private System.Windows.Forms.Label groupTitle;
        private System.Windows.Forms.Button noRatingGen;
        private System.Windows.Forms.Button unhelpfulVoteTableGen;
        private System.Windows.Forms.Button voteGoodTableGen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userVoteGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage table;
        private System.Windows.Forms.Button tableGen;
        private System.Windows.Forms.DataGridView tableDisplay;
        private System.Windows.Forms.ComboBox userComboB;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Label Tables;
        private System.Windows.Forms.ComboBox tableComboB;
    }
}

