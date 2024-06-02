namespace TVProgram.Foorms
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            label1 = new Label();
            okButton = new Button();
            closeButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(151, 51);
            label1.Name = "label1";
            label1.Size = new Size(214, 28);
            label1.TabIndex = 0;
            label1.Text = "Введіть новий пароль";
            // 
            // okButton
            // 
            okButton.Location = new Point(338, 231);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "Відмінити";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(419, 231);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Ок";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 4;
            // 
            // changePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 266);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(closeButton);
            Controls.Add(okButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(523, 305);
            MinimumSize = new Size(523, 305);
            Name = "changePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Зміна пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button okButton;
        private Button closeButton;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}