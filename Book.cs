using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        private int bookId {  get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private DateTime publication { get; set; }
        private List<BookCopy> Copies { get; set; } 

        public Book(int bookId, string title, string author, DateTime publication, int copies)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.publication = publication;
            Copies = new List<BookCopy>();
            for (int i = 0; i < copies; i++) {
                BookCopy book = new BookCopy(i+1, true);
                Copies.Add(book);
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Book Id is:  + {publication}");
            Console.WriteLine($"Title is:  + { title}");
            Console.WriteLine($"Author is:  + {author}");
            Console.WriteLine($"Avaialable Copies:  + {Copies.Count(c => c.isAvailable)}");
            
        }
        public int GetBookId(int id)
        {
            if (id == bookId) 
            { 
                return bookId;
            }
            return -1;
        }
        public bool Issue(Member member)
        {
            foreach (var copy in Copies)
            {
                if (copy.Issue(member))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
