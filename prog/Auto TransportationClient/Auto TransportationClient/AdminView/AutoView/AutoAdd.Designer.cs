namespace Auto_TransportationClient.AdminView.AutoView;

partial class AutoAdd
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
        groupBox2 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        flowLayoutPanel1 = new FlowLayoutPanel();
        numericUpDown1 = new NumericUpDown();
        label = new Label();
        buttonBack = new Button();
        labelBrand = new Label();
        buttonAdd = new Button();
        labelModel = new Label();
        labelMaxFuel = new Label();
        textBoxBrand = new TextBox();
        textBoxModel = new TextBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(tabControl1);
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelBrand);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(labelModel);
        groupBox1.Controls.Add(labelMaxFuel);
        groupBox1.Controls.Add(textBoxBrand);
        groupBox1.Controls.Add(textBoxModel);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 615);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(23, 244);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(291, 126);
        groupBox2.TabIndex = 34;
        groupBox2.TabStop = false;
        groupBox2.Text = "Fuel";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(79, 77);
        label4.Name = "label4";
        label4.Size = new Size(0, 21);
        label4.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(21, 77);
        label3.Name = "label3";
        label3.Size = new Size(45, 21);
        label3.TabIndex = 2;
        label3.Text = "Type:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(79, 33);
        label2.Name = "label2";
        label2.Size = new Size(0, 21);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 33);
        label1.Name = "label1";
        label1.Size = new Size(54, 21);
        label1.TabIndex = 0;
        label1.Text = "Brand:";
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Font = new Font("Segoe UI", 12F);
        tabControl1.Location = new Point(320, 22);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(354, 580);
        tabControl1.TabIndex = 33;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(flowLayoutPanel1);
        tabPage1.Location = new Point(4, 30);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(346, 546);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Fuel";
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
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 2;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDown1.Location = new Point(23, 188);
        numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(291, 29);
        numericUpDown1.TabIndex = 30;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 12);
        label.Name = "label";
        label.Size = new Size(130, 37);
        label.TabIndex = 13;
        label.Text = "Add Auto";
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 552);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // labelBrand
        // 
        labelBrand.AutoSize = true;
        labelBrand.Font = new Font("Segoe UI", 12F);
        labelBrand.Location = new Point(23, 51);
        labelBrand.Name = "labelBrand";
        labelBrand.Size = new Size(54, 21);
        labelBrand.TabIndex = 14;
        labelBrand.Text = "Brand:";
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(214, 552);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 24;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // labelModel
        // 
        labelModel.AutoSize = true;
        labelModel.Font = new Font("Segoe UI", 12F);
        labelModel.Location = new Point(23, 107);
        labelModel.Name = "labelModel";
        labelModel.Size = new Size(57, 21);
        labelModel.TabIndex = 15;
        labelModel.Text = "Model:";
        // 
        // labelMaxFuel
        // 
        labelMaxFuel.AutoSize = true;
        labelMaxFuel.Font = new Font("Segoe UI", 12F);
        labelMaxFuel.Location = new Point(23, 163);
        labelMaxFuel.Name = "labelMaxFuel";
        labelMaxFuel.Size = new Size(145, 21);
        labelMaxFuel.TabIndex = 16;
        labelMaxFuel.Text = "Max Transport Fuel:";
        // 
        // textBoxBrand
        // 
        textBoxBrand.Font = new Font("Segoe UI", 12F);
        textBoxBrand.Location = new Point(23, 75);
        textBoxBrand.Name = "textBoxBrand";
        textBoxBrand.Size = new Size(291, 29);
        textBoxBrand.TabIndex = 20;
        // 
        // textBoxModel
        // 
        textBoxModel.Font = new Font("Segoe UI", 12F);
        textBoxModel.Location = new Point(23, 131);
        textBoxModel.Name = "textBoxModel";
        textBoxModel.Size = new Size(291, 29);
        textBoxModel.TabIndex = 19;
        // 
        // AutoAdd
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "AutoAdd";
        Size = new Size(680, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label;
    private Button buttonBack;
    private Label labelBrand;
    private Button buttonAdd;
    private Label labelModel;
    private Label labelMaxFuel;
    private TextBox textBoxBrand;
    private TextBox textBoxModel;
    private NumericUpDown numericUpDown1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox groupBox2;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private FlowLayoutPanel flowLayoutPanel1;
}
