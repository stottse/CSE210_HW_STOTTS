public class Product
{
    private string _productName;
    private string _productId;
    private double _productCost;
    private int _productQuantity;

    public Product (string productName, string productId, double productCost, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productCost = productCost;
        _productQuantity = productQuantity;


    }

    //The following gets the total cost for the order:
    public double TotalCost
    {
        get {return (_productCost * _productQuantity);}

    }
    public string Name {get {return _productName;}}
    public string ProductId { get { return _productId;}}


}