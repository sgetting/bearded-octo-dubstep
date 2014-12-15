using System.Collections.Generic;
using System.Web.Mvc;
using HearthstoneCollectionSim.Models;
using Newtonsoft.Json;

namespace HearthstoneCollectionSim.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

         return View();
      }

      public ActionResult TestFunctionPleaseIgnore()
      {
         return Content("bunbunbun");
      }

      public ActionResult Cards()
      {
         //return File("~/Content/AllSets.json","application/json");
         return Content(ProcessCardList(Server.MapPath(@"~/Content/AllSets.json")));
      }

      private static string ProcessCardList(string filename)
      {
         var outputCardList = new List<Card>();

         var inputObject = JsonConvert.DeserializeObject<AllSets>(System.IO.File.ReadAllText(filename));
         foreach (Card inCard in inputObject.Expert)
         {
            inCard.SetName = "Expert";
            outputCardList.Add(inCard);
         }
         foreach (Card inCard in inputObject.CurseOfNaxxramas)
         {
            inCard.SetName = "Naxxramas";
            outputCardList.Add(inCard);
         }
         foreach (Card inCard in inputObject.GoblinsVsGnomes)
         {
            inCard.SetName = "Goblins vs Gnomes";
            outputCardList.Add(inCard);
         }
         foreach (Card inCard in inputObject.Basic)
         {
            inCard.SetName = "Basic";
            outputCardList.Add(inCard);
         }
         foreach (Card inCard in inputObject.Reward)
         {
            inCard.SetName = "Reward";
            outputCardList.Add(inCard);
         }
         foreach (Card inCard in inputObject.Promotion)
         {
            inCard.SetName = "Promotion";
            outputCardList.Add(inCard);
         }
         return JsonConvert.SerializeObject(outputCardList);
      }
   }
}