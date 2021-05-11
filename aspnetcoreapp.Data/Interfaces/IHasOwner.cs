using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcoreapp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}
