// See https://aka.ms/new-console-template for more information
using LibraryManagementSystem;

Console.WriteLine("Hello, World!");
Library library =new Library("ABC","Street 15");
library.AddBook(101,"To kill a mockingbird", "Harper Tee", new DateTime(1960,7,11),5);
library.AddMember(1, "Sarah", "982672");

library.IssueBook(101, 1);
library.GetDetails();
