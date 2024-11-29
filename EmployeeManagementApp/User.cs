using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    class User
    {
        // data fields
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Bonus { get; set; }

        public User(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Bonus = 0.0;
        }

    }
}
