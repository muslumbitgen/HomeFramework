using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Business.Constants
{
    public class Messages
    {
        //makale işlemleri
        public static string ArticleAdded = "Makale başarayla eklendi.";
        public static string ArticleUpdated = "Makale başarayla güncellendi.";
        public static string ArticleDeleted = "Makale başarayla silindi.";
        //user işlemleri
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessFullLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcutta bulunmaktadır.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
    }
}
