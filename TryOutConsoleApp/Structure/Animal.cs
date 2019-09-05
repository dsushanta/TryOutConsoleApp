using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp.Structure
{
    struct Animal
    {
        public string color { get; set; }
        string name { get; set; }
        string location { get; set; }
        bool canFly { get; set; }

        public Animal(string color, string name, string location, bool canFly)
        {
            this.color = color;
            this.name = name;
            this.location = location;
            this.canFly = canFly;
        }

        public override string ToString()
        {
            return "[ " +
                "Color = " + color +
                ", Name = " + name +
                ", Location = " + location +
                ", Can Fly = " + canFly;
        }
    }
}
