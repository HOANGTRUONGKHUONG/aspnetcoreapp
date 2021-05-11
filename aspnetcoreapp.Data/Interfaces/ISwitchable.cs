using aspnetcoreapp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcoreapp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
