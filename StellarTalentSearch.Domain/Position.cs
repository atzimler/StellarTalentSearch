using System;
using System.ComponentModel.DataAnnotations;

namespace StellarTalentSearch.Domain
{
    public class Position
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public JobDescription JobDescription { get; set; }
        public Guid JobDescriptionId { get; set; }
    }
}