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
    
    public partial class Хранилища_крови
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Хранилища_крови()
        {
            this.Отделы_хранилищ = new HashSet<Отделы_хранилищ>();
            this.Поставки_в_больницы = new HashSet<Поставки_в_больницы>();
            this.Прием_крови = new HashSet<Прием_крови>();
        }
    
        public int Номер_хранилища { get; set; }
        public string Группа_крови { get; set; }
        public int Расположение__номер_кабинета_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Отделы_хранилищ> Отделы_хранилищ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Поставки_в_больницы> Поставки_в_больницы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Прием_крови> Прием_крови { get; set; }
    }
}
