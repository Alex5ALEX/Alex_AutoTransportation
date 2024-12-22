namespace Auto_TransportationClient.AdminView.FuelView;

partial class FuelRow
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
        label10 = new Label();
        label7 = new Label();
        label8 = new Label();
        label4 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(873, 100);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 12F);
        label10.Location = new Point(465, 19);
        label10.Name = "label10";
        label10.Size = new Size(53, 21);
        label10.TabIndex = 11;
        label10.Text = "text10";
        label10.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(95, 19);
        label7.Name = "label7";
        label7.Size = new Size(44, 21);
        label7.TabIndex = 8;
        label7.Text = "text7";
        label7.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F);
        label8.Location = new Point(95, 53);
        label8.Name = "label8";
        label8.Size = new Size(44, 21);
        label8.TabIndex = 7;
        label8.Text = "text8";
        label8.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(388, 19);
        label4.Name = "label4";
        label4.Size = new Size(45, 21);
        label4.TabIndex = 3;
        label4.Text = "Type:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(6, 53);
        label2.Name = "label2";
        label2.Size = new Size(47, 21);
        label2.TabIndex = 1;
        label2.Text = "Price:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(6, 19);
        label1.Name = "label1";
        label1.Size = new Size(54, 21);
        label1.TabIndex = 0;
        label1.Text = "Brand:";
        // 
        // FuelRow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "FuelRow";
        Size = new Size(873, 100);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label10;
    private Label label7;
    private Label label8;
    private Label label4;
    private Label label2;
    private Label label1;
}
