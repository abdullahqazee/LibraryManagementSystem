using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private string name { get; set; }
        private string Address { get; set; }
        private List<Book> books { get; set; }
        private List<Member> members { get; set; }

        public Library(string name, string address)
        {
            this.name = name;
            this.Address = address;
            books = new List<Book>();
            members = new List<Member>();
        }

        public void GetDetails()
        {
            Console.WriteLine($"name is: +{name}");
            Console.WriteLine($"Address is: +{Address}");
            foreach (var book in books)
            {
                book.GetDetails();
            }
            foreach (var member in members)
            {
                member.GetDetails();
            }

        }
        public void AddBook(int bookId, string title, string author, DateTime publication, int copies)
        {
            Book book = new Book(bookId, title, author, publication, copies);
            books.Add(book);
        }

        public void RemoveBook(int bookid)
        {
            Book book1 = null;
            foreach (var book in books)
            {
                if (book.GetBookId(bookid) > 0)
                {
                    book1 = book;
                    break;
                }
            }
            if (book1 != null)
            {
                books.Remove(book1);
            }

        }
        public void IssueBook(int bookid, int memberId)
        {
            Member member1 = null;
            foreach (var member in members)
            {
                if (member.GetMemberId(memberId) >= 0)
                {
                    member1 = member;
                    break;
                }
            }
            if (member1 != null)
            {
                Book book1 = null;
                foreach (var book in books)
                {
                    if (book.GetBookId(bookid) >= -1)
                    {
                        book1 = book;
                        break;
                    }
                }
                if (book1 != null)
                {
                book1.Issue(member1);
                }
            }
        }
        public void AddMember(int id, string name, string barCode) {
        Member member= new Member(id, name, barCode);  
            members.Add(member);
        }
    }
}