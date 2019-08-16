using MembershipApp.Models;
using System.Collections.Generic;

namespace MembershipApp.Comparers
{
    public class ProductSectionEqualityComparer : IEqualityComparer<ProductSection>
    {

        public bool Equals(ProductSection firstSection, ProductSection secondSection)
        {
            return firstSection.Id.Equals(secondSection.Id);
        }

        public int GetHashCode(ProductSection section)
        {
            return (section.Id).GetHashCode();
        }
    }
}