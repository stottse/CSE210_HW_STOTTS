using System.ComponentModel;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        
    }

    //The following is to Add products to the order:
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }

    //The following gets the total cost of the order:
    public double TotalCost()
    {
        
            double totalCost = 0;
            foreach (Product i in _products)
            {
                totalCost += i.TotalCost;

            }
            return totalCost + _customer.GetShippingCost();

    }

    //The following gets the packing labe for the order:
    public string GetPackingLabel()
    {
        
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"Name: {product.Name}, ID: {product.ProductId} \n";

            }
            return label;
    }

    //The following gets the shipping label for the order:
    public string GetShippingLabel()
    {
        return "Shipping Label: \n" + _customer.ToString();
    }




}