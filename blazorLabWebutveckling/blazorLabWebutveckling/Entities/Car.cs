    namespace blazorLabWebutveckling.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DescriptionShort { get; set; } = string.Empty;
        public string DescriptionLong { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        public decimal PriceEUR { get; set; }
        public int Qty { get; set; }
        public int CarSound { get; set; }

    }
}
