using MembershipApp.Models;
using System.Collections.Generic;

namespace MembershipApp.Comparers
{
    public class ThumbnailEqualityComparer : IEqualityComparer<ThumbnailModel>
    {
        public bool Equals(ThumbnailModel thumbnailOne, ThumbnailModel thumbnailTwo)
        {
            return thumbnailOne.ProductId.Equals(thumbnailTwo.ProductId);
        }

        public int GetHashCode(ThumbnailModel thumbnail)
        {
            return thumbnail.ProductId;
        }
    }
}