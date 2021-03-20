using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalCanNotAdded = "Araba kiralandı.";
        public static string RentalsListed = "Kiralık arabalar listelendi.";
        public static string Succesful = "İşlem başarılı.";
        public static string Error = "Bir hata ile karşılaşıldı.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string SuccessfulLogin = "Giriş yapıldı.";
        public static string UserNotFound ="Kullanıcı bulunamadı.";
        public static string UserRegistered ="Kullanıcı giriş yaptı.";
        public static string UserAlreadyExists ="Bu kulllanıcı daha önce var.";
        public static string AccessTokenCreated ="Token üretildi.";

        public static User PasswordError { get; internal set; }
    }
}
