namespace makdak_app
{
    partial class Order_popup
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
            this.labelcnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelcnt
            // 
            this.labelcnt.AutoSize = true;
            this.labelcnt.Font = new System.Drawing.Font("Press Start 2P", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcnt.Location = new System.Drawing.Point(59, 162);
            this.labelcnt.Name = "labelcnt";
            this.labelcnt.Size = new System.Drawing.Size(229, 88);
            this.labelcnt.TabIndex = 0;
            this.labelcnt.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Спасибо!\r\n\r\nВаш номер заказа:\r\n";
            // 
            // Order_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcnt);
            this.Name = "Order_popup";
            this.Text = "Order_popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcnt;
        private System.Windows.Forms.Label label1;
    }
}