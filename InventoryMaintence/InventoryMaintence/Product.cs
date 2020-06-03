using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintence
{
    public class Product
    {
        public String Code { get; set;}
        public String Description { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }
        public Product(String code, String description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public virtual String getDisplayText()
        {
            return Code + "\t" + Description + "\t(€" + Price + ")";
        }
    }
    public class Plant : Product
    {
        public String Size { get; set; }

        public Plant(String size, String code, String description, decimal price) :base(code, description, price)
        {
            this.Size = size;
        }
        public override String getDisplayText()
        {
            return Code + "\t" + Size + "\t" + Description + "\t"+"(€" + Price + ")";
        }
    }
    public class Supply: Product
    {
        public String Manufacturer { get; set; }

        public Supply(String manufacturer, String code, String description, decimal price) : base(code, description, price)
        {
            this.Manufacturer = manufacturer;
        }
        public override String getDisplayText()
        {
            return Code + "\t" + Manufacturer + "\t" + Description + "\t" + "(€" + Price + ")";
        }
    }
}
