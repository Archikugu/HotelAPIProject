namespace HotelProject.WebUI.Dtos.TestimonialDto
{
    public class ResultTestimonilDto
    {
        public int TestimonialID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName?.ToUpper()}";
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
