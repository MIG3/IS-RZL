//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ф_ИС_ЕРЗ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Состтояние_на_учёте
    {
        public int ID { get; set; }
        public int ID_ЗЛ { get; set; }
        public System.DateTime Дата_постановки { get; set; }
        public Nullable<System.DateTime> Дата_снятия { get; set; }
        public int ID_СМО { get; set; }
    
        public virtual Застрахованное_лицо Застрахованное_лицо { get; set; }
        public virtual СМО СМО { get; set; }
    }
}
