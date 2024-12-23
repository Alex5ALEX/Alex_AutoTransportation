﻿namespace Auto_TransportationClient.CustomerView
{
    partial class CatalogControl
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
            pictureBox1 = new PictureBox();
            flowLayoutPanelFuel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 30F);
            labelMenuName.Location = new Point(89, 4);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(159, 54);
            labelMenuName.TabIndex = 18;
            labelMenuName.Text = "Catalog";
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ControlLightLight;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 55);
            buttonMenu.TabIndex = 17;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Fuel;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(63, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelFuel
            // 
            flowLayoutPanelFuel.AutoScroll = true;
            flowLayoutPanelFuel.Location = new Point(350, 86);
            flowLayoutPanelFuel.Name = "flowLayoutPanelFuel";
            flowLayoutPanelFuel.Size = new Size(890, 590);
            flowLayoutPanelFuel.TabIndex = 0;
            // 
            // CatalogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(flowLayoutPanelFuel);
            Controls.Add(pictureBox1);
            Controls.Add(labelMenuName);
            Controls.Add(buttonMenu);
            Name = "CatalogControl";
            Size = new Size(1260, 680);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuName;
        private Button buttonMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanelFuel;
        private FlowLayoutPanel flowLayoutPanelServices;
    }
}
