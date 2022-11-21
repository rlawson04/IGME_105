using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HW_6_Character_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Mage shiro = new Mage("shiro", 100, 5, false, r);

            Console.WriteLine(shiro.ToString());
            Console.WriteLine($"{shiro.Name} attacks with {shiro.Attack()} damage!");
            Console.WriteLine($"{shiro.Name} takes 60 damage!");
            shiro.TakeDamage(60);
            
            Console.WriteLine(shiro.ToString());
            Console.WriteLine(shiro.IsDead);

            
        }
    }
}