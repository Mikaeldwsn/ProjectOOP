using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectOOP
{
    public class Merchandise:Items
    {
        private int stock;

        public Merchandise(string name, Image picture, int price, int stock) : base(name, picture, price)
        {
            this.Stock = stock;
        }

        public int Stock 
        { 
            get => stock;
            set
            {
            }
        }

        public override string Display()
        {
            return "anak babi";
        }
    }
}