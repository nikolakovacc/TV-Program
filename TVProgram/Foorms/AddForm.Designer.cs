namespace TVProgram.Foorms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            addElButton = new Button();
            id2Box = new TextBox();
            channel2Box = new TextBox();
            genre2Box = new TextBox();
            time2Box = new TextBox();
            day2Box = new TextBox();
            author2Box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            typeBox = new TextBox();
            label7 = new Label();
            nameBox = new TextBox();
            backlButton = new Button();
            favoriteCheckBox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addElButton
            // 
            addElButton.Anchor = AnchorStyles.Top;
            addElButton.Location = new Point(533, 414);
            addElButton.Name = "addElButton";
            addElButton.Size = new Size(75, 23);
            addElButton.TabIndex = 0;
            addElButton.Text = "Додати шоу";
            addElButton.UseVisualStyleBackColor = true;
            addElButton.Click += addElButton_Click;
            // 
            // id2Box
            // 
            id2Box.Location = new Point(90, 12);
            id2Box.Name = "id2Box";
            id2Box.Size = new Size(481, 23);
            id2Box.TabIndex = 1;
            // 
            // channel2Box
            // 
            channel2Box.Location = new Point(90, 283);
            channel2Box.Name = "channel2Box";
            channel2Box.Size = new Size(481, 23);
            channel2Box.TabIndex = 2;
            // 
            // genre2Box
            // 
            genre2Box.Location = new Point(90, 99);
            genre2Box.Name = "genre2Box";
            genre2Box.Size = new Size(481, 23);
            genre2Box.TabIndex = 3;
            // 
            // time2Box
            // 
            time2Box.Location = new Point(90, 147);
            time2Box.Name = "time2Box";
            time2Box.Size = new Size(481, 23);
            time2Box.TabIndex = 4;
            // 
            // day2Box
            // 
            day2Box.Location = new Point(90, 195);
            day2Box.Name = "day2Box";
            day2Box.Size = new Size(481, 23);
            day2Box.TabIndex = 5;
            // 
            // author2Box
            // 
            author2Box.Location = new Point(90, 239);
            author2Box.Name = "author2Box";
            author2Box.Size = new Size(481, 23);
            author2Box.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 7;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(17, 285);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 8;
            label2.Text = "Канал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 101);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 9;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(17, 149);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 10;
            label4.Text = "Час";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(17, 195);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 11;
            label5.Text = "День";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 241);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 12;
            label6.Text = "Автор";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(author2Box);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(day2Box);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(time2Box);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(genre2Box);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(channel2Box);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(id2Box);
            panel1.Location = new Point(18, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 364);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(17, 329);
            label8.Name = "label8";
            label8.Size = new Size(36, 21);
            label8.TabIndex = 16;
            label8.Text = "Тип";
            // 
            // typeBox
            // 
            typeBox.Location = new Point(90, 329);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(481, 23);
            typeBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(17, 56);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 14;
            label7.Text = "Назва";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(90, 54);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(481, 23);
            nameBox.TabIndex = 13;
            // 
            // backlButton
            // 
            backlButton.Anchor = AnchorStyles.Top;
            backlButton.Location = new Point(452, 414);
            backlButton.Name = "backlButton";
            backlButton.Size = new Size(75, 23);
            backlButton.TabIndex = 14;
            backlButton.Text = "Відхилити";
            backlButton.UseVisualStyleBackColor = true;
            backlButton.Click += backlButton_Click;
            // 
            // favoriteCheckBox
            // 
            favoriteCheckBox.Anchor = AnchorStyles.Top;
            favoriteCheckBox.AutoSize = true;
            favoriteCheckBox.Location = new Point(35, 414);
            favoriteCheckBox.Name = "favoriteCheckBox";
            favoriteCheckBox.Size = new Size(83, 19);
            favoriteCheckBox.TabIndex = 15;
            favoriteCheckBox.Text = "Улюблене";
            favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 453);
            Controls.Add(favoriteCheckBox);
            Controls.Add(backlButton);
            Controls.Add(addElButton);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(647, 492);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання шоу";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addElButton;
        private TextBox id2Box;
        private TextBox channel2Box;
        private TextBox genre2Box;
        private TextBox time2Box;
        private TextBox day2Box;
        private TextBox author2Box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private TextBox nameBox;
        private Label label7;
        private Button backlButton;
        private CheckBox favoriteCheckBox;
        private Label label8;
        private TextBox typeBox;
    }
}