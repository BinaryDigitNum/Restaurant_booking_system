using Restaurant_booking_system.Models;

namespace Restaurant_booking_system.Session
{
    /// <summary>
    ///  This static class will store the currently logged in user account to keep track of activities across the application
    ///  After the user has been logged in to their account, that user account will stored in the "LoggedInUser" and 
    ///  this will keep track of all the user's activities.
    /// </summary>
    public static class Session
    {
        public static Customer? LoggedInUser { get; set; }
        public static Administrator? LoggedInAdmin { get; set; }
        public static bool IsAdmin { get; set; }
        public static bool IsUser { get; set; }
    }
}
