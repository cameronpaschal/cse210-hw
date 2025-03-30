public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name){
        _name = name;
    }

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    

    public bool LivesInUSA(){
        return _address.IsInUSA();
    }

    public string ShippingLabel(){
        return $"{_name} \n{_address.Display()}";
    }

    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country){
        _address = new Address(streetAddress, city, stateOrProvince, country);

    }
}