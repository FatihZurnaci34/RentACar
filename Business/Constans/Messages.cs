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
        public static string CarCountOfBrandError = "Bu kategorimizde en fazla 10 tane araba olabilir";
        public static string CarNameAlreadyExits="Bu isimde başka bir araba var";


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

        // Customer için mesajlar
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteriler Listelendi";
        public static string CustomerListById = "İstenilen Müşteri getirildi";

    }
}
