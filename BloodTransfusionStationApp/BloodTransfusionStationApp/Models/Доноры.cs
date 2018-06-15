//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodTransfusionStationApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Доноры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Доноры()
        {
            this.Прием_крови = new HashSet<Прием_крови>();
        }
    
        public int Номер_донора { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Отчество { get; set; }
        public Nullable<System.DateTime> Дата_рождения { get; set; }
        public Nullable<bool> Пол { get; set; }
        public string Группа_крови { get; set; }
        public string Телефон { get; set; }
        public string Адрес { get; set; }
        public string Паспортные_данные { get; set; }
    
        public virtual Информация_о_доноре Информация_о_доноре { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Прием_крови> Прием_крови { get; set; }
    }
}
