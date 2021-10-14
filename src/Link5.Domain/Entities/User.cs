using System;
using System.Security.Cryptography;
using System.Text;
using Link5.Domain.Common;

namespace Link5.Domain.Entities
{
    public class User : AuditableBaseEntity
    {
        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Verified { get; private set; }
        public bool Active { get; private set; }


        public User(string name, string email, string pass, bool active)
        {
            Fullname = name;
            Email = email;
            Password = pass;
            Active = active;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetVerified(bool value)
        {
            Verified = value;
        }

        public void HashPassword()
        {
            Password = Encode(Password);
        }

        private string Encode(string value)
        {
            SHA512 crypt = new SHA512Managed();
            string hash = String.Empty;
            byte[] encrypted = crypt.ComputeHash(Encoding.UTF8.GetBytes(value));

            foreach (byte theByte in encrypted)
            {
                hash += theByte.ToString("x2");
            }

            return hash;
        }

        public bool VerifyPassword(string password)
        {
            return Password == Encode(password);
        }

    }
}
