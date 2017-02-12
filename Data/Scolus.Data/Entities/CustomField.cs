﻿using Scolus.Data.Entities;
using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class CustomField : IAudit
    {
        [Key]
        public int CustomFieldId { get; set; }

        [Required]
        public CustomFieldType Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<CustomFieldOption> CustomFieldOptions { get; set; }

        public virtual ICollection<SchoolCustomFieldSetUp> SchoolCustomFieldSetUp { get; set; }
        public virtual ICollection<FacultyCustomFieldSetUp> FacultyCustomFieldSetUp { get; set; }
        public virtual ICollection<StudentCustomFieldSetUp> StudentCustomFieldSetUp { get; set; }
    }
}
