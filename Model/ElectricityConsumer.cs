using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoderUL.Model
{
    public class ElectricityConsumer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public List<Counter> Counters { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
