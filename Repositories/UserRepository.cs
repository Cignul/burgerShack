using System;
using System.Data;
using System.Linq;
using BCrypt.Net;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class UserRepository
  {
    IDbConnection _db;
    SaltRevision SALT = SaltRevision.Revision2X;
    //register C

    public User Register(UserRegistration creds)
    {
      //generate the user id
      //hash the password

      string id = Guid.NewGuid().ToString();
      string hash = BCrypt.Net.BCrypt.HashPassword(creds.Password, SALT);
      int success = _db.Execute(@"
          INSERT INTO users (id, username, email, hash)
          VALUES (@id, @username, @email, @hash);
      ", new
      {

        id,
        username = creds.Username,
        email = creds.Email,
        hash
      });

      if (success != 1) { return null; }

      return new User()
      {
        Username = creds.Username,
        Email = creds.Email,
        Hash = null,
        Id = id
      };


    }
    //login  R

    public User Login(UserLogin creds)
    {
      User user = _db.Query<User>(@"
     SELECT * FROM users WHERE email = @Email
     ", creds).FirstOrDefault();
      if (user == null) { return null; }
      bool validPass = BCrypt.Net.BCrypt.Verify(creds.Password, user.Hash);
      if (!validPass) { return null; }
      user.Hash = null;
      return user;
    }


    //update U
    //change password U
    //delete D


    public UserRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}