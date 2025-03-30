public class Product{

    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;

    private double _total;


    public Product(string name, int productID, double pricePerUnit, int quantity){
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
        double temptotal = pricePerUnit * quantity;
        _total = Math.Floor(temptotal * 100) / 100;
    }

    public double GetTotal(){
        return _total;
    }

    public int GetProductID(){
        return _productID;
    }

    public string GetName(){
        return _name;
    }

    public string PackingLabel(){
        return $"Product: {_name} \nProduct ID: {_productID} \nQuantity: {_quantity} \nPrice per each: ${_pricePerUnit} \nTotal price: ${_total}";
    }


}