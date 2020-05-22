using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidrieria.Models
{
    public class Cliente
    {
        [Key]
        [Column]        
        public int ClientId { get; set; }

        [Column]        
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public string AddresClient { get; set; }

        [Column]
        public string Phone { get; set; }

        [Column]
        public int FkCountry { get; set; }

        [Column]
        public int FkTypeClient { get; set; }
    }
}