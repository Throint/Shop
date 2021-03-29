namespace TestEFC.Models
{
    public class ClientInfo
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string UserMail { get; set; }
        public string Role { get; set; }
        public bool EmailWasConfirmed { get; set; }

        public string Pass { get; set; }
        public string CartList { get; set; }
        public string Salt { get; set; }

    }
    //public class QQQ: Microsoft.AspNetCore.Identity.IdentityUser
    //{
    //    public void d()
    //    {
            
    //    }
    //}
    
}
