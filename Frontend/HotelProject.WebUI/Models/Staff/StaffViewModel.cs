namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName?.ToUpper()}";
        public string Title { get; set; }
    }
}
