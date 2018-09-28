using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDemo2.Models.BaseEntity
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
