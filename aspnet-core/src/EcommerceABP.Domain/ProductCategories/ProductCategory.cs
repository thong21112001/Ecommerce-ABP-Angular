using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.ProductCategories
{
    public class ProductCategory : CreationAuditedAggregateRoot<Guid>
    {
        //Gõ prop cho nhanh xong tab ra
        public string Name { get; set; }
        public string Code { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public string CoverPicture { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public string SeoMetaDescription { get; set; }
    }
}
