namespace CustomersApplication.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string IdnetityId { get; set; }

        public UserIdentity Identity { get; set; }
    }
}
