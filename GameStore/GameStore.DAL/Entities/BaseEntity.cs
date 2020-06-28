using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameStore.DAL.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
