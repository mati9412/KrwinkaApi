namespace Krwinka.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Payment { get; set; }
        public string Barcode { get; set; } = default!;
        public bool PaymentMethodIsCard { get; set; }
        public DateTime CreateDate { get; set; }
        public Person Person { get; set; } = default!;
        public Guid PersonId { get; set; }
        public List<LabTest> LabTests { get; set; } = new();

    }
}