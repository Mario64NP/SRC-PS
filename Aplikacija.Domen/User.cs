using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class User : IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string TableName => "Korisnik";
        public string InsertValues => string.Empty;
        public string UpdateValues => string.Empty;
        public string RecordID => string.Empty;
        public string Join => string.Empty;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User() { }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> users = new List<IEntity>();
            while (reader.Read())
            {
                User u = new User();
                u.Username = (string)reader[1];
                u.Password = (string)reader[2];
                users.Add(u);
            }
            return users;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is User u && u.Username == Username && u.Password == Password;
        }
    }
}