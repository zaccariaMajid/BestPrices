namespace API_pcto.Entities
{
    public class Prodotto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Link { get; set; }
        public string PathPhoto { get; set; }
        public string IdEcommerce { get; set; }

        public int Position { get; set; }
    }
}
