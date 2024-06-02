namespace TVProgram.Foorms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            bookBindingSource = new BindingSource(components);
            cancelButton = new Button();
            okButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            idsBox = new TextBox();
            genreBox = new TextBox();
            timesBox = new TextBox();
            channelBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            authorsBox = new TextBox();
            dayBox = new TextBox();
            nameBox = new TextBox();
            panel2 = new Panel();
            typeBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Shows);
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(8, 41);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Відхилити";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(8, 12);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "Зберегти";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(okButton);
            panel1.Location = new Point(664, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 89);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // idsBox
            // 
            idsBox.Enabled = false;
            idsBox.Location = new Point(0, -2);
            idsBox.Name = "idsBox";
            idsBox.Size = new Size(536, 23);
            idsBox.TabIndex = 4;
            // 
            // genreBox
            // 
            genreBox.Location = new Point(0, 159);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(536, 23);
            genreBox.TabIndex = 5;
            // 
            // timesBox
            // 
            timesBox.Location = new Point(0, 271);
            timesBox.Name = "timesBox";
            timesBox.Size = new Size(536, 23);
            timesBox.TabIndex = 6;
            // 
            // channelBox
            // 
            channelBox.Location = new Point(0, 100);
            channelBox.Name = "channelBox";
            channelBox.Size = new Size(536, 23);
            channelBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 171);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 8;
            label2.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 283);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 9;
            label3.Text = "Час";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 112);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 10;
            label4.Text = "Канал";
            // 
            // authorsBox
            // 
            authorsBox.Location = new Point(0, 212);
            authorsBox.Name = "authorsBox";
            authorsBox.Size = new Size(536, 23);
            authorsBox.TabIndex = 12;
            // 
            // dayBox
            // 
            dayBox.Location = new Point(0, 319);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(536, 23);
            dayBox.TabIndex = 13;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(0, 47);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(536, 23);
            nameBox.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(typeBox);
            panel2.Controls.Add(idsBox);
            panel2.Controls.Add(dayBox);
            panel2.Controls.Add(genreBox);
            panel2.Controls.Add(timesBox);
            panel2.Controls.Add(authorsBox);
            panel2.Controls.Add(channelBox);
            panel2.Location = new Point(105, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 390);
            panel2.TabIndex = 15;
            // 
            // typeBox
            // 
            typeBox.Location = new Point(0, 361);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(537, 23);
            typeBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 65);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 15;
            label5.Text = "Назва";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 220);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 16;
            label6.Text = "Автор";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 331);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 15;
            label7.Text = "День";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 403);
            panel3.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(18, 372);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 19;
            label8.Text = "Тип шоу";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 463);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(811, 502);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редагувати шоу";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bookBindingSource;
        private Button cancelButton;
        private Button okButton;
        private Panel panel1;
        private Label label1;
        private TextBox idsBox;
        private TextBox genreBox;
        private TextBox timesBox;
        private TextBox channelBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox authorsBox;
        private TextBox dayBox;
        private TextBox nameBox;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private TextBox typeBox;
        private Label label8;
    }
}