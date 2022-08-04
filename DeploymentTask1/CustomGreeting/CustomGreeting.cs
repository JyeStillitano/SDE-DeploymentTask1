using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGreeting
{
    public class CustomGreeting
    {
        public static string WelcomeGreeting(string name) { return "Welcome " + name + ", thank's for using My Custom Greeter DLL."; }
        public static string GdayGreeting(string name) { return "G'day " + name + ", thank's for using My Custom Greeter DLL."; }
        public static string WhatsUpGreeting(string name) { return "What's up " + name + "? Thank's for using My Custom Greeter DLL."; }
    }
}
