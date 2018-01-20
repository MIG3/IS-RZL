using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ф_ИС_ЕРЗ
{
    public partial class UpdateFIO : Form
    {
        public UpdateFIO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Имя_TextChanged(object sender, EventArgs e)
        {

        }

        private void Отчество_TextChanged(object sender, EventArgs e)
        {

        }

        private void ФамилияИз_TextChanged(object sender, EventArgs e)
        {

        }

        private void ИмяИз_TextChanged(object sender, EventArgs e)
        {

        }

        private void ОтчествоИз_TextChanged(object sender, EventArgs e)
        {

        }

        private void ИзменитьПаДан_Click(object sender, EventArgs e)
        {

        }

        // ФИО
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFIO fIO = new UpdateFIO();
            Персоналные_данные PD = new Персоналные_данные();
            if (radioButton1.Checked)
            {
                НовоеИмя.Visible = true;
                НоваяФамилия.Visible = true;
                НовОтчество.Visible = true;
                Серия.Visible = false;
                Номер.Visible = false;
            }
                MessageBox.Show(PD.Имя); // не присвоилось значение из textbox
                try
                {
                    using (var context = new ИС_ЕРЗEntities2())
                    {
                        string un = fIO.НовоеИмя.Text;
                        string usn = fIO.НоваяФамилия.Text;
                        string utn = fIO.НовОтчество.Text;
                        var temp = context.Персоналные_данные.Where(b => b.Имя == PD.Имя && b.Фамилия == PD.Фамилия && b.Отчество == PD.Отчество);
                        if (temp != null)
                        {
                            context.Изменение_паспорта(0, PD.Имя, PD.Фамилия, PD.Отчество, un, usn, utn, "676767", "6767");
                            context.SaveChanges();
                            MessageBox.Show("Ваше ФИО изменено");
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Серия.Visible = true;
                Номер.Visible = true;
                НовоеИмя.Visible = false;
                НоваяФамилия.Visible = false;
                НовОтчество.Visible = false;
            }
        }

        private void НовоеОтчество_TextChanged(object sender, EventArgs e)
        {

        }

        private void НовОтчество_TextChanged(object sender, EventArgs e)
        {

        }

        private void НовоеИмя_TextChanged(object sender, EventArgs e)
        {

        }

        private void Серия_TextChanged(object sender, EventArgs e)
        {

        }

        private void Номер_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
