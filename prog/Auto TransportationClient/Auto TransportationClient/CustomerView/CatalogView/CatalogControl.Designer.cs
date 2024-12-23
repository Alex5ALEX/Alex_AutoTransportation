namespace Auto_TransportationClient.CustomerView
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
            pictureBox2 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanelProduct = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowLayoutPanelServices = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(63, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(63, 401);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 250);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(352, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 625);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanelProduct);
            tabPage1.Font = new Font("Segoe UI", 12F);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(897, 591);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProduct
            // 
            flowLayoutPanelProduct.AutoScroll = true;
            flowLayoutPanelProduct.Location = new Point(0, 0);
            flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            flowLayoutPanelProduct.Size = new Size(890, 590);
            flowLayoutPanelProduct.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanelServices);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(897, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Services";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServices
            // 
            flowLayoutPanelServices.AutoScroll = true;
            flowLayoutPanelServices.Location = new Point(0, 0);
            flowLayoutPanelServices.Name = "flowLayoutPanelServices";
            flowLayoutPanelServices.Size = new Size(890, 590);
            flowLayoutPanelServices.TabIndex = 0;
            // 
            // CatalogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMenuName);
            Controls.Add(buttonMenu);
            Name = "CatalogControl";
            Size = new Size(1260, 680);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanelProduct;
        private FlowLayoutPanel flowLayoutPanelServices;
    }
}
