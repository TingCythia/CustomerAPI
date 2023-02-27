namespace CustomerAPI.DataTransferObjects
{
    public class CustomerReadDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? EmailAddress { get; set; }
    }
}
