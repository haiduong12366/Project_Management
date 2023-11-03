using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.DTO
{
    internal class User
    {

        private int id;
        private string username;
        private string password;
        private string fullname;
        private string email;
        private string phoneNumber;
        private string address;
        private byte[] avatar;
        private int idRole;
        private string idPosition;



        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public int IdRole { get => idRole; set => idRole = value; }
        public string IdPosition { get => idPosition; set => idPosition = value; }
    }
}
