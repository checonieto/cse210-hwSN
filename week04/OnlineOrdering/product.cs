public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    // Getters and Setters
    public string Name { get => _name; set => _name = value; }
    public string ProductId { get => _productId; set => _productId = value; }
    public double Price { get => _price; set => _price = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }
}