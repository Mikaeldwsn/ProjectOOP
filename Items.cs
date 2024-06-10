using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public abstract class Items
    {
        private string name;
        private Image picture;
        private int price;

        protected Items(string name, Image picture, int price)
        {
            this.name = name;
            this.picture = picture;
            this.price = price;
        }

        protected Items(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Items()
        {

        }
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Price { get => price; set => price = value; }

        public string DipslayItems()
        {
            string data = "";
            data = "Nama item: " + this.Name + "\nHarga:"+this.Price+"\n";
            return data;
           
        }

        public abstract void Display();
    }
}