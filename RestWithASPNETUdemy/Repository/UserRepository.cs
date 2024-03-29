﻿using RestWithASPNETUdemy.Data;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Security.Cryptography;
using System.Text;

namespace RestWithASPNETUdemy.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public User ValidateCredentials(string userName)
        {
            return _context.Users.SingleOrDefault(u => (u.UserName == userName));
        }
        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(p => p.Id.Equals(user.Id))) return null;
            
            var result = _context.Users.SingleOrDefault(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;


        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.UserName == user.Username) && (u.Password == pass));
        }



        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
            
        }
    }
}
