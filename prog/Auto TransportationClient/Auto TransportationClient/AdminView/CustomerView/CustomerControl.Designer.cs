namespace Auto_TransportationClient.AdminView.CustomerView;

partial class CustomerControl
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
        buttonMenu = new Button();
        groupBoxAction = new GroupBox();
        groupBox2 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonAdd = new Button();
        buttonEdit = new Button();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // buttonMenu
        // 
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 3);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(80, 50);
        buttonMenu.TabIndex = 0;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = true;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 62);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(340, 615);
        groupBoxAction.TabIndex = 1;
        groupBoxAction.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(flowLayoutPanel1);
        groupBox2.Location = new Point(349, 62);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(908, 615);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Location = new Point(9, 19);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(896, 593);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // buttonAdd
        // 
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(1159, 6);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(80, 50);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(1055, 6);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(80, 50);
        buttonEdit.TabIndex = 4;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 30F);
        label1.Location = new Point(89, 2);
        label1.Name = "label1";
        label1.Size = new Size(211, 54);
        label1.TabIndex = 5;
        label1.Text = "Customers";
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = Properties.Resources.customer;
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(20, 90);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(300, 300);
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // CustomerControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(buttonEdit);
        Controls.Add(buttonAdd);
        Controls.Add(groupBox2);
        Controls.Add(groupBoxAction);
        Controls.Add(buttonMenu);
        Name = "CustomerControl";
        Size = new Size(1260, 680);
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonMenu;
    private GroupBox groupBoxAction;
    private GroupBox groupBox2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button buttonAdd;
    private Button buttonEdit;
    private Label label1;
    private PictureBox pictureBox1;
}
