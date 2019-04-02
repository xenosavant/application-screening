using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    // This interface defines the auditable properties for an auditable entity with key type T
    interface IAuditable<T>
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        T CreatedBy { get; set; }
    }
}
