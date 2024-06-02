namespace TVProgram.Foorms
{
    partial class Diya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diya));
            parentsButton = new Button();
            label1 = new Label();
            passwordTextBox = new TextBox();
            childButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // parentsButton
            // 
            parentsButton.Anchor = AnchorStyles.Top;
            parentsButton.Font = new Font("Segoe UI", 9F);
            parentsButton.Location = new Point(305, 286);
            parentsButton.Name = "parentsButton";
            parentsButton.Size = new Size(145, 45);
            parentsButton.TabIndex = 1;
            parentsButton.Text = "Переглянути всі шоу";
            parentsButton.UseVisualStyleBackColor = true;
            parentsButton.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(62, 24);
            label1.Name = "label1";
            label1.Size = new Size(388, 25);
            label1.TabIndex = 2;
            label1.Text = "Напишіть пароль щоб переглянути всі шоу";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top;
            passwordTextBox.Location = new Point(131, 70);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // childButton
            // 
            childButton.Anchor = AnchorStyles.Top;
            childButton.Location = new Point(43, 286);
            childButton.Name = "childButton";
            childButton.Size = new Size(145, 44);
            childButton.TabIndex = 4;
            childButton.Text = "Переглянути дитячі шоу";
            childButton.UseVisualStyleBackColor = true;
            childButton.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 145);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Diya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(492, 355);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(childButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(parentsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(508, 394);
            Name = "Diya";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пароль";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button parentsButton;
        private Label label1;
        private TextBox passwordTextBox;
        private Button childButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}