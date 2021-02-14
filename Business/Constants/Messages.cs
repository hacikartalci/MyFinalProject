using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static verirsen new'lemene ihtiyaç kalmaz.
    //publicler pascal case yazılır. Baş harfler Büyük.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        internal static string MaintenanceTime = "Sistem bakımdadır.";
        internal static string ProductListed = "Ürünler listelendi.";
    }
}
