namespace Auto_TransportationClient.ViewReg
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 47);
            label1.TabIndex = 0;
            label1.Text = "Enterance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 129);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(39, 194);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F);
            textBoxLogin.Location = new Point(39, 153);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(232, 29);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Segoe UI", 12F);
            textBoxPass.Location = new Point(39, 218);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(232, 29);
            textBoxPass.TabIndex = 4;
            // 
            // buttonEnter
            // 
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI", 12F);
            buttonEnter.Location = new Point(203, 283);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(96, 48);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(311, 341);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private Button buttonEnter;
    }
}