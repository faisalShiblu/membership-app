using System.Collections.Generic;

namespace MembershipApp.Models
{
    public class ProductSection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ItemTypeId { get; set; }
        public IEnumerable<ProductItemRow> Items { get; set; }
    }
}