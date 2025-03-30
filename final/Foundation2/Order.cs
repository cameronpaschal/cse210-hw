

public class Order{

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private double _totalPrice;
    private double _shipping;


    public Order(List<Product> products, Customer customer){
        _products = products;
        _customer = customer;
        _totalPrice = 0.0;
        CalculatePrice();
    }

    public void CalculatePrice(){
        double productTotal = 0;

        foreach(Product product in _products){
            productTotal = productTotal + product.GetTotal();
        }
        if(_customer.LivesInUSA()){
            productTotal = productTotal + 5.00;
            _shipping = 5.00;
        }
        else{
            productTotal = productTotal + 35.00;
            _shipping = 35.00;
        }

        _totalPrice = Math.Floor(productTotal * 100) / 100;
    }

    public void Display(){
        Console.Out.WriteLine($"Shipping Label: \n{_customer.ShippingLabel()}\n");
        Console.Out.WriteLine("Packing Label:");
        foreach(Product product in _products){
            Console.Out.WriteLine($"{product.PackingLabel()}\n");
        }
        Console.Out.WriteLine($"Shipping Cost: ${_shipping}");
        Console.Out.WriteLine($"Total Price: ${_totalPrice}");

    }




}