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
        private Items item;

        public Customer(string name, Image picture, string type)
        {
            Name = name;
            Picture = picture;
            Type = type;
        }

        public string Name 
        { 
            get => name;
            set 
            {
                if (value.Trim() != null)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("mohon isi semua opsi terlebih dahulu");
                }
                
            } 
        }
        public Image Picture { get => picture; set => picture = value; }
        public string Type 
        { 
            get => type;
            set 
            {
                if (value == "male" || value == "female" || value == "kid")
                {
                    type = value;
                }
                else
                {
                    throw new Exception("mohon masukan format yang tepat hanya male, female, atau kid");
                }
            } 
        }

        public string Display()
        {
            if (this.Name == "male")
            {
                return "helo i ";
            }
            return this.Name;
        }
    }
}