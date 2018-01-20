namespace Ф_ИС_ЕРЗ
{
    partial class UpdateFIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ИзменитьПаДан = new System.Windows.Forms.Button();
            this.НоваяФамилия = new System.Windows.Forms.TextBox();
            this.НовоеИмя = new System.Windows.Forms.TextBox();
            this.НовОтчество = new System.Windows.Forms.TextBox();
            this.Серия = new System.Windows.Forms.TextBox();
            this.Номер = new System.Windows.Forms.TextBox();
            this.NewSecondName = new System.Windows.Forms.TextBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewThirdName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSize = true;
            this.Фамилия.Location = new System.Drawing.Point(94, 38);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(70, 17);
            this.Фамилия.TabIndex = 0;
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите ваши персональные данные:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите что хотите изменить";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Данные паспорта";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ФИО";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ИзменитьПаДан
            // 
            this.ИзменитьПаДан.Location = new System.Drawing.Point(284, 312);
            this.ИзменитьПаДан.Name = "ИзменитьПаДан";
            this.ИзменитьПаДан.Size = new System.Drawing.Size(88, 23);
            this.ИзменитьПаДан.TabIndex = 8;
            this.ИзменитьПаДан.Text = "Изменить";
            this.ИзменитьПаДан.UseVisualStyleBackColor = true;
            this.ИзменитьПаДан.Click += new System.EventHandler(this.ИзменитьПаДан_Click);
            // 
            // НоваяФамилия
            // 
            this.НоваяФамилия.Location = new System.Drawing.Point(171, 211);
            this.НоваяФамилия.Name = "НоваяФамилия";
            this.НоваяФамилия.Size = new System.Drawing.Size(201, 22);
            this.НоваяФамилия.TabIndex = 9;
            this.НоваяФамилия.Text = "Фамилия";
            this.НоваяФамилия.Visible = false;
            this.НоваяФамилия.TextChanged += new System.EventHandler(this.НовоеОтчество_TextChanged);
            // 
            // НовоеИмя
            // 
            this.НовоеИмя.Location = new System.Drawing.Point(171, 241);
            this.НовоеИмя.Name = "НовоеИмя";
            this.НовоеИмя.Size = new System.Drawing.Size(201, 22);
            this.НовоеИмя.TabIndex = 10;
            this.НовоеИмя.Text = "Имя";
            this.НовоеИмя.Visible = false;
            this.НовоеИмя.TextChanged += new System.EventHandler(this.НовоеИмя_TextChanged);
            // 
            // НовОтчество
            // 
            this.НовОтчество.Location = new System.Drawing.Point(171, 270);
            this.НовОтчество.Name = "НовОтчество";
            this.НовОтчество.Size = new System.Drawing.Size(201, 22);
            this.НовОтчество.TabIndex = 11;
            this.НовОтчество.Text = "Отчество";
            this.НовОтчество.Visible = false;
            this.НовОтчество.TextChanged += new System.EventHandler(this.НовОтчество_TextChanged);
            // 
            // Серия
            // 
            this.Серия.Location = new System.Drawing.Point(23, 228);
            this.Серия.Name = "Серия";
            this.Серия.Size = new System.Drawing.Size(140, 22);
            this.Серия.TabIndex = 12;
            this.Серия.Text = "Серия паспорта";
            this.Серия.Visible = false;
            this.Серия.TextChanged += new System.EventHandler(this.Серия_TextChanged);
            // 
            // Номер
            // 
            this.Номер.Location = new System.Drawing.Point(23, 257);
            this.Номер.Name = "Номер";
            this.Номер.Size = new System.Drawing.Size(140, 22);
            this.Номер.TabIndex = 13;
            this.Номер.Text = "Номер паспорта";
            this.Номер.Visible = false;
            this.Номер.TextChanged += new System.EventHandler(this.Номер_TextChanged);
            // 
            // NewSecondName
            // 
            this.NewSecondName.Location = new System.Drawing.Point(171, 32);
            this.NewSecondName.Name = "NewSecondName";
            this.NewSecondName.Size = new System.Drawing.Size(201, 22);
            this.NewSecondName.TabIndex = 14;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(171, 61);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(201, 22);
            this.NewName.TabIndex = 15;
            // 
            // NewThirdName
            // 
            this.NewThirdName.Location = new System.Drawing.Point(171, 92);
            this.NewThirdName.Name = "NewThirdName";
            this.NewThirdName.Size = new System.Drawing.Size(201, 22);
            this.NewThirdName.TabIndex = 16;
            // 
            // UpdateFIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 347);
            this.Controls.Add(this.NewThirdName);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.NewSecondName);
            this.Controls.Add(this.Номер);
            this.Controls.Add(this.Серия);
            this.Controls.Add(this.НовОтчество);
            this.Controls.Add(this.НовоеИмя);
            this.Controls.Add(this.НоваяФамилия);
            this.Controls.Add(this.ИзменитьПаДан);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(407, 394);
            this.MinimumSize = new System.Drawing.Size(407, 394);
            this.Name = "UpdateFIO";
            this.Text = "Изменение паспортных данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ИзменитьПаДан;
        protected internal System.Windows.Forms.TextBox НоваяФамилия;
        protected internal System.Windows.Forms.TextBox НовоеИмя;
        protected internal System.Windows.Forms.TextBox НовОтчество;
        protected internal System.Windows.Forms.TextBox Серия;
        protected internal System.Windows.Forms.TextBox Номер;
        protected internal System.Windows.Forms.TextBox NewSecondName;
        protected internal System.Windows.Forms.TextBox NewName;
        protected internal System.Windows.Forms.TextBox NewThirdName;
    }
}