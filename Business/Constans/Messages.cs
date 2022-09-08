using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        // Car için mesajlar 
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarListed = "Araba Listelendi";
        public static string CarDetails = "Araba Detayları Listelendi";
        public static string CarListAllByColorId = "Renge göre bütün arabalar listelendi";
        public static string CarListAllByBrandId = "Modele göre bütün arabalar listelendi";
        public static string CarGetById = "İstenilen araba getirildi";

        // Brand için  mesajlar
        public static string BrandAdded = "Model Eklendi";
        public static string BrandDeleted = "Model Silindi";
        public static string BrandUpdated = "Model Güncellendi";
        public static string BrandListed = "Model Listelendi";
        public static string BrandGetById = "İstenilen model getirildi";

        // Color için mesajlar
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renk Listelendi";
        public static string ColorListById = "İstenilen Renk getirildi";
    }
}
