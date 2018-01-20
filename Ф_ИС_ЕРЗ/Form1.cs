using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;


namespace Ф_ИС_ЕРЗ
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Регистрация ЗЛ
        private void button1_Click(object sender, EventArgs e)
        {
            Пользователь userInfo = new Пользователь();
            DialogResult result = userInfo.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            Персоналные_данные PD = new Персоналные_данные();
            СМО SMO = new СМО();
            //Papse
            PD.Дата_рождения = DateTime.Parse(userInfo.Дата_рождения.Text);
            PD.Имя = userInfo.Имя.Text;
            PD.Фамилия = userInfo.Фамилия.Text;
            PD.Отчество = userInfo.Отчество.Text;
            PD.Серия = userInfo.Серия.Text;
            PD.Номер = userInfo.Номер.Text;
            PD.Пол = userInfo.Пол.SelectedItem.ToString();
            PD.Тип_документа = "полис";
            SMO.Название = userInfo.СМО.Text;
            SMO.Субъект_федерации = userInfo.Регион.Text;
            
            try
            {
                using (var context = new ИС_ЕРЗEntities2())
                {
                    //var search = context.Персоналные_данные.Where(b => b.Имя == PD.Имя && b.Отчество == PD.Отчество && b.Фамилия==PD.Фамилия);
                    //if (search != null)
                    //    MessageBox.Show("Пользователь имеется в системе");
                    //else
                    //{
                        var answer = context.Добавление_пользователя(0, PD.Фамилия, PD.Имя, PD.Отчество, PD.Пол, PD.Дата_рождения, PD.Тип_документа, PD.Номер, PD.Серия, SMO.Название, SMO.Субъект_федерации);
                        MessageBox.Show("Новый пользователь добавлен");
                    //}
                }
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
        //Удаление пользователя
        private void button3_Click(object sender, EventArgs e)
        {
            //Пользователь userInfo = new Пользователь();
            DeleteUser newForm = new DeleteUser();
            //newForm.Show();
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
           
            Персоналные_данные PD = new Персоналные_данные();
            PD.Имя = newForm.ИмяУд.Text;
            PD.Фамилия = newForm.ФамилияУд.Text;
            PD.Отчество = newForm.ОтчествоУд.Text;
            try
            {
                using (var context = new ИС_ЕРЗEntities2())
                {
                    var menForDel = context.Персоналные_данные.Where(b => b.Имя == PD.Имя && b.Фамилия == PD.Фамилия && b.Отчество == PD.Отчество);
                    if (menForDel != null)
                    {
                        context.Персоналные_данные.RemoveRange(menForDel); //удаляет по 2 значения
                        context.SaveChanges();
                    }
                    //var search = context.Персоналные_данные.SingleOrDefault(b => b.Имя == PD.Имя);
                    //if (search == null)
                        MessageBox.Show("Удалено");
                    //var table = context.Персоналные_данные;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Изменение СМО
        private void button2_Click(object sender, EventArgs e)
        {
            Пользователь userInfo = new Пользователь();
            //newForm.Show();
            DialogResult result = userInfo.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Персоналные_данные PD = new Персоналные_данные();
            СМО SMO = new СМО();
            //Papse
            PD.Дата_рождения = DateTime.Parse(userInfo.Дата_рождения.Text);
            //PD.Дата_рождения = "1996.12.12";
            PD.Имя = userInfo.Имя.Text;
            PD.Фамилия = userInfo.Фамилия.Text;
            PD.Отчество = userInfo.Отчество.Text;
            PD.Серия = userInfo.Серия.Text;
            PD.Номер = userInfo.Номер.Text;
            PD.Пол = userInfo.Пол.SelectedItem.ToString();
            PD.Тип_документа = "полис";
            SMO.Название = userInfo.СМО.Text;
            SMO.Субъект_федерации = userInfo.Регион.Text;
            try
            {
                using (var context = new ИС_ЕРЗEntities2())
                {
                    var answer = context.Выбор_СМО(PD.Дата_рождения, PD.Фамилия, PD.Имя, PD.Отчество, PD.Пол, PD.Номер, PD.Серия, SMO.Название, SMO.Субъект_федерации);
                    //var gg = context.Добавление_пользователя(0, PD.Фамилия, PD.Имя, PD.Отчество, PD.Пол,PD.Дата_рождения, PD.Тип_документа, PD.Номер, PD.Серия, SMO.Название, SMO.Субъект_федерации);
                    MessageBox.Show("Вы прикреплены к новой СМО");
                }
            }
            catch (System.Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
}

        //Изменение паспортных данных
        private void button4_Click(object sender, EventArgs e)
        {
            Change ch = new Change();
            DialogResult result = ch.ShowDialog();
            if (result == DialogResult.Cancel)
                return;


            //Персоналные_данные PD = new Персоналные_данные();
            //PD.Имя = ch.ChName.Text;
            //PD.Фамилия = ch.ChSecName.Text;
            //PD.Отчество = ch.ChThName.Text;

            //PD.Серия = ch.SeriesOfPassport.Text;
            //PD.Номер = ch.NumberOfPassport.Text;
            //string newName = ch.NewChSecName.Text;

            
            //try
            //{
            //    using (var context = new ИС_ЕРЗEntities2())
            //    {
            //        if (PD.Серия == "" && PD.Номер == "")
            //        {
            //            var answer = context.Изменение_паспорта(0, PD.Имя, PD.Фамилия, PD.Отчество, PD.Имя, newName, PD.Отчество, PD.Серия, PD.Номер);
            //            MessageBox.Show("Вы изменили Фамилию");
            //        }
            //        else if (newName == "")
            //        {
            //            var answer = context.Изменение_паспорта(1, PD.Имя, PD.Фамилия, PD.Отчество, PD.Имя, newName, PD.Отчество, PD.Серия, PD.Номер);
            //            MessageBox.Show("Вы изменили серию и номер паспорта");

            //        }
            //    }
            //}
            //catch (SystemException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //Персоналные_данные PD = new Персоналные_данные();
            //PD.Имя = fIO.ИмяИз.Text;
            //PD.Отчество = fIO.ОтчествоИз.Text;
            //PD.Фамилия = fIO.ФамилияИз.Text;
            //try
            //{
            //    using (var context = new ИС_ЕРЗEntities2())
            //    {
            //        var temp = context.Персоналные_данные.Where(b => b.Имя == PD.Имя && b.Фамилия == PD.Фамилия && b.Отчество == PD.Отчество);
            //        if (temp != null)
            //        {
            //            context.Изменение_паспорта(0, PD.Имя, PD.Фамилия, PD.Отчество, fIO.НовоеИмя.Text, fIO.НоваяФамилия.Text, fIO.НовОтчество.Text,"676767", "6767");
            //            context.SaveChanges();
            //            MessageBox.Show("Ваше ФИО изменено");
            //        }
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_ЕРЗDataSet.СМО". При необходимости она может быть перемещена или удалена.
            this.сМОTableAdapter.Fill(this.иС_ЕРЗDataSet.СМО);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_ЕРЗDataSet1.СМО". При необходимости она может быть перемещена или удалена.
            this.сМОTableAdapter.Fill(this.иС_ЕРЗDataSet1.СМО);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_ЕРЗDataSet1.СМО". При необходимости она может быть перемещена или удалена.
            this.сМОTableAdapter.Fill(this.иС_ЕРЗDataSet1.СМО);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_ЕРЗDataSet.СМО". При необходимости она может быть перемещена или удалена.
            this.сМОTableAdapter.Fill(this.иС_ЕРЗDataSet.СМО);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_ЕРЗDataSet.Персоналные_данные". При необходимости она может быть перемещена или удалена.
            this.персоналные_данныеTableAdapter.Fill(this.иС_ЕРЗDataSet.Персоналные_данные);

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.персоналные_данныеTableAdapter.Print(this.иС_ЕРЗDataSet.Персоналные_данные);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.состтояние_на_учётеTableAdapter.FillBy(this.иС_ЕРЗDataSet.Состтояние_на_учёте);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void updateConditionToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.состтояние_на_учётеTableAdapter.UpdateCondition(this.иС_ЕРЗDataSet.Состтояние_на_учёте);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.сМОTableAdapter.Fill(this.иС_ЕРЗDataSet.СМО);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
