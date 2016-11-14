using Nancy;
using MadLibs.Objects;

namespace MadLibs
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/form"] = _ => {
            return View["form.cshtml"];
            };
            Get["/story"] = _ => {
            StoryVariables myStoryVariables = new StoryVariables();
            myStoryVariables.SetPerson1(Request.Query["person1"]);
            myStoryVariables.SetPerson2(Request.Query["person2"]);
            myStoryVariables.SetAnimal(Request.Query["animal"]);
            myStoryVariables.SetExclamation(Request.Query["exclamation"]);
            myStoryVariables.SetVerb1(Request.Query["verb1"]);
            myStoryVariables.SetVerb2(Request.Query["verb2"]);
            myStoryVariables.SetVerb3(Request.Query["verb3"]);
            myStoryVariables.SetNoun1(Request.Query["noun1"]);
            myStoryVariables.SetNoun2(Request.Query["noun2"]);
            return View["story.cshtml", myStoryVariables];
            };
        }
    }
}
