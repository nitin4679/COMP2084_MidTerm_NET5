using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP2084_MidTerm_NET5.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
