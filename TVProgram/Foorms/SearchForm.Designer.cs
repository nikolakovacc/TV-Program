namespace TVProgram.Foorms
{
    partial class SearchForm
    {
        private const string V = "SearchForm";

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            panel1 = new Panel();
            label9 = new Label();
            typeBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            endTimeTextBox = new TextBox();
            startTimeTextBox = new TextBox();
            label6 = new Label();
            favoriteCheckBox = new CheckBox();
            nameBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            channelLabel = new Label();
            authorBox = new TextBox();
            channelBox = new TextBox();
            dayBox = new TextBox();
            searchButton = new Button();
            label2 = new Label();
            label3 = new Label();
            timeBox = new TextBox();
            genreBox = new TextBox();
            idBox = new TextBox();
            label1 = new Label();
            showsBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            channelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            showsBindingSource1 = new BindingSource(components);
            closeButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(endTimeTextBox);
            panel1.Controls.Add(startTimeTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(favoriteCheckBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(channelLabel);
            panel1.Controls.Add(authorBox);
            panel1.Controls.Add(channelBox);
            panel1.Controls.Add(dayBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(timeBox);
            panel1.Controls.Add(genreBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(52, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 234);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(9, 148);
            label9.Name = "label9";
            label9.Size = new Size(36, 21);
            label9.TabIndex = 20;
            label9.Text = "Тип";
            // 
            // typeBox
            // 
            typeBox.Location = new Point(67, 146);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(145, 23);
            typeBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(378, 184);
            label8.Name = "label8";
            label8.Size = new Size(30, 21);
            label8.TabIndex = 19;
            label8.Text = "До";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(218, 184);
            label7.Name = "label7";
            label7.Size = new Size(32, 21);
            label7.TabIndex = 14;
            label7.Text = "Від";
            // 
            // endTimeTextBox
            // 
            endTimeTextBox.Location = new Point(414, 182);
            endTimeTextBox.Name = "endTimeTextBox";
            endTimeTextBox.Size = new Size(100, 23);
            endTimeTextBox.TabIndex = 18;
            // 
            // startTimeTextBox
            // 
            startTimeTextBox.Location = new Point(256, 183);
            startTimeTextBox.Name = "startTimeTextBox";
            startTimeTextBox.Size = new Size(100, 23);
            startTimeTextBox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(9, 52);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 16;
            label6.Text = "Назва";
            // 
            // favoriteCheckBox
            // 
            favoriteCheckBox.AutoSize = true;
            favoriteCheckBox.Font = new Font("Segoe UI", 12F);
            favoriteCheckBox.Location = new Point(586, 140);
            favoriteCheckBox.Name = "favoriteCheckBox";
            favoriteCheckBox.Size = new Size(135, 25);
            favoriteCheckBox.TabIndex = 15;
            favoriteCheckBox.Text = "Улюблене шоу";
            favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(67, 52);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(258, 23);
            nameBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(218, 148);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 12;
            label5.Text = "Точний час";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(346, 54);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 11;
            label4.Text = "День";
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Font = new Font("Segoe UI", 12F);
            channelLabel.Location = new Point(346, 98);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(52, 21);
            channelLabel.TabIndex = 10;
            channelLabel.Text = "Канал";
            // 
            // authorBox
            // 
            authorBox.Location = new Point(419, 12);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(306, 23);
            authorBox.TabIndex = 6;
            // 
            // channelBox
            // 
            channelBox.Location = new Point(419, 96);
            channelBox.Name = "channelBox";
            channelBox.Size = new Size(306, 23);
            channelBox.TabIndex = 9;
            // 
            // dayBox
            // 
            dayBox.Location = new Point(419, 50);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(306, 23);
            dayBox.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(650, 182);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(346, 14);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 4;
            label3.Text = "Жанр";
            // 
            // timeBox
            // 
            timeBox.Location = new Point(315, 148);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(258, 23);
            timeBox.TabIndex = 3;
            // 
            // genreBox
            // 
            genreBox.Location = new Point(67, 96);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(258, 23);
            genreBox.TabIndex = 2;
            // 
            // idBox
            // 
            idBox.Location = new Point(67, 10);
            idBox.Name = "idBox";
            idBox.Size = new Size(258, 23);
            idBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // showsBindingSource
            // 
            showsBindingSource.DataSource = typeof(Models.Shows);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Name, channelDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, dayDataGridViewTextBoxColumn, authorsDataGridViewTextBoxColumn, Type });
            dataGridView1.DataSource = showsBindingSource;
            dataGridView1.Location = new Point(52, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 173);
            dataGridView1.TabIndex = 4;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 25;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Назва";
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 120;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            channelDataGridViewTextBoxColumn.HeaderText = "Канал";
            channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            channelDataGridViewTextBoxColumn.ReadOnly = true;
            channelDataGridViewTextBoxColumn.Width = 80;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.ReadOnly = true;
            genreDataGridViewTextBoxColumn.Width = 120;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Час";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.ReadOnly = true;
            timeDataGridViewTextBoxColumn.Width = 80;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "День";
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.HeaderText = "Автор";
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            authorsDataGridViewTextBoxColumn.ReadOnly = true;
            authorsDataGridViewTextBoxColumn.Width = 120;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Тип";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 60;
            // 
            // showsBindingSource1
            // 
            showsBindingSource1.DataSource = typeof(Models.Shows);
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top;
            closeButton.Location = new Point(721, 455);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 11;
            closeButton.Text = "Закрити ";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 498);
            Controls.Add(closeButton);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1053, 585);
            MinimumSize = new Size(846, 537);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пошук за фільтрами";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label channelLabel;
        private TextBox channelBox;
        private TextBox dayBox;
        private TextBox authorBox;
        private Button searchButton;
        private Label label2;
        private Label label3;
        private TextBox timeBox;
        private TextBox genreBox;
        private TextBox idBox;
        private Label label1;
        private BindingSource showsBindingSource;
        private DataGridView dataGridView1;
        private Button closeButton;
        private BindingSource showsBindingSource1;
        private Label label5;
        private Label label4;
        private TextBox nameBox;
        private CheckBox favoriteCheckBox;
        private Label label6;
        private TextBox endTimeTextBox;
        private TextBox startTimeTextBox;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox typeBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Type;
    }
}