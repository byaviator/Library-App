namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("City Library");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Get all books");
                Console.WriteLine(". Quit");
                Console.Write("Please select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book name: ");
                        string bookName = Console.ReadLine();
                        Console.Write("Enter author name: ");
                        string authorName = Console.ReadLine();
                        Console.Write("Enter price: ");
                        double price = double.Parse(Console.ReadLine());
                        library.AddBook(new Book(bookName, authorName, price));
                        Console.WriteLine("Book added successfully.");
                        break;

                    case "2":
                        Console.Write("Enter book ID to get: ");
                        int idToGet = int.Parse(Console.ReadLine());
                        Book bookFound = library.GetBookById(idToGet);
                        if (bookFound != null)
                        {
                            Console.WriteLine(bookFound);
                        }
                        else
                        {
                            Console.WriteLine($"Book with ID {idToGet} not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter book ID to remove: ");
                        int idToRemove = int.Parse(Console.ReadLine());
                        library.RemoveBook(idToRemove);
                        break;

                    case "4":
                        Console.Write("Enter book ID to update: ");
                        int idToUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Enter new book name: ");
                        string newBookName = Console.ReadLine();
                        Console.Write("Enter new author name: ");
                        string newAuthorName = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        library.Update(idToUpdate, new Book(newBookName, newAuthorName, newPrice));
                        break;

                    case "5":
                        library.GetAllBooks();
                        break;

                    case "":
                        Console.WriteLine("Exiting the application.");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }


        }
    }
}
