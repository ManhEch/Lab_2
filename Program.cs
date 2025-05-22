using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Bai 1a");
            p.bai1a();
            Console.WriteLine("Bai 1b");
            p.bai1b();
            Console.WriteLine("Bai 1c");
            p.bai1c();
            Console.WriteLine("Bai 2a");
            p.bai2a();
            Console.WriteLine("Bai 2b");
            p.bai2b();
            Console.WriteLine("Bai 3");
            Bai3 b3 = new Bai3();
            b3.DisplayStudentInfo();
        }

        public void bai1a()
        {
            dynamic x = 10;
            Console.WriteLine($"x: {x}");
        }

        public void bai1b()
        {
            getDetail(10);
            getDetail("games");
            getDetail(true);
            getDetail(9.5);
        }

        public void getDetail(dynamic value)
        {
            Console.WriteLine($"value: {value}");
        }

        public void bai1c()
        {
            userData data = new userData("2024", "Hide on bush", 100);
            data.getInfo();
        }

        public void bai2a()
        {
            var userInfo = new
            {
                id = "2024",
                name = "faker",
                isPlaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 20
                }
            };

            Console.WriteLine($"id: {userInfo.id}");
            Console.WriteLine($"name: {userInfo.name}");
            Console.WriteLine($"isPlaying: {userInfo.isPlaying}");
            Console.WriteLine($"bag_skins: {userInfo.bag.skins}");
            Console.WriteLine($"bag_cups: {userInfo.bag.cups}");
        }

        public void bai2b()
        {
            int y = 10;

            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine($"sum: {sum}");
                Console.WriteLine($"sub: {sub}");
            };

            AnonymousMethod(5);
        }
    }

    public class userData
    {
        public string id;
        public string username;
        public int level;

        public userData(string id, string username, int level)
        {
            this.id = id;
            this.username = username;
            this.level = level;
        }

        public void getInfo()
        {
            Console.WriteLine($"ID: {id} | UserName: {username} | Level: {level}");
        }
    }
}
