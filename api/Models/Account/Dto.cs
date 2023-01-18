namespace api.Models.Account
{
    public class Dto
    {
        public class CreateAccount
        {
            [Required]
            public string Name { get; set; } = string.Empty;

            [Required]
            public string Last { get; set; } = string.Empty;
        }

        public class UpdateAccount
        {
            [Required]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; } = string.Empty;

            [Required]
            public string Last { get; set; } = string.Empty;
        }

        public class DeleteAccount
        {
            [Required]
            public int Id { get; set; }
        }
    }
}