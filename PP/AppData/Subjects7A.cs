//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PP.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subjects7A
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subjects7A()
        {
            this.Grades_Class7A = new HashSet<Grades_Class7A>();
        }
    
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string ClassName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grades_Class7A> Grades_Class7A { get; set; }
    }
}
