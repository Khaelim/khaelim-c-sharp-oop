using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShopperExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Regular me = new Regular("Khae", 1, 22, "Male");
            Mystery notMe = new Mystery("Over There", 1, 22, "Unknown");

            Console.WriteLine(me.DisplayShopperInfo());
            Console.WriteLine(notMe.DisplayShopperInfo());
            Console.ReadKey();
        }
    }

    public abstract class Shopper
    {
        public int id { get; set; }
        public int age { get; set; }
        public String gender { get; set; }
        public abstract String DisplayShopperInfo();
    }
    public class Regular : Shopper
    {
        public String name { get; set; }
        public Regular(String name, int id, int age, String gender)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.gender = gender;
        }
        public override String DisplayShopperInfo()
        {
            return "Name: " + name + ", " + "ID: " + id + ", Age: " + age + ", Gender: " + gender;
        }
    }
    public class Mystery : Shopper
    {
        public String area { get; set; }
        public Mystery(String area, int id, int age, String gender)
        {
            this.area = area;
            this.id = id;
            this.age = age;
            this.gender = gender;
        }
        public override String DisplayShopperInfo()
        {
            return "Area: " + area + ", " + "ID: " + id + ", Age: " + age + ", Gender: " + gender;
        }
    }

}
