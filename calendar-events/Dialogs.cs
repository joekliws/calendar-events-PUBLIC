using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar_events
{
    public static class Dialogs
    {
        public static void ShowInitialMessage()
        {
            Console.WriteLine("Welcome to Calendar Events");
        }
        public static bool ShowDetails()
        {
            Console.Write("Would you like to show event details? ");
            var response = Console.ReadLine();
            return response?.Equals("y", StringComparison.CurrentCultureIgnoreCase) ?? false;

        }
    }
}
