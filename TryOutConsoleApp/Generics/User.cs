using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Generics
{
    class User
    {
        private string firstName;
        private string lastName;

        public User(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
