using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    // Base interface with base object Id
    public interface IEntity
    {
        object Id { get; }
    }

    // Generic typed interface that implements IEntity and hides base class Id
    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }
}
