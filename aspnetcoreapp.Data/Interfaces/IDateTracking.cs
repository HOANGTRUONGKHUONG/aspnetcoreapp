using System;

namespace aspnetcoreapp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }

        DateTime DateModified { set; get; }
    }
}