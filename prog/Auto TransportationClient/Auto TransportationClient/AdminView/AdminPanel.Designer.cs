namespace Auto_TransportationClient.AdminView;

partial class AdminPanel
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
        buttonMenu = new Button();
        groupBoxMenu = new GroupBox();
        optionAdmin = new Button();
        optionFuel = new Button();
        optionAuto = new Button();
        optionDriver = new Button();
        optionTransportations = new Button();
        optionReport = new Button();
        optionCustomer = new Button();
        labelMenu = new Label();
        labelHello = new Label();
        pictureBox1 = new PictureBox();
        groupBoxMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = SystemColors.ControlLightLight;
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 3);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(80, 50);
        buttonMenu.TabIndex = 0;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // groupBoxMenu
        // 
        groupBoxMenu.Controls.Add(optionAdmin);
        groupBoxMenu.Controls.Add(optionFuel);
        groupBoxMenu.Controls.Add(optionAuto);
        groupBoxMenu.Controls.Add(optionDriver);
        groupBoxMenu.Controls.Add(optionTransportations);
        groupBoxMenu.Controls.Add(optionReport);
        groupBoxMenu.Controls.Add(optionCustomer);
        groupBoxMenu.Controls.Add(labelMenu);
        groupBoxMenu.Location = new Point(0, 0);
        groupBoxMenu.Name = "groupBoxMenu";
        groupBoxMenu.Size = new Size(269, 677);
        groupBoxMenu.TabIndex = 1;
        groupBoxMenu.TabStop = false;
        // 
        // optionAdmin
        // 
        optionAdmin.BackColor = SystemColors.ControlLightLight;
        optionAdmin.FlatStyle = FlatStyle.Flat;
        optionAdmin.Font = new Font("Segoe UI", 12F);
        optionAdmin.Location = new Point(6, 565);
        optionAdmin.Name = "optionAdmin";
        optionAdmin.Size = new Size(257, 50);
        optionAdmin.TabIndex = 7;
        optionAdmin.Text = "Admin";
        optionAdmin.UseVisualStyleBackColor = false;
        // 
        // optionFuel
        // 
        optionFuel.BackColor = SystemColors.ControlLightLight;
        optionFuel.FlatStyle = FlatStyle.Flat;
        optionFuel.Font = new Font("Segoe UI", 12F);
        optionFuel.Location = new Point(6, 321);
        optionFuel.Name = "optionFuel";
        optionFuel.Size = new Size(257, 50);
        optionFuel.TabIndex = 6;
        optionFuel.Text = "Fuel";
        optionFuel.UseVisualStyleBackColor = false;
        // 
        // optionAuto
        // 
        optionAuto.BackColor = SystemColors.ControlLightLight;
        optionAuto.FlatStyle = FlatStyle.Flat;
        optionAuto.Font = new Font("Segoe UI", 12F);
        optionAuto.Location = new Point(6, 265);
        optionAuto.Name = "optionAuto";
        optionAuto.Size = new Size(257, 50);
        optionAuto.TabIndex = 5;
        optionAuto.Text = "Auto";
        optionAuto.UseVisualStyleBackColor = false;
        // 
        // optionDriver
        // 
        optionDriver.BackColor = SystemColors.ControlLightLight;
        optionDriver.FlatStyle = FlatStyle.Flat;
        optionDriver.Font = new Font("Segoe UI", 12F);
        optionDriver.Location = new Point(6, 209);
        optionDriver.Name = "optionDriver";
        optionDriver.Size = new Size(257, 50);
        optionDriver.TabIndex = 4;
        optionDriver.Text = "Drivers";
        optionDriver.UseVisualStyleBackColor = false;
        // 
        // optionTransportations
        // 
        optionTransportations.BackColor = SystemColors.ControlLightLight;
        optionTransportations.FlatStyle = FlatStyle.Flat;
        optionTransportations.Font = new Font("Segoe UI", 12F);
        optionTransportations.Location = new Point(6, 153);
        optionTransportations.Name = "optionTransportations";
        optionTransportations.Size = new Size(257, 50);
        optionTransportations.TabIndex = 3;
        optionTransportations.Text = "Transportations";
        optionTransportations.UseVisualStyleBackColor = false;
        // 
        // optionReport
        // 
        optionReport.BackColor = SystemColors.ControlLightLight;
        optionReport.FlatStyle = FlatStyle.Flat;
        optionReport.Font = new Font("Segoe UI", 12F);
        optionReport.Location = new Point(6, 621);
        optionReport.Name = "optionReport";
        optionReport.Size = new Size(257, 50);
        optionReport.TabIndex = 2;
        optionReport.Text = "Report";
        optionReport.UseVisualStyleBackColor = false;
        // 
        // optionCustomer
        // 
        optionCustomer.BackColor = SystemColors.ControlLightLight;
        optionCustomer.FlatStyle = FlatStyle.Flat;
        optionCustomer.Font = new Font("Segoe UI", 12F);
        optionCustomer.Location = new Point(6, 97);
        optionCustomer.Name = "optionCustomer";
        optionCustomer.Size = new Size(257, 50);
        optionCustomer.TabIndex = 1;
        optionCustomer.Text = "Customers";
        optionCustomer.UseVisualStyleBackColor = false;
        // 
        // labelMenu
        // 
        labelMenu.AutoSize = true;
        labelMenu.Font = new Font("Segoe UI", 24F);
        labelMenu.Location = new Point(6, 19);
        labelMenu.Name = "labelMenu";
        labelMenu.Size = new Size(102, 45);
        labelMenu.TabIndex = 0;
        labelMenu.Text = "Menu";
        // 
        // labelHello
        // 
        labelHello.AutoSize = true;
        labelHello.Font = new Font("Segoe UI", 30F);
        labelHello.Location = new Point(492, 93);
        labelHello.Name = "labelHello";
        labelHello.Size = new Size(246, 54);
        labelHello.TabIndex = 2;
        labelHello.Text = "Admin Panel";
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = Properties.Resources.admin;
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(414, 159);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(400, 400);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // AdminPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(1264, 681);
        Controls.Add(pictureBox1);
        Controls.Add(labelHello);
        Controls.Add(groupBoxMenu);
        Controls.Add(buttonMenu);
        Name = "AdminPanel";
        Text = "AdminPanel";
        groupBoxMenu.ResumeLayout(false);
        groupBoxMenu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonMenu;
    private GroupBox groupBoxMenu;
    private Label labelMenu;
    private Label labelHello;
    private Button optionFuel;
    private Button optionAuto;
    private Button optionDriver;
    private Button optionTransportations;
    private Button optionReport;
    private Button optionCustomer;
    private Button optionAdmin;
    private PictureBox pictureBox1;
}