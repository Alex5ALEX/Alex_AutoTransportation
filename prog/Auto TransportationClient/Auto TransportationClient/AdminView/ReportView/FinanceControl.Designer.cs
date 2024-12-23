namespace Auto_TransportationClient.AdminView.ReportView
{
    partial class FinanceControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1254, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(372, 75);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(876, 537);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(26, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(150, 94);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 73);
            label4.Name = "label4";
            label4.Size = new Size(121, 42);
            label4.TabIndex = 2;
            label4.Text = "Quantity of\nTransportations:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(93, 35);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "Profit:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 45);
            label1.TabIndex = 0;
            label1.Text = "Finance";
            // 
            // FinanceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "FinanceControl";
            Size = new Size(1254, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
