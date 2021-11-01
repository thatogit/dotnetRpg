using System.Collections.Generic;

namespace dotnetRpg.Models
{
    public class User
    {
        public int Id { get;set; }
        public string Username { get;set; }
        public byte[] PasswordHash { get;set; }
        public byte[] PasswordSalt { get;set; }
        public List<Character> characters {get;set;}


    }
}