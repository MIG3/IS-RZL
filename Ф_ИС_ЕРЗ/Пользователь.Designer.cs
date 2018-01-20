namespace Ф_ИС_ЕРЗ
{
    partial class Пользователь
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Фамилия = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.TextBox();
            this.Отчество = new System.Windows.Forms.TextBox();
            this.Серия = new System.Windows.Forms.TextBox();
            this.Номер = new System.Windows.Forms.TextBox();
            this.Регион = new System.Windows.Forms.ComboBox();
            this.Ввести = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Пол = new System.Windows.Forms.ComboBox();
            this.Дата_рождения = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.СМО = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сведения о паспорте:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Серия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Регион регистрации:";
            // 
            // Фамилия
            // 
            this.Фамилия.Location = new System.Drawing.Point(129, 9);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(193, 22);
            this.Фамилия.TabIndex = 11;
            this.Фамилия.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Имя
            // 
            this.Имя.Location = new System.Drawing.Point(129, 38);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(193, 22);
            this.Имя.TabIndex = 12;
            this.Имя.TextChanged += new System.EventHandler(this.Имя_TextChanged);
            // 
            // Отчество
            // 
            this.Отчество.Location = new System.Drawing.Point(129, 67);
            this.Отчество.Name = "Отчество";
            this.Отчество.Size = new System.Drawing.Size(193, 22);
            this.Отчество.TabIndex = 13;
            this.Отчество.TextChanged += new System.EventHandler(this.Отчество_TextChanged);
            // 
            // Серия
            // 
            this.Серия.Location = new System.Drawing.Point(131, 216);
            this.Серия.Name = "Серия";
            this.Серия.Size = new System.Drawing.Size(62, 22);
            this.Серия.TabIndex = 15;
            this.Серия.TextChanged += new System.EventHandler(this.Серия_TextChanged);
            // 
            // Номер
            // 
            this.Номер.Location = new System.Drawing.Point(256, 216);
            this.Номер.Name = "Номер";
            this.Номер.Size = new System.Drawing.Size(66, 22);
            this.Номер.TabIndex = 16;
            this.Номер.TextChanged += new System.EventHandler(this.Номер_TextChanged);
            // 
            // Регион
            // 
            this.Регион.FormattingEnabled = true;
            this.Регион.Items.AddRange(new object[] {
            "Республика Адыгея                                           ",
            "Республика Башкортостан                                     ",
            "Республика Бурятия                                          ",
            "Республика Алтай                                            ",
            "Республика Дагестан                                         ",
            "Республика Ингушетия                                        ",
            "Кабардино-Балкарская Республика                             ",
            "Республика Калмыкия                                         ",
            "Карачаево-Черкесская Республика                             ",
            "Республика Карелия                                          ",
            "Республика Коми                                             ",
            "Республика Марий Эл                                         ",
            "Республика Мордовия                                         ",
            "Республика Саха (Якутия)                                    ",
            "Республика Северная Осетия-Алания                           ",
            "Республика Татарстан                                        ",
            "Республика Тыва                                             ",
            "Удмуртская Республика                                       ",
            "Республика Хакасия                                          ",
            "Чеченская Республика                                        ",
            "Чувашская Республика                                        ",
            "Алтайский край                                              ",
            "Краснодарский край                                          ",
            "Красноярский край                                           ",
            "Приморский край                                             ",
            "Ставропольский край                                         ",
            "Хабаровский край                                            ",
            "Амурская область                                            ",
            "Архангельская область                                       ",
            "Астраханская область                                        ",
            "Белгородская область                                        ",
            "Брянская область                                            ",
            "Владимирская область                                        ",
            "Волгоградская область                                       ",
            "Вологодская область                                         ",
            "Воронежская область                                         ",
            "Ивановская область                                          ",
            "Иркутская область                                           ",
            "Калининградская область                                     ",
            "Калужская область                                           ",
            "Камчатский край                                             ",
            "Кемеровская область                                         ",
            "Кировская область                                           ",
            "Костромская область                                         ",
            "Курганская область                                          ",
            "Курская область                                             ",
            "Ленинградская область                                       ",
            "Липецкая область                                            ",
            "Магаданская область                                         ",
            "Московская область                                          ",
            "Мурманская область                                          ",
            "Нижегородская область                                       ",
            "Новгородская область                                        ",
            "Новосибирская область                                       ",
            "Омская область                                              ",
            "Оренбургская область                                        ",
            "Орловская область                                           ",
            "Пензенская область                                          ",
            "Пермский край                                               ",
            "Псковская область                                           ",
            "Ростовская область                                          ",
            "Рязанская область                                           ",
            "Самарская область                                           ",
            "Саратовская область                                         ",
            "Сахалинская область                                         ",
            "Свердловская область",
            "Смоленская область",
            "Тамбовская область",
            "Тверская область",
            "Томская область",
            "Тульская область",
            "Тюменская область                                           ",
            "Ульяновская область                                         ",
            "Челябинская область                                         ",
            "Забайкальский край",
            "Ярославская область   ",
            "г. Москва",
            "г. Санкт-Петербург",
            "Еврейская АО",
            "Ненецкий АО",
            "Ханты-Мансийский АО",
            "Чукотский АО",
            "Ямало-Ненецкий АО",
            "г. Байконур",
            "Республика Крым   ",
            "г. Севастополь"});
            this.Регион.Location = new System.Drawing.Point(164, 271);
            this.Регион.Name = "Регион";
            this.Регион.Size = new System.Drawing.Size(158, 24);
            this.Регион.TabIndex = 17;
            this.Регион.SelectedIndexChanged += new System.EventHandler(this.Регион_SelectedIndexChanged);
            // 
            // Ввести
            // 
            this.Ввести.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ввести.Location = new System.Drawing.Point(261, 368);
            this.Ввести.Name = "Ввести";
            this.Ввести.Size = new System.Drawing.Size(75, 23);
            this.Ввести.TabIndex = 18;
            this.Ввести.Text = "Готово";
            this.Ввести.UseVisualStyleBackColor = true;
            this.Ввести.Click += new System.EventHandler(this.Ввести_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Пол";
            // 
            // Пол
            // 
            this.Пол.FormattingEnabled = true;
            this.Пол.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.Пол.Location = new System.Drawing.Point(129, 118);
            this.Пол.Name = "Пол";
            this.Пол.Size = new System.Drawing.Size(102, 24);
            this.Пол.TabIndex = 20;
            this.Пол.SelectedIndexChanged += new System.EventHandler(this.Пол_SelectedIndexChanged);
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.Location = new System.Drawing.Point(131, 161);
            this.Дата_рождения.Mask = "00/00/0000";
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.Size = new System.Drawing.Size(100, 22);
            this.Дата_рождения.TabIndex = 21;
            this.Дата_рождения.ValidatingType = typeof(System.DateTime);
            this.Дата_рождения.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Дата_рождения_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Название СМО:";
            // 
            // СМО
            // 
            this.СМО.Location = new System.Drawing.Point(163, 321);
            this.СМО.Name = "СМО";
            this.СМО.Size = new System.Drawing.Size(158, 22);
            this.СМО.TabIndex = 23;
            this.СМО.TextChanged += new System.EventHandler(this.СМО_TextChanged);
            // 
            // Пользователь
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(348, 403);
            this.Controls.Add(this.СМО);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Дата_рождения);
            this.Controls.Add(this.Пол);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ввести);
            this.Controls.Add(this.Регион);
            this.Controls.Add(this.Номер);
            this.Controls.Add(this.Серия);
            this.Controls.Add(this.Отчество);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(366, 450);
            this.MinimumSize = new System.Drawing.Size(366, 450);
            this.Name = "Пользователь";
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button Ввести;
        protected internal System.Windows.Forms.TextBox Фамилия;
        protected internal System.Windows.Forms.TextBox Имя;
        protected internal System.Windows.Forms.TextBox Отчество;
        protected internal System.Windows.Forms.TextBox Серия;
        protected internal System.Windows.Forms.TextBox Номер;
        protected internal System.Windows.Forms.ComboBox Регион;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.ComboBox Пол;
        protected internal System.Windows.Forms.MaskedTextBox Дата_рождения;
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.TextBox СМО;
}
}