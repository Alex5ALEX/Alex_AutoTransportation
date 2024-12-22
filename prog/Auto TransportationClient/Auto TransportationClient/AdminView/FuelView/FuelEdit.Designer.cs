namespace Auto_TransportationClient.AdminView.FuelView;

partial class FuelEdit
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
        groupBox2 = new GroupBox();
        numericUpDown1 = new NumericUpDown();
        label = new Label();
        labelBrand = new Label();
        labelType = new Label();
        buttonDelete = new Button();
        labelPrice = new Label();
        buttonBack = new Button();
        textBoxBrand = new TextBox();
        buttonEdit = new Button();
        textBoxType = new TextBox();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.BackColor = SystemColors.ControlLightLight;
        groupBox2.Controls.Add(numericUpDown1);
        groupBox2.Controls.Add(label);
        groupBox2.Controls.Add(labelBrand);
        groupBox2.Controls.Add(labelType);
        groupBox2.Controls.Add(buttonDelete);
        groupBox2.Controls.Add(labelPrice);
        groupBox2.Controls.Add(buttonBack);
        groupBox2.Controls.Add(textBoxBrand);
        groupBox2.Controls.Add(buttonEdit);
        groupBox2.Controls.Add(textBoxType);
        groupBox2.Location = new Point(0, 0);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(340, 615);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // numericUpDown1
        // 
        numericUpDown1.DecimalPlaces = 2;
        numericUpDown1.Font = new Font("Segoe UI", 12F);
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        numericUpDown1.Location = new Point(23, 186);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(291, 29);
        numericUpDown1.TabIndex = 32;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(3, 13);
        label.Name = "label";
        label.Size = new Size(119, 37);
        label.TabIndex = 39;
        label.Text = "Edit Fuel";
        // 
        // labelBrand
        // 
        labelBrand.AutoSize = true;
        labelBrand.Font = new Font("Segoe UI", 12F);
        labelBrand.Location = new Point(23, 50);
        labelBrand.Name = "labelBrand";
        labelBrand.Size = new Size(54, 21);
        labelBrand.TabIndex = 27;
        labelBrand.Text = "Brand:";
        // 
        // labelType
        // 
        labelType.AutoSize = true;
        labelType.Font = new Font("Segoe UI", 12F);
        labelType.Location = new Point(23, 106);
        labelType.Name = "labelType";
        labelType.Size = new Size(45, 21);
        labelType.TabIndex = 28;
        labelType.Text = "Type:";
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(120, 552);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(100, 50);
        buttonDelete.TabIndex = 42;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(23, 162);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 29;
        labelPrice.Text = "Price:";
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(3, 552);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 41;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // textBoxBrand
        // 
        textBoxBrand.Font = new Font("Segoe UI", 12F);
        textBoxBrand.Location = new Point(23, 74);
        textBoxBrand.Name = "textBoxBrand";
        textBoxBrand.Size = new Size(291, 29);
        textBoxBrand.TabIndex = 31;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(237, 552);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(100, 50);
        buttonEdit.TabIndex = 40;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // textBoxType
        // 
        textBoxType.Font = new Font("Segoe UI", 12F);
        textBoxType.Location = new Point(23, 130);
        textBoxType.Name = "textBoxType";
        textBoxType.Size = new Size(291, 29);
        textBoxType.TabIndex = 30;
        // 
        // FuelEdit
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox2);
        Name = "FuelEdit";
        Size = new Size(340, 615);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox2;
    private Label label;
    private Button buttonDelete;
    private Button buttonBack;
    private Button buttonEdit;
    private NumericUpDown numericUpDown1;
    private Label labelBrand;
    private Label labelType;
    private Label labelPrice;
    private TextBox textBoxBrand;
    private TextBox textBoxType;
}
