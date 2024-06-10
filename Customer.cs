using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Customer
    {
        private string name;
        private Image picture;
        private string type;

        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public string Type 
        { 
            get => type;
            set 
            { 
                type = value; 
            } 
        }
    }
}