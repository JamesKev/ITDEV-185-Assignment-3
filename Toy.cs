namespace ITDEV185
{
    
    class Toy {
        private string name;
        
        private int price;

        public Toy(string name, int price){
            this.name = name;
            this.price = price;
        }
        
        public override string ToString() {
            return name;
        }
    }
    
}