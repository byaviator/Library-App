using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

class Library
{
    public string Name { get; private set; }
    private List<Book> books; 

    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book GetBookById(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public void RemoveBook(int id)
    {
        Book bookToRemove = GetBookById(id);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book with ID {id} has been removed.");
        }
        else
        {
            Console.WriteLine($"Book with ID {id} not found.");
        }
    }

    public List<Book> GetBook(string name)
    {
        return books.Where(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void GetAllBooks()
    {
        Console.WriteLine("List of all books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void Update(int id, Book newBookData)
    {
        Book bookToUpdate = GetBookById(id);
        if (bookToUpdate != null)
        {
            bookToUpdate.Name = newBookData.Name;
            bookToUpdate.AuthorName = newBookData.AuthorName;
            bookToUpdate.Price = newBookData.Price;
            Console.WriteLine($"Book with ID {id} has been updated.");
        }
        else
        {
            Console.WriteLine($"Book with ID {id} not found.");
        }
    }
}
