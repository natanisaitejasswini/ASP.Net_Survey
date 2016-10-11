using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Surveyspace.Controllers
{
 public class SurveyController : Controller
 {
  [HttpGet]
  [Route("index")]
  public IActionResult Survey()
  { 
        //TO Display Survey Page
        return View("Survey");
  }

  // Post Method::: To take Survey Details
  [HttpPost]
  [Route("users")]
  public IActionResult create(string first_name, string location, string language, string comments)
  { 
        ViewBag.name = first_name;
        ViewBag.location = location;
        ViewBag.language = language;
        ViewBag.comments = comments;
        return View("Display");
  }
 }
}

