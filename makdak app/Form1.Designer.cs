namespace makdak_app
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_client = new System.Windows.Forms.GroupBox();
            this.complainZINA_but = new System.Windows.Forms.Button();
            this.order_but = new System.Windows.Forms.Button();
            this.groupBox_admin = new System.Windows.Forms.GroupBox();
            this.leave_rus = new System.Windows.Forms.Button();
            this.admin_men_but = new System.Windows.Forms.Button();
            this.pass_input = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.Label();
            this.pass_confirm_but = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.groupBox_client.SuspendLayout();
            this.groupBox_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_client
            // 
            this.groupBox_client.Controls.Add(this.complainZINA_but);
            this.groupBox_client.Controls.Add(this.order_but);
            this.groupBox_client.Location = new System.Drawing.Point(271, 12);
            this.groupBox_client.Name = "groupBox_client";
            this.groupBox_client.Size = new System.Drawing.Size(98, 214);
            this.groupBox_client.TabIndex = 1;
            this.groupBox_client.TabStop = false;
            this.groupBox_client.Text = "CLIENT";
            // 
            // complainZINA_but
            // 
            this.complainZINA_but.Location = new System.Drawing.Point(6, 119);
            this.complainZINA_but.Name = "complainZINA_but";
            this.complainZINA_but.Size = new System.Drawing.Size(85, 80);
            this.complainZINA_but.TabIndex = 1;
            this.complainZINA_but.Text = "Жалоба на уборщицу Бабу Зину";
            this.complainZINA_but.UseVisualStyleBackColor = true;
            this.complainZINA_but.Click += new System.EventHandler(this.complainZINA_but_Click);
            // 
            // order_but
            // 
            this.order_but.Location = new System.Drawing.Point(6, 19);
            this.order_but.Name = "order_but";
            this.order_but.Size = new System.Drawing.Size(85, 80);
            this.order_but.TabIndex = 0;
            this.order_but.Text = "Сделать заказ";
            this.order_but.UseVisualStyleBackColor = true;
            this.order_but.Click += new System.EventHandler(this.order_but_Click);
            // 
            // groupBox_admin
            // 
            this.groupBox_admin.Controls.Add(this.leave_rus);
            this.groupBox_admin.Controls.Add(this.admin_men_but);
            this.groupBox_admin.Location = new System.Drawing.Point(375, 72);
            this.groupBox_admin.Name = "groupBox_admin";
            this.groupBox_admin.Size = new System.Drawing.Size(161, 154);
            this.groupBox_admin.TabIndex = 2;
            this.groupBox_admin.TabStop = false;
            this.groupBox_admin.Text = "ADMIN";
            this.groupBox_admin.Visible = false;
            // 
            // leave_rus
            // 
            this.leave_rus.Location = new System.Drawing.Point(7, 84);
            this.leave_rus.Name = "leave_rus";
            this.leave_rus.Size = new System.Drawing.Size(148, 64);
            this.leave_rus.TabIndex = 1;
            this.leave_rus.Text = "Уйти из России";
            this.leave_rus.UseVisualStyleBackColor = true;
            this.leave_rus.Click += new System.EventHandler(this.leave_rus_Click);
            // 
            // admin_men_but
            // 
            this.admin_men_but.Location = new System.Drawing.Point(6, 19);
            this.admin_men_but.Name = "admin_men_but";
            this.admin_men_but.Size = new System.Drawing.Size(148, 64);
            this.admin_men_but.TabIndex = 0;
            this.admin_men_but.Text = "Заказы";
            this.admin_men_but.UseVisualStyleBackColor = true;
            this.admin_men_but.Click += new System.EventHandler(this.admin_men_but_Click);
            // 
            // pass_input
            // 
            this.pass_input.Location = new System.Drawing.Point(375, 45);
            this.pass_input.Name = "pass_input";
            this.pass_input.Size = new System.Drawing.Size(100, 20);
            this.pass_input.TabIndex = 3;
            // 
            // text_pass
            // 
            this.text_pass.AutoSize = true;
            this.text_pass.Location = new System.Drawing.Point(376, 26);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(142, 13);
            this.text_pass.TabIndex = 4;
            this.text_pass.Text = "Admin password: (ваша з/п)";
            // 
            // pass_confirm_but
            // 
            this.pass_confirm_but.Location = new System.Drawing.Point(481, 43);
            this.pass_confirm_but.Name = "pass_confirm_but";
            this.pass_confirm_but.Size = new System.Drawing.Size(32, 23);
            this.pass_confirm_but.TabIndex = 5;
            this.pass_confirm_but.Text = "OK";
            this.pass_confirm_but.UseVisualStyleBackColor = true;
            this.pass_confirm_but.Click += new System.EventHandler(this.pass_confirm_but_Click);
            // 
            // logo
            // 
            this.logo.Image = global::makdak_app.Properties.Resources.maklogo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 214);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 264);
            this.Controls.Add(this.pass_confirm_but);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.pass_input);
            this.Controls.Add(this.groupBox_admin);
            this.Controls.Add(this.groupBox_client);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Welcome!";
            this.groupBox_client.ResumeLayout(false);
            this.groupBox_admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox_client;
        private System.Windows.Forms.GroupBox groupBox_admin;
        private System.Windows.Forms.Button complainZINA_but;
        private System.Windows.Forms.Button order_but;
        private System.Windows.Forms.TextBox pass_input;
        private System.Windows.Forms.Label text_pass;
        private System.Windows.Forms.Button pass_confirm_but;
        private System.Windows.Forms.Button admin_men_but;
        private System.Windows.Forms.Button leave_rus;
    }
}

