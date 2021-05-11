using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcoreapp.Data.Interfaces
{
    public interface ISortable
    {
        int SorOrder { set; get; }
    }
}
