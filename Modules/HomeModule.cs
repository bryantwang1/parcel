using Nancy;
using Parcel.Objects;

namespace Parcel
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ => {
            return View["form.cshtml"];
            };
        }
    }
}
