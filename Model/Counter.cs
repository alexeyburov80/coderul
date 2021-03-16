using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoderUL.Model
{
    public class Counter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public CounterType CounterType;
        [Required]
        public uint Number;
        [Required]
        public DateTime DateOfAcceptance { get; set; }
        [Required]
        public uint StateVerificationPeriod { get; set; }
        public List<HistoryIndications> historyIndications { get; set; }
    }
}
