namespace Auto_TransportationClient.AdminView.FuelView;

partial class FuelAdd
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
        numericUpDown1 = new NumericUpDown();
        label = new Label();
        buttonBack = new Button();
        labelBrand = new Label();
        buttonAdd = new Button();
        labelType = new Label();
        labelPrice = new Label();
        textBoxBrand = new TextBox();
        textBoxType = new TextBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ControlLightLight;
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelBrand);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(labelType);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(textBoxBrand);
        groupBox1.Controls.Add(textBoxType);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 2;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDown1.Location = new Point(23, 210);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(291, 29);
        numericUpDown1.TabIndex = 26;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 12);
        label.Name = "label";
        label.Size = new Size(122, 37);
        label.TabIndex = 13;
        label.Text = "Add Fuel";
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
        labelBrand.Location = new Point(23, 74);
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
        buttonAdd.Location = new Point(234, 552);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 24;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // labelType
        // 
        labelType.AutoSize = true;
        labelType.Font = new Font("Segoe UI", 12F);
        labelType.Location = new Point(23, 130);
        labelType.Name = "labelType";
        labelType.Size = new Size(45, 21);
        labelType.TabIndex = 15;
        labelType.Text = "Type:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(23, 186);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 16;
        labelPrice.Text = "Price:";
        // 
        // textBoxBrand
        // 
        textBoxBrand.Font = new Font("Segoe UI", 12F);
        textBoxBrand.Location = new Point(23, 98);
        textBoxBrand.Name = "textBoxBrand";
        textBoxBrand.Size = new Size(291, 29);
        textBoxBrand.TabIndex = 20;
        // 
        // textBoxType
        // 
        textBoxType.Font = new Font("Segoe UI", 12F);
        textBoxType.Location = new Point(23, 154);
        textBoxType.Name = "textBoxType";
        textBoxType.Size = new Size(291, 29);
        textBoxType.TabIndex = 19;
        // 
        // FuelAdd
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "FuelAdd";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label;
    private Button buttonBack;
    private Label labelBrand;
    private Button buttonAdd;
    private Label labelType;
    private TextBox textBoxBrand;
    private TextBox textBoxType;
    private NumericUpDown numericUpDown1;
    private Label labelPrice;
}
