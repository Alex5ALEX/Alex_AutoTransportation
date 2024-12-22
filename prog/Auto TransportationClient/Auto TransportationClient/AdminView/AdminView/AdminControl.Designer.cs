namespace Auto_TransportationClient.AdminView.AdminView;

partial class AdminControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
        groupBox2 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        groupBoxAction = new GroupBox();
        buttonMenu = new Button();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        buttonEdit = new Button();
        buttonAdd = new Button();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(flowLayoutPanel1);
        groupBox2.Location = new Point(349, 63);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(908, 615);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Location = new Point(9, 19);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(896, 593);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(3, 63);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(340, 615);
        groupBoxAction.TabIndex = 8;
        groupBoxAction.TabStop = false;
        // 
        // buttonMenu
        // 
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(3, 4);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(80, 50);
        buttonMenu.TabIndex = 7;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(20, 91);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(300, 300);
        pictureBox1.TabIndex = 13;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 30F);
        label1.Location = new Point(89, 3);
        label1.Name = "label1";
        label1.Size = new Size(157, 54);
        label1.TabIndex = 12;
        label1.Text = "Admins";
        // 
        // buttonEdit
        // 
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(1055, 7);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(80, 50);
        buttonEdit.TabIndex = 11;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // buttonAdd
        // 
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(1159, 7);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(80, 50);
        buttonAdd.TabIndex = 10;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // AdminControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox2);
        Controls.Add(buttonMenu);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(buttonEdit);
        Controls.Add(buttonAdd);
        Controls.Add(groupBoxAction);
        Name = "AdminControl";
        Size = new Size(1260, 680);
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox2;
    private FlowLayoutPanel flowLayoutPanel1;
    private GroupBox groupBoxAction;
    private Button buttonMenu;
    private PictureBox pictureBox1;
    private Label label1;
    private Button buttonEdit;
    private Button buttonAdd;
}
