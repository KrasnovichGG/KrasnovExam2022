//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KrasnovExam2022.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int Id_Sale { get; set; }
        public int Id_User { get; set; }
        public int Id_Phone { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Phones Phones { get; set; }
        public virtual Users Users { get; set; }
    }
}