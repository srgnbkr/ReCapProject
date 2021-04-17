using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded => "Araç eklendi";
        public static string ColorAdded => "Renk eklendi";
        public static string BrandAdded => "Model eklendi";
        public static string CarDeleted => "Araç Silindi";
        public static string ColorDeleted => "Renk Silindi";
        public static string BrandDeleted => "Model Silindi";
        public static string CarUpdated => "Araç Güncellendi";
        public static string ColorUpdated => "Renk Güncellendi";
        public static string BrandUpdated => "Model Güncellendi";
        public static string UserAdded => "Kullanıcı Eklendi";
        public static string UserDeleted => "Kullanıcı Silindi";
        public static string UserUpdated => "Kullanıcı Güncellendi";
        public static string CustomerAdded => "Müşteri Eklendi";
        public static string CustomerDeleted => "Müşteri Silindi";
        public static string CustomerUpdated => "Müşteri Güncellendi";
        public static string CarRentListed => "Kiralanan Araçlar Listelendi";
        public static string CarRental => "Araç Kiralandı";
        public static string CarDontRental => "Araç Başka Müşteri Tarafından Kiralanmış";
        public static string CarRentDeleletd => "Araç Kiralama Bilgisi Silindi";
        public static string CarRentUptated => "Araç Kiralama Bilgisi Güncellendi";
        public static string CarRentTimeListed => "Araçlar Tarih Aralığına Göre Listelendi";
        public static string DailyPriceİnvalid => "Günlük Ücret 0'dan küçük olamaz";
        public static string UserNameInvalid => "Kullanıcı Adı Geçersiz";
        public static string EmailInvalid => "Geçersiz Email";
        public static string BrandNameInvalid => "Model ismi geçersiz";
        public static string MaintenanceTime => "Sistem bakımda";
        public static string CarsListed => "Araçlar listelendi";
        public static string ColorsListed => "Renkler listelendi";
        public static string BrandsListed => "Modeller listelendi";
        public static string UserListed => "Kullanıcılar listelendi";
        public static string CustomerListed => "Müşteriler listelendi";

        public static string CarImageNumberError => "Araç için en fazla 5 fotoğraf eklenebilir";

        public static string AddedCarImage => "Fotoğraf Eklendi";
        public static string FailedCarImageAdd => "Fotoğraf Eklenemedi";
        public static string DeletedCarImage => "Fotoğraf Silindi";

        public static string AuthorizationDenied => "Yetkiniz Yok";

        public static string UserRegistered => "Kayıt Oldu";
        public static string UserNotFound => "Kullanıcı bulunamadı";
        public static string SuccessfulLogin => "Başarılı Giriş";
        public static string AccessTokenCreated => "Tokan Oluşturuldu";
        public static string UserAlreadyExists => "Kullanıcı Mevcut";
        public static string PasswordError => "Parola Hatalı ";

        public static string PaymentAdd => "Ödeme Alındı";
        public static string PaymentList => "Ödeme Listelenedi";

        public static string CarRentable => "Araç Kiralanabilir";
    }
}

