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
    
    public partial class Grades_Class5A
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int Grade { get; set; }
    
        public virtual Students5A Students5A { get; set; }
        public virtual Subjects5A Subjects5A { get; set; }
    }
}
