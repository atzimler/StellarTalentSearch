using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StellarTalentSearch.Domain
{
    public class JobDescription
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        
        public List<DescriptionItem> Responsibilities { get; set; }
        public List<DescriptionItem> Requirements { get; set; }
        public List<DescriptionItem> Attributes { get; set; }
        public List<DescriptionItem> Capabilities { get; set; }
    }
}