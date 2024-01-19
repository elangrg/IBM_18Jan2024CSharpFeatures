namespace IBM_18Jan2024CSharpFeatures.Models
{
    internal interface IProduct
    {
        string ProductName { get; set; }

        string GetProductDetails();
    }
}