using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Product
    {
    public string _productName;
    public string _serialNumber;
    public DateTime _purchaseDate;
    public double _cost;

    public Product(string productName, string serialNumber, DateTime purchaseDate, double cost)
    {
        ProductName = productName;
        SerialNumber = serialNumber;
        PurchaseDate = purchaseDate;
        Cost = cost;
    }

    public string ProductName { get; set; }
    public string SerialNumber { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double Cost { get; set; }

    public override string ToString()
    {
        return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate), Cost);
    }
}

