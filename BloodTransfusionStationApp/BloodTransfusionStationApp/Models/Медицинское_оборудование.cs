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
    
    public partial class Медицинское_оборудование
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Медицинское_оборудование()
        {
            this.Прием_крови = new HashSet<Прием_крови>();
        }
    
        public int Номер_оборудования { get; set; }
        public string Наименование { get; set; }
        public Nullable<System.DateTime> Дата_начала_эксплуатации { get; set; }
        public Nullable<System.DateTime> Срок_окончания_эксплуатации { get; set; }
        public Nullable<int> Расположение__номер_кабинета_ { get; set; }
        public int Номер_ответственного_сотрудника { get; set; }
    
        public virtual Врачи Врачи { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Прием_крови> Прием_крови { get; set; }
    }
}
