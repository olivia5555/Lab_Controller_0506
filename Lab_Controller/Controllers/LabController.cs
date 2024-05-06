using Microsoft.AspNetCore.Mvc;

namespace Lab_Controller.Controllers
{
    public class LabController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:port/Lab/Index
        public ActionResult TestText()
        {
            return Content("Hello! World.");
        }

        [ActionName("AboutMe")]
        public ActionResult About()
        {
            return Content("About content");
        }

        public ActionResult TestXML()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "<book><title>bookName</title><price>500</price></book>";
            //result.ContentType = "text/xml";

            ContentResult result = new ContentResult();
            result.Content = "<book><title>bookName</title><price>500</price></book>";
            //result.ContentType = "text/html";
            result.ContentType = "application/xml";
            return result;



        }
        public ActionResult TestRedirect()
        {
            //return Redirect("http://www.hinet.net");
            //return RedirectToAction("Index","Lab");
            return Redirect("/Lab/AboutMe");
            //return Content("text Redirect");
            //return RedirectToAction("Privacy", "Home");
        }

        public ActionResult TestQueryString()
        {
            //int x = 10;
            //string data = $"test:{x}";
            //return Content(data);

            //string result = string.Format("x={0} y={1}",100,"data");
            //    return Content(result, "text/html");

            string result = string.Format(
               "FirstName = {0} <br> LastName = {1}",
               HttpContext.Request.Query["FirstName"],
               HttpContext.Request.Query["LastName"]
               );
            return Content(result, "text/html");

        }
        public ActionResult TestInput(string LastName, string FirstName)
        {
            string result = string.Format(
                "FirstName => {0} <br> LastName => {1}",
                FirstName,
                LastName
                );
            return Content(result, "text/html");
        }

        //public ActionResult TestForm(IFormCollection frm)
        //{
        //    string result = string.Format(
        //        "FirstName :: {0}, LastName :: {1}",
        //        frm["FirstName"], frm["LastName"]);

        //    //return Content("ok I got it");
        //    return Content(result);
        //}

        //public ActionResult TestForm(string LastName, string FirstName)
        //{
        //    string result = string.Format(
        //        "FirName => {0} <br> LastName => {1}",
        //        FirstName,
        //        LastName
        //        );
        //    return Content(result, "text/html");
        //}

        public class  Employee

        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

        }
        public ActionResult TestForm(Employee emp)
        {
            string result = string.Format(
                "FirstName ::> {0} <br> LastName ::> {1}",
                emp.FirstName,
                emp.LastName
                );
            return Content(result, "text/html");
        }

        public ActionResult TestID(string id)
        {
            return Content("ID: " + id);
        }

    }
}

