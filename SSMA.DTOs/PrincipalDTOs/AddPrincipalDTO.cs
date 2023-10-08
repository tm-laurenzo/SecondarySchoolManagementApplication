namespace SSMA.DTOs.PrincipalDTOs
{
    public class AddPrincipalDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string? PublicId { get; set; }
        public string? Avatar { get; set; }
        public DateTime PostionStartDate { get; set; }
        public DateTime PostionEndtDate { get; set; }
    }
}
