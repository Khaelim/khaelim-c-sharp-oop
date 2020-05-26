using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopper khae = new Shopper(1, 23, "Male");
            Regular me = new Regular("Khaelim", 2, 33, "MaleIsh");
            Mystery notMe = new Mystery("Electrical", 3, 40, "Female");

            Console.WriteLine(khae.DisplayShopperInfo());
            Console.WriteLine(me.DisplayShopperInfo());
            Console.WriteLine(notMe.DisplayShopperInfo());
            Console.ReadKey();
        }
    }

    public class Shopper
    {
        public int id { get; set; }
        public int age { get; set; }
        public String gender { get; set; }
        public Shopper(int id, int age, String gender)
        {
            this.id = id;
            this.age = age;
            this.gender = gender;
        }
        public virtual String DisplayShopperInfo()
        {
            return "ID: "+id+", Age: "+age+", Gender: "+gender;
        }
    }
    public class Regular : Shopper
    {
        public String name { get; set; }
        public Regular(String name,int id, int age, String gender):base(id, age, gender)
        {
            this.name = name;
        }
        public override String DisplayShopperInfo()
        {
            return "Name: "+name+", "+base.DisplayShopperInfo();
        }
    }
    public class Mystery : Shopper
    {
        public String area { get; set; }
        public Mystery(String area, int id, int age, String gender) : base(id, age, gender)
        {
            this.area = area;
        }
        public override String DisplayShopperInfo()
        {
            return "Area: " + area + ", " + base.DisplayShopperInfo();
        }
    }


}
