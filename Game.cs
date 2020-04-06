using System;
namespace ITDEV185
{
    
    class Game {
        
        public void run(){
            string answer = "";
            Console.WriteLine("Welcome to your personal shelf.");
            Console.WriteLine("Here you can store Toys or Books.\n" + 
                                "Which would you like to store?");

            do{
                if(!answer.Equals("")){
                    Console.WriteLine("Please enter toys or books");
                }

                answer = Console.ReadLine();

                answer = answer.ToLower();

            }while(!answer.Equals("toys") && !answer.Equals("books"));
            

            if(answer.Equals("toys")){
                Shelf<Toy> shelf = new Shelf<Toy>();
                toyShelf(shelf);
            } else {
                Shelf<Book> shelf = new Shelf<Book>();
                bookShelf(shelf);
            }
            

        }

        private void bookShelf(Shelf<Book> shelf){
            int option  = 0;
            while(option != 4){
                Console.WriteLine("Here you can edit your bookshelf.");
                Console.WriteLine("What would you like to do?");

                Console.WriteLine(  "1. Add a book.\n" + 
                                    "2. Take a book.\n" +
                                    "3. List the books\n" +
                                    "4. Quit.\n"
                    );
                

                int.TryParse(Console.ReadLine(),out option);
                switch (option)
                {
                    case 1:
                        addBook(shelf);
                        break;
                    case 2: 
                        removeBook(shelf);
                        break;
                    case 3:
                        listBooks(shelf);
                        break;
                    default:
                        // do nothing
                        break;
                }
            }
        }  

        private void addBook(Shelf<Book> shelf){
            Console.WriteLine("Please enter the book name.");
            string name = Console.ReadLine();
            
            Console.WriteLine("Please enter the author's name.");
            string author = Console.ReadLine();

            Console.WriteLine("Please enter the number of pages.");
            int pages = -1;
            int.TryParse(Console.ReadLine(),out pages);

            if(pages > 0  ){
                Book book = new Book(name,author,pages);
                shelf.Add(book);
            } else {
                Console.WriteLine("Invalid number of pages");
            }

            
        }
        private void removeBook(Shelf<Book> shelf){
            Console.WriteLine("Enter a book index");
            int choice = -1;
            int.TryParse(Console.ReadLine(),out choice);
            if(choice == -1){
                Console.WriteLine("invalid input");
            } else if(choice >= shelf.getSize() && choice < 0){
                Console.WriteLine("Input is out of range");
            } else {
                shelf.Remove(choice);
            }
        }
        private void listBooks(Shelf<Book> shelf){
            shelf.printList();
        }




        private void toyShelf(Shelf<Toy> shelf){
            int option  = 0;
            while(option != 4){
                Console.WriteLine("Here you can edit your bookshelf.");
                Console.WriteLine("What would you like to do?");

                Console.WriteLine(  "1. Add a toy.\n" + 
                                    "2. Take a toy.\n" +
                                    "3. List the toys\n" +
                                    "4. Quit.\n"
                    );
                

                int.TryParse(Console.ReadLine(),out option);
                switch (option)
                {
                    case 1:
                        addToy(shelf);
                        break;
                    case 2: 
                        removeToy(shelf);
                        break;
                    case 3:
                        listToys(shelf);
                        break;
                    default:
                        // do nothing
                        break;
                }
            }
        }

        private void addToy(Shelf<Toy> shelf){
            Console.WriteLine("Please enter the toy name.");
            string name = Console.ReadLine();
            

            Console.WriteLine("Please enter the price.");
            int price = -1;
            int.TryParse(Console.ReadLine(),out price);

            if(price > 0  ){
                Toy toy = new Toy(name,price);
                shelf.Add(toy);
            } else {
                Console.WriteLine("Invalid price");
            }

            
        }
        private void removeToy(Shelf<Toy> shelf){
            Console.WriteLine("Enter a Toy index");
            int choice = -1;
            int.TryParse(Console.ReadLine(),out choice);
            if(choice == -1){
                Console.WriteLine("invalid input");
            } else if(choice >= shelf.getSize() && choice < 0){
                Console.WriteLine("Input is out of range");
            } else {
                shelf.Remove(choice);
            }
        }
        private void listToys(Shelf<Toy> shelf){
            shelf.printList();
        }


        
    }
    
}