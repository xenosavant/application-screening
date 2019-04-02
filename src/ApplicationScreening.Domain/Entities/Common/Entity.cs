using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Common
{
    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        object IEntity.Id
        {
            get => Id;
        }

        public bool IsDeleted { get; set; }
    }
}