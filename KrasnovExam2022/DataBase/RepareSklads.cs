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
    
    public partial class RepareSklads
    {
        public int Id_RepareSklad { get; set; }
        public int Id_Prone { get; set; }
        public int Id_Client { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Phones Phones { get; set; }
    }
}
