using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderUL.Model
{
    public class HistoryIndications
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public uint Indications { get; set; }
    }
}
