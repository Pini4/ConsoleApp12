using ConsoleApp12.Models;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationContext ef = new ApplicationContext();
            Point point = new Point() { Value = "Самара" };
            Point point2 = new Point() { Value = "Москва" };
            Point point3 = new Point() { Value = "Барябинк" };
            Point point4 = new Point() { Value = "Туляти" };
            Point point5 = new Point() { Value = "Нижник" };
            ef.Add(point);
            ef.Add(point2);
            ef.Add(point3);
            ef.Add(point4);
            ef.Add(point5);

            ef.SaveChanges();

        }
    }
}