namespace Ф_ИС_ЕРЗ
{
    partial class Change
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
            this.ChName = new System.Windows.Forms.TextBox();
            this.ChSecName = new System.Windows.Forms.TextBox();
            this.ChThName = new System.Windows.Forms.TextBox();
            this.NewChSecName = new System.Windows.Forms.TextBox();
            this.SeriesOfPassport = new System.Windows.Forms.TextBox();
            this.NumberOfPassport = new System.Windows.Forms.TextBox();
            this.Изменить = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecName = new System.Windows.Forms.Label();
            this.labelThName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChName
            // 
            this.ChName.Location = new System.Drawing.Point(183, 12);
            this.ChName.Name = "ChName";
            this.ChName.Size = new System.Drawing.Size(171, 22);
            this.ChName.TabIndex = 0;
            // 
            // ChSecName
            // 
            this.ChSecName.Location = new System.Drawing.Point(183, 41);
            this.ChSecName.Name = "ChSecName";
            this.ChSecName.Size = new System.Drawing.Size(171, 22);
            this.ChSecName.TabIndex = 1;
            // 
            // ChThName
            // 
            this.ChThName.Location = new System.Drawing.Point(183, 70);
            this.ChThName.Name = "ChThName";
            this.ChThName.Size = new System.Drawing.Size(171, 22);
            this.ChThName.TabIndex = 2;
            // 
            // NewChSecName
            // 
            this.NewChSecName.Location = new System.Drawing.Point(183, 123);
            this.NewChSecName.Name = "NewChSecName";
            this.NewChSecName.Size = new System.Drawing.Size(171, 22);
            this.NewChSecName.TabIndex = 3;
            // 
            // SeriesOfPassport
            // 
            this.SeriesOfPassport.Location = new System.Drawing.Point(183, 183);
            this.SeriesOfPassport.Name = "SeriesOfPassport";
            this.SeriesOfPassport.Size = new System.Drawing.Size(171, 22);
            this.SeriesOfPassport.TabIndex = 4;
            // 
            // NumberOfPassport
            // 
            this.NumberOfPassport.Location = new System.Drawing.Point(183, 212);
            this.NumberOfPassport.Name = "NumberOfPassport";
            this.NumberOfPassport.Size = new System.Drawing.Size(171, 22);
            this.NumberOfPassport.TabIndex = 5;
            // 
            // Изменить
            // 
            this.Изменить.Location = new System.Drawing.Point(248, 258);
            this.Изменить.Name = "Изменить";
            this.Изменить.Size = new System.Drawing.Size(106, 36);
            this.Изменить.TabIndex = 6;
            this.Изменить.Text = "Изменить";
            this.Изменить.UseVisualStyleBackColor = true;
            this.Изменить.Click += new System.EventHandler(this.Изменить_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(131, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Location = new System.Drawing.Point(96, 41);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(70, 17);
            this.labelSecName.TabIndex = 8;
            this.labelSecName.Text = "Фамилия";
            // 
            // labelThName
            // 
            this.labelThName.AutoSize = true;
            this.labelThName.Location = new System.Drawing.Point(95, 73);
            this.labelThName.Name = "labelThName";
            this.labelThName.Size = new System.Drawing.Size(71, 17);
            this.labelThName.TabIndex = 9;
            this.labelThName.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите новую фамилию:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите новые серию и номер паспорта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Серия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер";
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelThName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Изменить);
            this.Controls.Add(this.NumberOfPassport);
            this.Controls.Add(this.SeriesOfPassport);
            this.Controls.Add(this.NewChSecName);
            this.Controls.Add(this.ChThName);
            this.Controls.Add(this.ChSecName);
            this.Controls.Add(this.ChName);
            this.Name = "Change";
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox ChName;
        protected internal System.Windows.Forms.TextBox ChSecName;
        protected internal System.Windows.Forms.TextBox ChThName;
        protected internal System.Windows.Forms.TextBox NewChSecName;
        protected internal System.Windows.Forms.TextBox SeriesOfPassport;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecName;
        private System.Windows.Forms.Label labelThName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox NumberOfPassport;
        public System.Windows.Forms.Button Изменить;
    }
}