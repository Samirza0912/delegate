using System;
using delegate_.Models;

namespace delegate_
{
    interface IEntity
    {
        private static int _Id;
        public int Id { get; }
        public void IEntity(int id)
        {
            _Id = id;
            _Id++;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("please enter the count: ");
            int type_count = int.Parse(Console.ReadLine());

            Book[] books = new Book[type_count];
            for (int i = 0; i < type_count; i++)
            {
                Console.WriteLine("Please enter the name:  ");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter the pagecount:  ");
                int pagecount = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the authorname:  ");
                string authorname = Console.ReadLine();

                books[i] = new Book(name, authorname, pagecount);
                Library library = new Library()
                {
                    
                }


                do
                {
                    int p = Check("Menu Bar\n1-Add book\n2-Get book by id\n3-Get all books\n4-Delete book by id\n5-Edit book name\n6-Filter by page count\n0-quit");
                    if (p == 3)
                    {
                        foreach (var item in books)
                        {
                            item.ShowInfo();

                            Console.WriteLine("++++++++++++++++++++++");
                        }
                    }
                    else if (p == 6)
                    {
                        Console.Write("Enter min PageCount= ");
                        double MinCount = double.Parse(Console.ReadLine());
                        Console.Write("Enter max PageCount= ");
                        double MaxCount = double.Parse(Console.ReadLine());
                        for (int i = 0; i < type_count; i++)
                        {
                            if (MinCount <= books[i].PageCount && MaxCount >= books[i].PageCount)
                            {
                                books[i].ShowInfo();
                            }
                        }
                    }
                    else if (p == 1)
                    {
                        Console.WriteLine("Enter the new book name: ");
                        string name1 = Console.ReadLine();
                        library.AddBook(name1);
                    }
                    else if (p==2)
                    {
                        library.GetBookById();
                    }
                    else if (p==4)
                    {
                        library.DeleteBookById();
                    }
                    else if (p==5)
                    {

                    }
                    else if (p == 0)
                    {
                        return;
                    }

                } while (true);


                static int Check(string name)
                {
                    int n;

                    do
                    {
                        Console.Write(name);
                        n = int.Parse(Console.ReadLine());

                    } while (n > 6 || n < 0);
                    return n;
                }
            }

        }
        
    }

}
