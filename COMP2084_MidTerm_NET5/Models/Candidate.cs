using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084_MidTerm_NET5.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Job")]
        public int? JobId { get; set; }
        public Job Job { get; set; }

    }
}
