namespace TVProgram.Foorms
{
    partial class PlanForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanForm));
            dataGridView1 = new DataGridView();
            showsBindingSource = new BindingSource(components);
            addButton = new Button();
            planListBox = new ListBox();
            searchButton = new Button();
            deleteButton = new Button();
            saveAsButton = new Button();
            button1 = new Button();
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            channelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            authorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, channelDataGridViewTextBoxColumn, dayDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, Type, authorsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = showsBindingSource;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.Size = new Size(491, 412);
            dataGridView1.TabIndex = 2;
            // 
            // showsBindingSource
            // 
            showsBindingSource.DataSource = typeof(Models.Shows);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top;
            addButton.Location = new Point(533, 430);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // planListBox
            // 
            planListBox.Anchor = AnchorStyles.Top;
            planListBox.Font = new Font("Segoe UI", 10F);
            planListBox.FormattingEnabled = true;
            planListBox.ItemHeight = 17;
            planListBox.Location = new Point(510, 12);
            planListBox.Name = "planListBox";
            planListBox.Size = new Size(439, 412);
            planListBox.TabIndex = 4;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top;
            searchButton.Location = new Point(13, 430);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top;
            deleteButton.Location = new Point(614, 430);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(82, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.Anchor = AnchorStyles.Top;
            saveAsButton.Location = new Point(864, 430);
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(85, 23);
            saveAsButton.TabIndex = 7;
            saveAsButton.Text = "Зберегти як";
            saveAsButton.UseVisualStyleBackColor = true;
            saveAsButton.Click += saveAsButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(118, 431);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 8;
            button1.Text = "Пошук за каналом";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Anchor = AnchorStyles.Top;
            domainUpDown1.Items.Add("Nickelodeon");
            domainUpDown1.Items.Add("Dream Works");
            domainUpDown1.Items.Add("Disney");
            domainUpDown1.Items.Add("Plus Plus");
            domainUpDown1.Items.Add("Cartoon Network");
            domainUpDown1.Items.Add("Eurosport");
            domainUpDown1.Items.Add("MTV Hits");
            domainUpDown1.Items.Add("1+1");
            domainUpDown1.Items.Add("BBC News");
            domainUpDown1.Items.Add("VIASAT KINO");
            domainUpDown1.Location = new Point(263, 433);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(241, 23);
            domainUpDown1.TabIndex = 9;
            domainUpDown1.Text = "Обрати канал  для пошуку";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Anchor = AnchorStyles.Top;
            domainUpDown2.Items.Add("Nickelodeon");
            domainUpDown2.Items.Add("Dream Works");
            domainUpDown2.Items.Add("Disney");
            domainUpDown2.Items.Add("Plus Plus");
            domainUpDown2.Items.Add("Cartoon Network");
            domainUpDown2.Location = new Point(263, 430);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(241, 23);
            domainUpDown2.TabIndex = 10;
            domainUpDown2.Text = "Обрати канал  для пошуку";
            domainUpDown2.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 25;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            channelDataGridViewTextBoxColumn.HeaderText = "Канал";
            channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            channelDataGridViewTextBoxColumn.Width = 80;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "День";
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Час";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 60;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.Width = 80;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Тип";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 60;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            authorsDataGridViewTextBoxColumn.HeaderText = "Автор";
            authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            authorsDataGridViewTextBoxColumn.Width = 80;
            // 
            // PlanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 466);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(saveAsButton);
            Controls.Add(deleteButton);
            Controls.Add(searchButton);
            Controls.Add(planListBox);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(981, 505);
            Name = "PlanForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Планування";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource showsBindingSource;
        private Button addButton;
        private ListBox planListBox;
        private Button searchButton;
        private Button deleteButton;
        private Button saveAsButton;
        private Button button1;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
    }
}