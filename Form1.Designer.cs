namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelectXMLPath = new Button();
            cmbStrategy = new ComboBox();
            txtXmlPath = new TextBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtXslPath = new TextBox();
            btnSelectXSLPath = new Button();
            label4 = new Label();
            txtHtmlPath = new TextBox();
            btnSelectHTMLPath = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cmbDirector = new ComboBox();
            cmbYear = new ComboBox();
            cmbMovie = new ComboBox();
            cmbActorName = new ComboBox();
            btnAnalyze = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            Director = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Movie = new DataGridViewTextBoxColumn();
            Actor = new DataGridViewTextBoxColumn();
            ScreanTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSelectXMLPath
            // 
            btnSelectXMLPath.BackColor = Color.Tomato;
            btnSelectXMLPath.Cursor = Cursors.Hand;
            btnSelectXMLPath.Location = new Point(23, 102);
            btnSelectXMLPath.Name = "btnSelectXMLPath";
            btnSelectXMLPath.Size = new Size(94, 29);
            btnSelectXMLPath.TabIndex = 0;
            btnSelectXMLPath.Text = "Огляд";
            btnSelectXMLPath.UseVisualStyleBackColor = false;
            btnSelectXMLPath.Click += btnSelectXMLPath_Click;
            // 
            // cmbStrategy
            // 
            cmbStrategy.BackColor = SystemColors.HighlightText;
            cmbStrategy.Cursor = Cursors.Hand;
            cmbStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStrategy.FormattingEnabled = true;
            cmbStrategy.Items.AddRange(new object[] { "SAX API", "DOM API", "LINQ to XML" });
            cmbStrategy.Location = new Point(23, 271);
            cmbStrategy.Name = "cmbStrategy";
            cmbStrategy.RightToLeft = RightToLeft.No;
            cmbStrategy.Size = new Size(252, 28);
            cmbStrategy.TabIndex = 1;
            // 
            // txtXmlPath
            // 
            txtXmlPath.Cursor = Cursors.Hand;
            txtXmlPath.Location = new Point(23, 70);
            txtXmlPath.Name = "txtXmlPath";
            txtXmlPath.Size = new Size(414, 27);
            txtXmlPath.TabIndex = 2;
            txtXmlPath.TextChanged += txtXmlPath_TextChanged;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SandyBrown;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(357, 246);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 51);
            btnStart.TabIndex = 4;
            btnStart.Text = "Трансформувати в HTML";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 47);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 6;
            label1.Text = "Виберіть шлях до XML файлу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 248);
            label2.Name = "label2";
            label2.Size = new Size(252, 20);
            label2.TabIndex = 7;
            label2.Text = "Виберіть спосіб аналізу документа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 47);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 10;
            label3.Text = "Виберіть шлях до XSL файлу";
            // 
            // txtXslPath
            // 
            txtXslPath.Cursor = Cursors.Hand;
            txtXslPath.Location = new Point(444, 70);
            txtXslPath.Name = "txtXslPath";
            txtXslPath.Size = new Size(474, 27);
            txtXslPath.TabIndex = 9;
            // 
            // btnSelectXSLPath
            // 
            btnSelectXSLPath.BackColor = Color.LightSalmon;
            btnSelectXSLPath.Cursor = Cursors.Hand;
            btnSelectXSLPath.Location = new Point(444, 103);
            btnSelectXSLPath.Name = "btnSelectXSLPath";
            btnSelectXSLPath.Size = new Size(94, 29);
            btnSelectXSLPath.TabIndex = 8;
            btnSelectXSLPath.Text = "Огляд";
            btnSelectXSLPath.UseVisualStyleBackColor = false;
            btnSelectXSLPath.Click += btnSelectXSLPath_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(924, 47);
            label4.Name = "label4";
            label4.Size = new Size(358, 20);
            label4.TabIndex = 13;
            label4.Text = "Виберіть шлях до результуючого HTML документу";
            // 
            // txtHtmlPath
            // 
            txtHtmlPath.Cursor = Cursors.Hand;
            txtHtmlPath.Location = new Point(924, 70);
            txtHtmlPath.Name = "txtHtmlPath";
            txtHtmlPath.Size = new Size(443, 27);
            txtHtmlPath.TabIndex = 12;
            // 
            // btnSelectHTMLPath
            // 
            btnSelectHTMLPath.BackColor = Color.PeachPuff;
            btnSelectHTMLPath.Cursor = Cursors.Hand;
            btnSelectHTMLPath.Location = new Point(924, 103);
            btnSelectHTMLPath.Name = "btnSelectHTMLPath";
            btnSelectHTMLPath.Size = new Size(94, 29);
            btnSelectHTMLPath.TabIndex = 11;
            btnSelectHTMLPath.Text = "Огляд";
            btnSelectHTMLPath.UseVisualStyleBackColor = false;
            btnSelectHTMLPath.Click += btnSelectHTMLPath_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 154);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 16;
            label5.Text = "Режисер";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 154);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 17;
            label6.Text = "Рік виходу";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(720, 154);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 18;
            label7.Text = "Фільм";
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1068, 154);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 19;
            label8.Text = "Актор";
            
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(760, 279);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(818, 277);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(912, 277);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 22;
            // 
            // cmbDirector
            //
            cmbDirector.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDirector.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDirector.Cursor = Cursors.Hand;
            cmbDirector.FormattingEnabled = true;
            cmbDirector.Location = new Point(23, 177);
            cmbDirector.Name = "cmbDirector";
            cmbDirector.Size = new Size(235, 28);
            cmbDirector.TabIndex = 23;

            // cmbYear
            cmbYear.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbYear.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbYear.Cursor = Cursors.Hand;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(357, 177);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(235, 28);
            cmbYear.TabIndex = 24;

            // cmbMovie
            cmbMovie.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMovie.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMovie.Cursor = Cursors.Hand;
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(720, 177);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(235, 28);
            cmbMovie.TabIndex = 25;

            // cmbActorName
            cmbActorName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbActorName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbActorName.Cursor = Cursors.Hand;
            cmbActorName.FormattingEnabled = true;
            cmbActorName.Location = new Point(1068, 177);
            cmbActorName.Name = "cmbActorName";
            cmbActorName.Size = new Size(235, 28);
            cmbActorName.TabIndex = 26;
            //
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.Khaki;
            btnAnalyze.Cursor = Cursors.Hand;
            btnAnalyze.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalyze.Location = new Point(1068, 246);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(150, 51);
            btnAnalyze.TabIndex = 29;
            btnAnalyze.Text = "Аналізувати";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(720, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 51);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Director, Year, Movie, Actor, ScreanTime });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1379, 487);
            dataGridView1.TabIndex = 31;
          
            // 
            // Producer
            // 
            Director.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Director.HeaderText = "Режисер";
            Director.MinimumWidth = 6;
            Director.Name = "Producer";
            Director.ReadOnly = true;
            Director.Width = 101;
            // 
            // Year
            // 
            Year.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Year.HeaderText = "Рік виходу";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 115;
            // 
            // Movie
            // 
            Movie.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Movie.HeaderText = "Фільм";
            Movie.MinimumWidth = 6;
            Movie.Name = "Movie";
            Movie.ReadOnly = true;
            Movie.Width = 84;
            // 
            // Actor
            // 
            Actor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Actor.HeaderText = "Актор";
            Actor.MinimumWidth = 6;
            Actor.Name = "Actor";
            Actor.ReadOnly = true;
            Actor.Width = 82;
            // 
            // ScreanTime
            // 
            ScreanTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ScreanTime.DefaultCellStyle = dataGridViewCellStyle2;
            ScreanTime.HeaderText = "Екранний час";
            ScreanTime.MinimumWidth = 6;
            ScreanTime.Name = "ScreanTime";
            ScreanTime.ReadOnly = true;
            ScreanTime.Width = 135;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1379, 829);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnAnalyze);
            Controls.Add(cmbActorName);
            Controls.Add(cmbMovie);
            Controls.Add(cmbYear);
            Controls.Add(cmbDirector);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtHtmlPath);
            Controls.Add(btnSelectHTMLPath);
            Controls.Add(label3);
            Controls.Add(txtXslPath);
            Controls.Add(btnSelectXSLPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtXmlPath);
            Controls.Add(cmbStrategy);
            Controls.Add(btnSelectXMLPath);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panchenko Zoya";
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectXMLPath;
        private ComboBox cmbStrategy;
        private TextBox txtXmlPath;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtXslPath;
        private Button btnSelectXSLPath;
        private Label label4;
        private TextBox txtHtmlPath;
        private Button btnSelectHTMLPath;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cmbDirector;
        private ComboBox cmbYear;
        private ComboBox cmbMovie;
        private ComboBox cmbActorName;
        private Button btnAnalyze;
        private Button btnClear;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Director;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Movie;
        private DataGridViewTextBoxColumn Actor;
        private DataGridViewTextBoxColumn ScreanTime;
    }
}