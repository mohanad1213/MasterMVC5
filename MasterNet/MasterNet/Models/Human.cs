using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterNet.Models
{
    public class Human
    {
        public string Name { get; set; }
        public int age { get; set; }

        public override bool Equals(object obj)
        {
           Human Human2 = obj as Human;

            if (this.Name == Human2.Name)
                return true;
            else
                return false;
        }

    }
}