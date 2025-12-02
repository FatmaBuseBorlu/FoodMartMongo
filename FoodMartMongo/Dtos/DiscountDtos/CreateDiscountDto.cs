namespace FoodMartMongo.Dtos.SliderDtos
{
    public class CreateDiscountDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime CreatedDate { get; set; } = System.DateTime.Now;
    }
}
