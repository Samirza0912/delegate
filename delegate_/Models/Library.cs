using System;
using System.Collections;
using System.Collections.Generic;
using delegate_.Exceptions;

namespace delegate_.Models
{
    public class Library : IEntity
    {
        /*Utils bir class library olacaq
 - Enums folder
   - Role - Admin və Member rolları olacaq içində və default olaraq 1-dən başlayacaq.
 - Exceptions folder
   - CapacityLimitException
   - AlreadyExistsException
   - NotFoundException*/
        public int BookLimit = 10;
        private List<Book> books = new List<Book>();

        public int Id => throw new NotImplementedException();

        public void AddBook(Book book1)
        {
            if (books.Count == 0)
            {
                throw new CapacityLimitException("Capacity is overloaded");
            }
            foreach (var item in books)
            {
                if (item.IsDeleted == false && item.Name == book1.Name)
                {
                    throw new AlreadyExistsException("the book that you want to add is already exist");
                }
                else
                {
                    books.Add(book1);
                }
            }
        }
        public void GetBookById(int? id)
        {
            foreach (var item in books)
            {
                if (id == item.Id && item.IsDeleted == false && id != null)
                {
                    item.ShowInfo();
                }
            }
        }
        public void GetAllBooks()
        {
            List<Book> book = new List<Book>();
            foreach (var item in books)
            {
                book.Add(item);
                books.Remove(item);

            }

        }
        public void DeleteBookById(int? id)
        {
            foreach (var item in books)
            {
                if (id == item.Id && item.IsDeleted == false && id != null)
                {
                    item.IsDeleted = true;
                }
            }
        }

    }    
}
