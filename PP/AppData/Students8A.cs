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
    
    public partial class Students8A
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students8A()
        {
            this.Grades_Class8A = new HashSet<Grades_Class8A>();
        }
    
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> ClassTeacherID { get; set; }
    
        public virtual ClassTeachers ClassTeachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grades_Class8A> Grades_Class8A { get; set; }
    }
}
