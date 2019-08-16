using MembershipApp.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace MembershipApp.Areas.Admin.Models
{
    public class ProductItemModel
    {
        [DisplayName("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Item Id")]
        public int ItemId { get; set; }

        [DisplayName("Product Title")]
        public string ProductTitle { get; set; }

        [DisplayName("Item Title")]
        public string ItemTitle { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}