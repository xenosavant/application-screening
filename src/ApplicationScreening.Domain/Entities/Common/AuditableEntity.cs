using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Common
{
    // This class represents an entity that is auditable and implements the IAuditable interface
    public class AuditableEntity<T> : Entity<T>, IAuditable<T>
    {
        private DateTime? _createdDate;

        public DateTime CreatedDate
        {
            get => _createdDate ?? DateTime.UtcNow;
            set => _createdDate = value;
        }

        public T CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}