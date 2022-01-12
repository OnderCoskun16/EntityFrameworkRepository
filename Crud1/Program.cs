using System;
using System.Collections.Generic;
using System.Linq;

namespace Crud1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Kullanıcı Eklemek için I\n");
            Console.WriteLine("Kullanıcı Güncellemek için U\n");
            Console.WriteLine("Kullanıcı Silmek için D\n lİSTELEMEK İÇİN R TUŞU");
            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == 'I')
            {
                Console.WriteLine("Kullanıcı Adı Giriniz");
                string UserName = Console.ReadLine();

                Console.WriteLine("Şifre Giriniz");
                string password = Console.ReadLine();

                User user = new User();
                user.UserName = UserName;
                user.Password = password;

                AppDbContext dbContext = new AppDbContext();
                dbContext.Kullanici.Add(user);
                dbContext.SaveChanges();



            }

            if (operation == 'U')
            {
                Console.WriteLine("Kullanıcı ID Giriniz");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Email Giriniz");
                string email = Console.ReadLine();

                AppDbContext dbContext = new AppDbContext();
                User user = dbContext.Kullanici.Find(ID);
                user.Email = email;

                dbContext.SaveChanges();
            }

            if (operation == 'D')
            {
                Console.WriteLine("Kullanıcı ID Giriniz");
                int ID = Convert.ToInt32(Console.ReadLine());

                AppDbContext dbContext = new AppDbContext();
                User user = dbContext.Kullanici.Find(ID);
                dbContext.Kullanici.Remove(user);
                dbContext.SaveChanges();

            }

            if (operation == 'R')
            {
                // Kullanıcıları Listele
                AppDbContext dbContext = new AppDbContext();
                List<User> users = dbContext.Kullanici.ToList();

                Console.WriteLine("UserName \t Email \t CreDate");
                foreach (var kull in users)
                {
                    Console.WriteLine($"{kull.UserName} \t {kull.Email} \t {kull.CreDate} \t");
                }                

            }
            Console.ReadKey();
        }

    }
}
