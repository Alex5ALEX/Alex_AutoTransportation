namespace Auto_TransportationClient.AdminView.ReportView
{
    partial class ReportControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelMenuName = new Label();
            buttonMenu = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 30F);
            labelMenuName.Location = new Point(89, 3);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(142, 54);
            labelMenuName.TabIndex = 17;
            labelMenuName.Text = "Report";
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ControlLightLight;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 55);
            buttonMenu.TabIndex = 16;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1254, 615);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(297, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 50);
            button1.TabIndex = 19;
            button1.Text = "Finance";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(399, 3);
            button2.Name = "button2";
            button2.Size = new Size(80, 50);
            button2.TabIndex = 20;
            button2.Text = "Statistic";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1177, 3);
            button3.Name = "button3";
            button3.Size = new Size(80, 50);
            button3.TabIndex = 22;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.report;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(460, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(buttonMenu);
            Controls.Add(labelMenuName);
            Name = "ReportControl";
            Size = new Size(1260, 680);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuName;
        private Button buttonMenu;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
