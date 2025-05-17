using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

class Book
{
    private static int nextId = 1; 
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }
    public Book(string name, string authorName, double price)
    {
        Id = nextId++;
        Name = name;
        AuthorName = authorName;
        Price = price;
    }

    public string ShowInfo()
    {
        return $"ID: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price:C}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }


}
