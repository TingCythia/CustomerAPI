namespace CustomerAPI.DataTransferObjects
{
    public class CustomerUpdateDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmailAddress { get; set; }
    }
}
