// https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite
using System;

namespace Core1Console
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
            Console.WriteLine("Hello World 1!");
        }
    }
}

