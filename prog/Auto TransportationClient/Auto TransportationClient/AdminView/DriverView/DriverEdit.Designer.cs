namespace Auto_TransportationClient.AdminView.DriverView;

partial class DriverEdit
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
        buttonDelete = new Button();
        buttonBack = new Button();
        buttonEdit = new Button();
        label = new Label();
        labelName = new Label();
        labelSurname = new Label();
        textBoxAddres = new TextBox();
        labelPhone = new Label();
        textBoxEmail = new TextBox();
        labelEmail = new Label();
        textBoxPhone = new TextBox();
        labelAddres = new Label();
        textBoxName = new TextBox();
        textBoxSurname = new TextBox();
        groupBox2 = new GroupBox();
        label5 = new Label();
        label6 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        flowLayoutPanel1 = new FlowLayoutPanel();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxSurname);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(tabControl1);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(label);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 615);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(113, 552);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(90, 50);
        buttonDelete.TabIndex = 45;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(3, 552);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(90, 50);
        buttonBack.TabIndex = 44;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(224, 552);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(90, 50);
        buttonEdit.TabIndex = 43;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 12);
        label.Name = "label";
        label.Size = new Size(127, 37);
        label.TabIndex = 13;
        label.Text = "Edit Auto";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(23, 51);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 48;
        labelName.Text = "Name:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(23, 107);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(76, 21);
        labelSurname.TabIndex = 49;
        labelSurname.Text = "Surname:";
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(23, 299);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 57;
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(23, 163);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 50;
        labelPhone.Text = "Phone:";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(23, 243);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 56;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(23, 219);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 51;
        labelEmail.Text = "Email:";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(23, 187);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 55;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(23, 275);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 52;
        labelAddres.Text = "Addres:";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(23, 75);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 54;
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(23, 131);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(291, 29);
        textBoxSurname.TabIndex = 53;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(23, 334);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(291, 154);
        groupBox2.TabIndex = 47;
        groupBox2.TabStop = false;
        groupBox2.Text = "Auto";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(92, 111);
        label5.Name = "label5";
        label5.Size = new Size(0, 21);
        label5.TabIndex = 5;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(14, 111);
        label6.Name = "label6";
        label6.Size = new Size(75, 21);
        label6.TabIndex = 4;
        label6.Text = "Max Fuel:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(92, 71);
        label4.Name = "label4";
        label4.Size = new Size(0, 21);
        label4.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(14, 71);
        label3.Name = "label3";
        label3.Size = new Size(57, 21);
        label3.TabIndex = 2;
        label3.Text = "Model:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(92, 34);
        label2.Name = "label2";
        label2.Size = new Size(0, 21);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 30);
        label1.Name = "label1";
        label1.Size = new Size(54, 21);
        label1.TabIndex = 0;
        label1.Text = "Brand:";
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Font = new Font("Segoe UI", 12F);
        tabControl1.Location = new Point(327, 22);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(354, 580);
        tabControl1.TabIndex = 46;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(flowLayoutPanel1);
        tabPage1.Location = new Point(4, 30);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(346, 546);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Auto";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(0, -1);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(346, 547);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // DriverEdit
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "DriverEdit";
        Size = new Size(680, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label;
    private Button buttonDelete;
    private Button buttonBack;
    private Button buttonEdit;
    private Label labelName;
    private Label labelSurname;
    private TextBox textBoxAddres;
    private Label labelPhone;
    private TextBox textBoxEmail;
    private Label labelEmail;
    private TextBox textBoxPhone;
    private Label labelAddres;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
    private GroupBox groupBox2;
    private Label label5;
    private Label label6;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private FlowLayoutPanel flowLayoutPanel1;
}
