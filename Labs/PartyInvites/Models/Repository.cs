using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        // private field
        private static List<GuestResponse> responses = new List<GuestResponse>();
        // public property
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
