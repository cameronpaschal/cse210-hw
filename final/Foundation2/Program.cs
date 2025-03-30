using System;

class Program
{
    static void Main(string[] args)
    {
        Product ball = new Product("Official NCAA Basketball", 1001, 29.99, 3);
        Product poster = new Product("March Madness Bracket Poster", 1002, 14.99, 5);
        Product jersey = new Product("Team Fan Jersey", 1003, 49.99, 10);
        Product hat = new Product("Limited Edition Championship Hat", 1004, 24.99, 35);

        List<Product> products1 = new List<Product>{ball, poster, jersey, hat};
        List<Product> products2 = new List<Product>{ball, jersey, hat};
        List<Product> products3 = new List<Product>{ball, poster, jersey};

        Customer paul = new Customer("Paul");
        Customer james = new Customer("James");
        Customer jimmy = new Customer("Jimmy");

        paul.SetAddress("1824 Hoops Drive", "Indianapolis", "Indiana", "United States");
        james.SetAddress("350 Bracket Way", "Raleigh", "North Carolina", "United States");
        jimmy.SetAddress("12 Maple Court", "Toronto", "Ontario", "Canada");

        Order order1 = new Order(products1, paul);
        Order order2 = new Order(products2, james);
        Order order3 = new Order(products3, jimmy);

        List<Order> orders = new List<Order>{order1, order2, order3};

        int counter = 1;
        foreach (Order order in orders){
            Console.Out.WriteLine("Order "+ counter);
            order.Display();
            Console.Out.WriteLine();
            counter++;
        }







    }
}