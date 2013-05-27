using Nancy;

namespace WebSite.Modules
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ => "hello.";
        }
    }
}