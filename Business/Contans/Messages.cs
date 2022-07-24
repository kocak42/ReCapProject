using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarRemoved = "Araba silindi";
        public static string CarUpdated = "Araba Bilgileri güncellendi";
        public static string CarListed = "Arabalar listelendi";
        public static string MintenanceTime = "sistem bakımda";


        public static string BrandAdded = "Marka Eklendi";
        public static string BrandRemoved = "Marka silindi";
        public static string BrandUpdated = "Araba markası Güncellendi";
        public static string BrandListed = "Markalar listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorRemoved = "Renk silindi";
        public static string ColorUpdated = "Araba rengi güncelendi";
        public static string ColorListed = "Renkeler listelendi";

        public static string RantalAdded = "Kiralık Araba Eklendi";
        public static string RantalRemoved = "Kiralık Araba silindi";
        public static string RantalUpdated = "Kiralık Araba güncllendi";
        public static string RentalListed = "Kiralık arabalar listelendi";
        public static string RentalValid = "Kiralama başarıyla gerçekleşti";
        public static string RentalInValid = "Kiralama başarısız";

        public static string CustomerAdded = "Müşteri  Eklendi";
        public static string CustomerRemoved = "Müşteri  silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string UserAdded = "kullanıcı Eklendi";
        public static string UserRemoved = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        internal static string CarImagesListed;
        internal static string CarImageDeleted;
        internal static string CarImageAdded;
        internal static string CarImageLimitExceded;
        internal static string AuthorizationDenied;

        public static string CarImageUpdated { get; internal set; }
    }
}
