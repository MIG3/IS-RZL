namespace Ф_ИС_ЕРЗ
{
    partial class DeleteUser
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
            this.Фамилия = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ввести = new System.Windows.Forms.Button();
            this.ФамилияУд = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.TextBox();
            this.ОтчествоУд = new System.Windows.Forms.TextBox();
            this.ИмяУд = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSize = true;
            this.Фамилия.Location = new System.Drawing.Point(86, 9);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(70, 17);
            this.Фамилия.TabIndex = 0;
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // Ввести
            // 
            this.Ввести.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ввести.Location = new System.Drawing.Point(274, 98);
            this.Ввести.Name = "Ввести";
            this.Ввести.Size = new System.Drawing.Size(89, 40);
            this.Ввести.TabIndex = 18;
            this.Ввести.Text = "Удалить";
            this.Ввести.UseVisualStyleBackColor = true;
            this.Ввести.Click += new System.EventHandler(this.Ввести_Click);
            // 
            // ФамилияУд
            // 
            this.ФамилияУд.Location = new System.Drawing.Point(162, 6);
            this.ФамилияУд.Name = "ФамилияУд";
            this.ФамилияУд.Size = new System.Drawing.Size(193, 22);
            this.ФамилияУд.TabIndex = 11;
            this.ФамилияУд.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Имя
            // 
            this.Имя.Location = new System.Drawing.Point(162, 35);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(193, 22);
            this.Имя.TabIndex = 12;
            this.Имя.TextChanged += new System.EventHandler(this.Имя_TextChanged);
            // 
            // ОтчествоУд
            // 
            this.ОтчествоУд.Location = new System.Drawing.Point(162, 63);
            this.ОтчествоУд.Name = "ОтчествоУд";
            this.ОтчествоУд.Size = new System.Drawing.Size(193, 22);
            this.ОтчествоУд.TabIndex = 13;
            this.ОтчествоУд.TextChanged += new System.EventHandler(this.Отчество_TextChanged);
            // 
            // ИмяУд
            // 
            this.ИмяУд.Location = new System.Drawing.Point(162, 35);
            this.ИмяУд.Name = "ИмяУд";
            this.ИмяУд.Size = new System.Drawing.Size(193, 22);
            this.ИмяУд.TabIndex = 12;
            this.ИмяУд.TextChanged += new System.EventHandler(this.Имя_TextChanged);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 150);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ввести);
            this.Controls.Add(this.ФамилияУд);
            this.Controls.Add(this.ИмяУд);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.ОтчествоУд);
            this.Name = "DeleteUser";
            this.Text = "Удаление пользователя";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ввести;
        protected internal System.Windows.Forms.TextBox ФамилияУд;
        protected internal System.Windows.Forms.TextBox Имя;
        protected internal System.Windows.Forms.TextBox ОтчествоУд;
        protected internal System.Windows.Forms.TextBox ИмяУд;
    }
}