

namespace ITDEV185
{
    
    class Book {
        
        private string name;
        private string author;
        private int pages;

        public Book(string name, string author, int pages){
            this.name = name;
            this.author = author;
            this.pages = pages;
        }
        
        public override string ToString() {
            return name;
        }
    }
    
}