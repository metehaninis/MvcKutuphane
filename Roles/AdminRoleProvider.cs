using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Roles
{
    public class AdminRoleProvider : RoleProvider
    {
        // Burası rollerle ilgili metotların altında yapılabilecek bazı etkileşimlerin bulunduğu sınıf değerleri
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)     //yeni bir rol oluşturulduğunda neler olmalı
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()    //örn. bütün rol değerleri geldiğinde ne olsun
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            DbKutuphaneEntities db = new DbKutuphaneEntities();
            var deger = db.TBLADMIN.FirstOrDefault(x => x.Kullanici == username); // kullanıcı adı dışarıdan gelen username e eşit olmalı
            return new string[] { deger.Yetki };  //string olarak bana geriye bir dizi döndür içerisinde deger.yetki olucak böylece sisteme authantice olan kullanıcının yetkisini alabilcez  
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}