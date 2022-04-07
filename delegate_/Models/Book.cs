using System;
namespace delegate_.Models
{
    public class Book : IEntity
    {
        /*Book class (IEntity-ni implement edəcək)
  - Name
  - AuthorName
  - PageCount
  - IsDeleted - book obyektinin silinib silinmədiyini göstərən bir statusdur true/false olur default olaraq false olur yəni silinməmiş
  - ShowInfo()*/
        public int Id => throw new NotImplementedException();
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }


        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            IsDeleted = false;
        }

        public Book()
        {
        }


        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}/n Name:{Name}/n Author:{AuthorName}/n Pagecount:{PageCount}");
        }
    }
}
