namespace Domain.Model.AddLookups
{
    public class LkpBrothersDiscountRate
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string DiscountType { get; set; }
        public int? BrotherSeq { get; set; }
    }
}
