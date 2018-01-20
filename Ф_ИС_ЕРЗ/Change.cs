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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void Изменить_Click(object sender, EventArgs e)
        {


            Персоналные_данные PD = new Персоналные_данные();
            PD.Имя = ChName.Text;
            PD.Фамилия = ChSecName.Text;
            PD.Отчество = ChThName.Text;

            PD.Серия = SeriesOfPassport.Text;
            PD.Номер = NumberOfPassport.Text;
            string newName = NewChSecName.Text;
            try
            {
                using (var context = new ИС_ЕРЗEntities2())
                {
                    if (PD.Серия == "" && PD.Номер == "")
                    {
                        var answer = context.Изменение_паспорта(0, PD.Имя, PD.Фамилия, PD.Отчество, PD.Имя, newName, PD.Отчество, PD.Серия, PD.Номер);
                        MessageBox.Show("Вы изменили Фамилию");
                    }
                    else if (newName == "")
                    {
                        var answer = context.Изменение_паспорта(1, PD.Имя, PD.Фамилия, PD.Отчество, PD.Имя, newName, PD.Отчество, PD.Серия, PD.Номер);
                        MessageBox.Show("Вы изменили серию и номер паспорта");

                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
