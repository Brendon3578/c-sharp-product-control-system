namespace ProductControlSystem.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) R$ {Price:F2} (Manufacture Date: {ManufactureDate:dd/MM/yyyy})";
        }
    }
}
