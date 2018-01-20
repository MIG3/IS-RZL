using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_ЕРЗ
{
    //class ENTER
    //{
    //    public string name = "", secondName = "", thirdName = "", sex, typeDocument = "",
    //                  numberPassport = "", seriesPassport = "", nameSMO = "", nameRegion = "";
    //    public DateTime dateBirhday;

    //    public ENTER() {}
    //    public void EnterData()
    //    {
    //        Console.WriteLine("Введите имя: ");
    //        name = Console.ReadLine();
    //        if (name == "")
    //            Console.WriteLine("Вы не ввели имя");
    //        Console.WriteLine("Введите фамилию: ");
    //        secondName = Console.ReadLine();
    //        if (secondName == "")
    //            Console.WriteLine("Вы не ввели фамилию");
    //        Console.WriteLine("Введите отчество: ");
    //        thirdName = Console.ReadLine();
    //        if (thirdName == "")
    //            Console.WriteLine("Вы не ввели отчество");
    //        Console.WriteLine("Введите пол: ");
    //        sex = Console.ReadLine();
    //        if (sex == "")
    //            Console.WriteLine("Вы не ввели пол");
    //        Console.WriteLine("Введите дату рождения: ");
    //        dateBirhday = DateTime.Parse(Console.ReadLine());
    //        if (dateBirhday == null)
    //            Console.WriteLine("Вы не ввели дату рождения");
    //        Console.WriteLine("Введите тип документа страхования: ");
    //        typeDocument = Console.ReadLine();
    //        if (typeDocument == "")
    //            Console.WriteLine("Вы не ввели тип документа страхования");
    //        Console.WriteLine("Введите серию паспорта: ");
    //        seriesPassport = Console.ReadLine();
    //        if (seriesPassport == "")
    //            Console.WriteLine("Вы не ввели серию паспорта");
    //        Console.WriteLine("Введите номер паспорта: ");
    //        numberPassport = Console.ReadLine();
    //        if (numberPassport == "")
    //            Console.WriteLine("Вы не ввели номер паспорта");
    //        Console.WriteLine("Введите регион регистрации: ");
    //        nameRegion = Console.ReadLine();
    //        if (nameRegion == "")
    //            Console.WriteLine("Вы не ввели регион регистрации");
    //        Console.WriteLine("Введите СМО: ");
    //        nameSMO = Console.ReadLine();
    //        if (nameSMO == "")
    //            Console.WriteLine("Вы не ввели СМО");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
             string name = "", secondName = "", thirdName = "", sex, typeDocument = "",
             numberPassport = "", seriesPassport = "", nameSMO = "", nameRegion = "";
            int flag;
            DateTime dateBirhday;
            string  str = "";
            string Method = "";
            Console.WriteLine("Выберите пункт меню:\n" +
                "1 - Регистрация застрахованного лица\n" +
                "2 - Изменение СМО ЗЛ\n" +
                //"3 - Изменение паспортных данных\n" +
                "4 - Снятие с учёта в связи со смертью (удаление)\n" +
                "5 - Печать таблицы Персональные данные");
            str = Console.ReadLine();
            while (str != "exit")
            {
                switch (str)
                {
                    // Добавить выход из меню только по 5, чтобы можно было нормально 
                    // взаимодействовать с базой и меню не закрывалось после 1 прохода
                    case "1":
                        //Method = "Регистрация";
                        Console.WriteLine("Введите имя: ");
                        name = Console.ReadLine();
                        if (name == "")
                            Console.WriteLine("Вы не ввели имя");
                        Console.WriteLine("Введите фамилию: ");
                        secondName = Console.ReadLine();
                        if (secondName == "")
                            Console.WriteLine("Вы не ввели фамилию");
                        Console.WriteLine("Введите отчество: ");
                        thirdName = Console.ReadLine();
                        if (thirdName == "")
                            Console.WriteLine("Вы не ввели отчество");
                        Console.WriteLine("Введите пол: ");
                        sex = Console.ReadLine();
                        if (sex == "")
                            Console.WriteLine("Вы не ввели пол");
                        Console.WriteLine("Введите дату рождения: ");
                        dateBirhday = DateTime.Parse(Console.ReadLine());
                        if (dateBirhday == null)
                            Console.WriteLine("Вы не ввели дату рождения");
                        Console.WriteLine("Введите тип документа страхования: ");
                        typeDocument = Console.ReadLine();
                        if (typeDocument == "")
                            Console.WriteLine("Вы не ввели тип документа страхования");
                        Console.WriteLine("Введите серию паспорта: ");
                        seriesPassport = Console.ReadLine();
                        if (seriesPassport == "")
                            Console.WriteLine("Вы не ввели серию паспорта");
                        Console.WriteLine("Введите номер паспорта: ");
                        numberPassport = Console.ReadLine();
                        if (numberPassport == "")
                            Console.WriteLine("Вы не ввели номер паспорта");
                        Console.WriteLine("Введите регион регистрации: ");
                        nameRegion = Console.ReadLine();
                        if (nameRegion == "")
                            Console.WriteLine("Вы не ввели регион регистрации");
                        Console.WriteLine("Введите СМО: ");
                        nameSMO = Console.ReadLine();
                        if (nameSMO == "")
                            Console.WriteLine("Вы не ввели СМО");
                        try
                        {
                            using (var context = new ИС_ЕРЗEntities1())
                            {
                                var answer = context.Добавление_пользователя(0, secondName, name, thirdName, sex, dateBirhday, typeDocument, numberPassport, seriesPassport, nameSMO, nameRegion);
                                Console.WriteLine("Пользователь поставлен на учёт в {0}", nameSMO);
                                var table = context.Персоналные_данные;
                                foreach (var item in table)
                                {
                                    Console.WriteLine(item.Фамилия + " " + item.Имя + " " + item.Отчество + " " + item.Пол + " " + item.Серия + " " + item.Номер + item.Дата_рождения + " ");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "2":
                        //Method = "ИзменениеСМО";
                        using (var context = new ИС_ЕРЗEntities1())
                        {
                            Console.WriteLine("Введите имя: ");
                            name = Console.ReadLine();
                            if (name == "")
                                Console.WriteLine("Вы не ввели имя");
                            Console.WriteLine("Введите фамилию: ");
                            secondName = Console.ReadLine();
                            if (secondName == "")
                                Console.WriteLine("Вы не ввели фамилию");
                            Console.WriteLine("Введите отчество: ");
                            thirdName = Console.ReadLine();
                            if (thirdName == "")
                                Console.WriteLine("Вы не ввели отчество");
                            Console.WriteLine("Введите пол: ");
                            sex = Console.ReadLine();
                            if (sex == "")
                                Console.WriteLine("Вы не ввели пол");
                            Console.WriteLine("Введите дату рождения: ");
                            dateBirhday = DateTime.Parse(Console.ReadLine());
                            if (dateBirhday == null)
                                Console.WriteLine("Вы не ввели дату рождения");
                            Console.WriteLine("Введите серию паспорта: ");
                            seriesPassport = Console.ReadLine();
                            if (seriesPassport == "")
                                Console.WriteLine("Вы не ввели серию паспорта");
                            Console.WriteLine("Введите номер паспорта: ");
                            numberPassport = Console.ReadLine();
                            if (numberPassport == "")
                                Console.WriteLine("Вы не ввели номер паспорта");
                            Console.WriteLine("Введите регион регистрации: ");
                            nameRegion = Console.ReadLine();
                            if (nameRegion == "")
                                Console.WriteLine("Вы не ввели регион регистрации");
                            Console.WriteLine("Введите СМО: ");
                            nameSMO = Console.ReadLine();
                            if (nameSMO == "")
                                Console.WriteLine("Вы не ввели СМО");
                            var answer = context.Выбор_СМО(dateBirhday, secondName, name, thirdName, sex, numberPassport, seriesPassport, nameSMO, nameRegion);
                            Console.WriteLine("Вы прикреплены к новой СМО {0}", nameSMO);
                            var table = context.Персоналные_данные;
                            //foreach (var item in table)
                            //{
                            //    Console.WriteLine(item.ID_ЗЛ + " " + item.Фамилия + " " + item.Имя + " " + item.Отчество + " " + item.Пол + " " + item.Серия + " " + item.Номер + item.Дата_рождения);
                            //}
                            //var tableYch = context.Состтояние_на_учёте;
                            //foreach (var item in tableYch)
                            //{
                            //    Console.WriteLine(item.ID_ЗЛ + " " + item.ID_СМО);
                            //}
                            //var tableSMO = context.СМО;
                            //foreach (var item in tableSMO)
                            //{
                            //    Console.WriteLine(item.ID_СМО + " " + item.Название);
                            //}
                            break;
                        }
                    case "3":
                        Method = "ИзменениеПаспорта";
                        break;
                    case "4":
                        //Method = "Удаление";
                        Console.WriteLine("Введите имя: ");
                        name = Console.ReadLine();
                        if (name == "")
                            Console.WriteLine("Вы не ввели имя");
                        Console.WriteLine("Введите фамилию: ");
                        secondName = Console.ReadLine();
                        if (secondName == "")
                            Console.WriteLine("Вы не ввели фамилию");
                        Console.WriteLine("Введите отчество: ");
                        thirdName = Console.ReadLine();
                        //вызов функции удадения данного пользователя из БД (поиск и удаление)
                        try
                        {
                            using (var context = new ИС_ЕРЗEntities1())
                            {
                                var menForDel = context.Персоналные_данные.Where(b => b.Имя == name && b.Фамилия == secondName && b.Отчество == thirdName);
                                if (menForDel != null)
                                {
                                    context.Персоналные_данные.RemoveRange(menForDel);
                                    context.SaveChanges();
                                }
                                var search = context.Персоналные_данные.SingleOrDefault(b => b.Имя == name);
                                if (search == null)
                                    Console.WriteLine("Удалено");
                                var table = context.Персоналные_данные;
                                foreach (var item in table)
                                {
                                    Console.WriteLine(item.Фамилия + " " + item.Имя + " " + item.Отчество + " " + item.Пол + " " + item.Серия + " " + item.Номер + item.Дата_рождения + " ");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        try
                        {
                            using (var context = new ИС_ЕРЗEntities1())
                            {
                                var table = context.Персоналные_данные;
                                foreach (var item in table)
                                {
                                    Console.WriteLine(item.Фамилия + " " + item.Имя + " " + item.Отчество + " " + item.Пол + " " + item.Серия + " " + item.Номер + item.Дата_рождения + " ");
                                }
                                var tableYch = context.Состтояние_на_учёте;
                                foreach (var item in tableYch)
                                {
                                    Console.WriteLine(item.ID_ЗЛ + " " + item.ID_СМО);
                                }
                                var tableSMO = context.СМО;
                                foreach (var item in tableSMO)
                                {
                                    Console.WriteLine(item.ID_СМО + " " + item.Название);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        break;
                }
                str = Console.ReadLine();
                if (str == "exit")
                    break;
            }
            //if (Method == "Регистрация")
            //if (Method == "ИзменениеСМО")
            //{            }
            if (Method == "ИзменениеПаспорта")
            {
                    Console.WriteLine("Введите:");
                    flag = 0;
                    Console.WriteLine("Текущее имя: ");
                    name = Console.ReadLine();
                    if (name == "")
                        Console.WriteLine("Вы не ввели имя");
                    Console.WriteLine("Текущую фамилию: ");
                    secondName = Console.ReadLine();
                    if (secondName == "")
                        Console.WriteLine("Вы не ввели фамилию");
                    Console.WriteLine("Текущее отчество: ");
                    thirdName = Console.ReadLine();
                    if (thirdName == "")
                        Console.WriteLine("Вы не ввели отчество");
                //вызов функции поиска
                using (var context = new ИС_ЕРЗEntities1())
                {
                    var change = context.Изменение_паспорта(flag, null, null, null, seriesPassport, numberPassport, 0);
                    //var answer = context.Database.SqlQuery<Персоналные_данные>("SELECT * FROM Поиск(@name, @secondName, thirdNAme)", @name, @secondName, thirdName);
                    //Console.WriteLine(answer);
                    //int id = int.Parse(answer);
                    //int id = Convert.ToInt32(answer); // не работает
                    Console.WriteLine(change);
                    if (change != 1)
                    {
                        Console.WriteLine("Что Вы хотите изменить?");
                        if (Console.ReadLine() == "ФИО")
                        {
                            Console.WriteLine("Новое имя: ");
                            name = Console.ReadLine();
                            if (name == "")
                                Console.WriteLine("Вы не ввели имя");
                            Console.WriteLine("Новая фамилия: ");
                            secondName = Console.ReadLine();
                            if (secondName == "")
                                Console.WriteLine("Вы не ввели фамилию");
                            Console.WriteLine("Новое отчество: ");
                            thirdName = Console.ReadLine();
                            if (thirdName == "")
                                Console.WriteLine("Вы не ввели отчество");
                            // вызов процедуры изменения пасппортных данных (поиск и изменение)
                            var change1 = context.Изменение_паспорта(flag, name, secondName, thirdName, null, null, 1);

                        }
                        else if (Console.ReadLine() == "Данные паспорта")
                        {
                            flag = 1;
                            Console.WriteLine("Серию паспорта: ");
                            seriesPassport = Console.ReadLine();
                            if (seriesPassport == "")
                                Console.WriteLine("Вы не ввели серию паспорта");
                            Console.WriteLine("Номер паспорта: ");
                            numberPassport = Console.ReadLine();
                            if (numberPassport == "")
                                Console.WriteLine("Вы не ввели номер паспорта");
                            var change1 = context.Изменение_паспорта(flag, null, null, null, seriesPassport, numberPassport, 1);
                        }
                        else Console.WriteLine("Вы не зарегестрированы.");
                    }
                }
                
            }
            // удаление - удаляет даннные о конкретном пользователе только из таблицы "Персонльные данные"
            //else if (Method == "Удаление")
            //{
            //}
        }
    }
}
