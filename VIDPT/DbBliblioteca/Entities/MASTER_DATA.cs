namespace DbBliblioteca
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_DATA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MASTER_DATA()
        {
            CLIENT1 = new HashSet<CLIENT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASTER_DATA_ID { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string CODE { get; set; }

        public int? MASTER_TYPE_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT> CLIENT1 { get; set; }

        public virtual MASTER_TYPE MASTER_TYPE { get; set; }
    }
}
