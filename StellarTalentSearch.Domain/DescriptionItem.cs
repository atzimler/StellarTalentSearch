using System;
using System.ComponentModel.DataAnnotations;

namespace StellarTalentSearch.Domain
{
    public class DescriptionItem
    {
        [Key]
        public Guid Id { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
    }
}