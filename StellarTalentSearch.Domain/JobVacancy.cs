using System;
using System.ComponentModel.DataAnnotations;

namespace StellarTalentSearch.Domain
{
    public class JobVacancy
    {
        [Key]
        public Guid Id { get; set; }
        
        public Position Position { get; set; }
        public Guid PositionId { get; set; }
    }
}