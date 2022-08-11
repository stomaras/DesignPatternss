using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Domain.Models
{
    public class ProfilePictureService
    {
        // Should be async when doing an API Call
        public static byte[] GetFor(string lookup)
        {
            // Fetch from some third party based on e-mail or name
            return Encoding.Default.GetBytes("/9j/4AAQNJDSCNSJJNNSNJDSCNDSCJSD/WWQD");
        }
    }
}
