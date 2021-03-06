//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppStock.Model
{
    using AppStock.App_Code;
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    public partial class Utilisateur
    {
        private MD5 md5Hash;

        public int IdUtilisateur { get; set; }
        public string Identifiant { get; set; }
        public string MotDePasse { get; private set; }
        public string Email { get; set; }
        public string Status { get; set; }


        public void SetPassword(string pwd)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                MotDePasse = Helper.GetMd5Hash(md5Hash, pwd);
            }

           
        }
    }
}
