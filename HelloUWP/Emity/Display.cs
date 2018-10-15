using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUWP.Emity
{
    class Display
    {
        private string _firstName;
        private string _lastName;
        private string _avatar;
        private string _phone;
        private string _address;
        private string _introduction;
        private int _gender;
        private string _birthday;
        private string _email;
        private string _password;

        
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Avatar { get => _avatar; set => _avatar = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public string Introduction { get => _introduction; set => _introduction = value; }
        public int Gender { get => _gender; set => _gender = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
