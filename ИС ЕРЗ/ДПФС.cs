//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ИС_ЕРЗ
{
    using System;
    using System.Collections.Generic;
    
    public partial class ДПФС
    {
        public int ID { get; set; }
        public int ID_ЗЛ { get; set; }
        public System.DateTime Дата_выдачи { get; set; }
        public string Тип { get; set; }
        public Nullable<System.DateTime> Срок_действия { get; set; }
        public int Номер_бланка { get; set; }
    
        public virtual Застрахованное_лицо Застрахованное_лицо { get; set; }
    }
}
