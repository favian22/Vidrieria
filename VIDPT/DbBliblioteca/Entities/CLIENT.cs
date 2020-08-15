namespace DbBliblioteca
{
    using DbBliblioteca.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENT")]
    public partial class CLIENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLIENT_ID { get; set; }

        [Required]
        public string FIRST_NAME { get; set; }

        [Required]
        public string LAST_NAME { get; set; }

        public string ADDRESS_CLIENT { get; set; }

        public string PHONE { get; set; }

        public int? FK_CITY_ID { get; set; }

        public int? FK_TYPE_CLIENT { get; set; }

        public virtual MASTER_DATA MASTER_DATA1 { get; set; }

        public virtual CITY CITY { get; set; }
    }
}
