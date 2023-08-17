namespace CheckComplexContent.Models
{
    public partial class SummaryInfo
    {
        public int UserId {get; set;}
        public string FirstName {get; set;} = "";
        public string LastName {get; set;} = "";
        public string Email {get; set;} = "";
    }
}