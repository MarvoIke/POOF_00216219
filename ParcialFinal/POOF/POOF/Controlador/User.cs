using System;

namespace POOF
{
    public class User
    {
        public int idUser { get; set; }
        public int idZone { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string dui { get; set; }
        public DateTime birthDate { get; set; }
        
        
        public User() {}
        
        public User(int pIdUser , int pIdZone, string pPass, string pName, string pLastN, string pDui, DateTime birth)
        {
            idUser = pIdUser;
            idZone = pIdZone;
            password = pPass;
            name = pName;
            lastName = pName;
            dui = pDui;
            birthDate = birth;
        }
    }
}