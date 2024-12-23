namespace Auto_TransportationClient.AdminView.RowView;

partial class CustomerShortRow
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
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        label5 = new Label();
        label6 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(326, 130);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(98, 63);
        label4.Name = "label4";
        label4.Size = new Size(52, 21);
        label4.TabIndex = 3;
        label4.Text = "label4";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(16, 63);
        label3.Name = "label3";
        label3.Size = new Size(76, 21);
        label3.TabIndex = 2;
        label3.Text = "Surname:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(98, 29);
        label2.Name = "label2";
        label2.Size = new Size(52, 21);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(16, 29);
        label1.Name = "label1";
        label1.Size = new Size(55, 21);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(98, 97);
        label5.Name = "label5";
        label5.Size = new Size(52, 21);
        label5.TabIndex = 5;
        label5.Text = "label5";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(16, 97);
        label6.Name = "label6";
        label6.Size = new Size(57, 21);
        label6.TabIndex = 4;
        label6.Text = "Phone:";
        // 
        // CustomerShortRow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "CustomerShortRow";
        Size = new Size(326, 130);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label5;
    private Label label6;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
}
