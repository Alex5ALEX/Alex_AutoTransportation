namespace Auto_TransportationClient.CustomerView
{
    partial class ServicesCatalogControl
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
            groupBox1 = new GroupBox();
            richTextBoxDescription = new RichTextBox();
            labelPriceText = new Label();
            labelPrice = new Label();
            labelDescription = new Label();
            labelNameText = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(richTextBoxDescription);
            groupBox1.Controls.Add(labelPriceText);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(labelNameText);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(6, 123);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(415, 171);
            richTextBoxDescription.TabIndex = 14;
            richTextBoxDescription.Text = "";
            // 
            // labelPriceText
            // 
            labelPriceText.AutoSize = true;
            labelPriceText.Font = new Font("Segoe UI", 12F);
            labelPriceText.Location = new Point(66, 57);
            labelPriceText.Name = "labelPriceText";
            labelPriceText.Size = new Size(84, 21);
            labelPriceText.TabIndex = 13;
            labelPriceText.Text = "TEXT_Price";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(5, 57);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 21);
            labelPrice.TabIndex = 12;
            labelPrice.Text = "Price:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(6, 99);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 21);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "Decription:";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F);
            labelNameText.Location = new Point(66, 19);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(94, 21);
            labelNameText.TabIndex = 10;
            labelNameText.Text = "TEXT_NAME";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(5, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 8;
            labelName.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(309, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 98);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // ServicesCatalogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "ServicesCatalogControl";
            Size = new Size(427, 300);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPriceText;
        private Label labelPrice;
        private Label labelDescription;
        private Label labelNameText;
        private Label labelName;
        private RichTextBox richTextBoxDescription;
        private PictureBox pictureBox1;
    }
}
