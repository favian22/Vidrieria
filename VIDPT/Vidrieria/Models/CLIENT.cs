//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidrieria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENT
    {
        public int CLIENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string ADDRESS_CLIENT { get; set; }
        public string PHONE { get; set; }
        public Nullable<int> FK_COUNTRY_ID { get; set; }
        public Nullable<int> FK_TYPE_CLIENT { get; set; }
    
        public virtual MASTER_DATA MASTER_DATA { get; set; }
        public virtual MASTER_DATA MASTER_DATA1 { get; set; }
    }
}