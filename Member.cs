using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Member
    {
        private int id { get; set; }
        private string name { get; set; }
        private string barCode { get; set; }
        private List<BookCopy> checkedOutBooks { get; set; }
        private double fine { get; set; }

        public Member(int id, string name, string barCode)
        {
            this.id = id;
            this.name = name;
            this.barCode = barCode;
            checkedOutBooks = new List<BookCopy>();
            this.fine = 0;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"barcode is: {barCode}");
            foreach (var book in checkedOutBooks)
            {
                book.GetDetails();
            }
        }
        public void AddFine(int a)
        {
            fine += 2 * a;
        }
        public void RemoveFine(double amount)
        {
            if (fine >= amount)
            {
                fine -= amount;
            }
        }
        public void GetCheckedOutBooks()
        {
            foreach (var book in checkedOutBooks)
            {
                book.GetDetails();
            }
        }

        public void AddCheckoutBooks(BookCopy book)
        {
            checkedOutBooks.Add(book);
        }

        public void RemoveCheckoutBooks(BookCopy book)
        {
            checkedOutBooks.Remove(book);
        }

        public void GetFine()
        {
            Console.WriteLine($"Fine on Member is: + {this.fine}");
        }

        public int GetMemberId(int Id)
        {
            if (Id == id)
            {
                return id;
            }
            return -1;
        }
    }
}
