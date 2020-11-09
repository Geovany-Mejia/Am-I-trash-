using System.Collections.Generic;

namespace Quiz_22OCT.Models
{
    public static class Repository
    {
        private static List<User> responses = new List<User>();
        public static IEnumerable<User> Responses => responses;
        public static void AddResponse(User response)
        {
            responses.Add(response);
        }
    }
}