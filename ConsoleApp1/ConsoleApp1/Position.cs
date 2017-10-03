namespace ReadFlatFiles
{
    internal partial class Position
    {
        public PZN ArticleNo { get; set; }
        public Name ArticleName { get; set; }
        public DelQty DeliveryQty { get; set; }

        public Position()
        {
            ArticleNo = new PZN();
            ArticleName = new Name();
            DeliveryQty = new DelQty();
        }

        public override string ToString()
        {
            
            return $"ArticleNo: {ArticleNo.Value} \nArticleName {ArticleName.Value} \nDelQty {DeliveryQty.Value}";
        }
    }
}