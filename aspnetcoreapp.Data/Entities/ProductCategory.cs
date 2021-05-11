using aspnetcoreapp.Data.Enums;
using aspnetcoreapp.Data.Interfaces;
using aspnetcoreapp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace aspnetcoreapp.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, 
        IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public string name { set; get; }

        public string Description { set; get; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
        public int SorOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Product> Products { set; get; }
    }
}