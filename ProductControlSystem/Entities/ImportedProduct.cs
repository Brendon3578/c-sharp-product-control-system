namespace ProductControlSystem.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public override double Price { get => base.Price + CustomsFee; set => base.Price = value; }
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} R$ {Price:f2} (Customs fee: {CustomsFee:f2})";

        }
    }
}
