namespace TechCareerWebApi2.Models
{
    public class WebUserService
    {
        public static List<WebUser> GetWebUsers()
        {
            var webUsers = new List<WebUser>();
            webUsers.Add(new WebUser("kursad@mail.com", 1));
            webUsers.Add(new WebUser("emre@mail.com", 2));
            webUsers.Add(new WebUser("gezer@mail.com", 3));

            return webUsers;

        }
    }
}
