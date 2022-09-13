using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public void OnGet([FromForm]BuilderForm item) {
            Console.WriteLine($"Name: {item.Name}");
        }

        public ActionResult Index()
        {
            BuilderContext db = new BuilderContext();
            var items = db.BuilderForm;
            var ketqua = from item in items
                         where item.Name == "Item1"
                         select item;
            return View(items);
        }

        //[HttpPost]
        //public JsonResult Index() { 
        
        //}

        [HttpPost]
        public ActionResult Index([FromBody] List<BuilderForm> models)
        {
            //var newdb1 = JsonConvert.DeserializeObject<dynamic[]>(list);
            //JArray newdb = JArray.Parse(list);
            BuilderContext db = new BuilderContext();
            //item.
            //for (int i = 0; i < models.Count; i++) {
            //    model.Name = obj["name"].ToString();
            //    model.Required = ((bool)obj["required"]);
            //    model.HelpText = obj["helptext"].ToString();
            //    model.Buttion = obj["buttion"].ToString();
            //    model.Label = obj["label"].ToString();
            //    model.Option = "new option";
            //    db.Add(model);
            //}
            //db.Remove(List<BuilderForm>);
            foreach (var item in db.BuilderForm)
            {
                db.BuilderForm.Remove(item);
            }
            db.AddRange(models); db.SaveChanges();
            db.SaveChanges();
            //List<BuilderContext> db = new List<BuilderContext>();
            //Console.WriteLine(db);
            return Ok(new
            {
               msg="success"
            });
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //public ActionResult Updatedata()
        //{
        //    var hmtl = new htmlweb();
        //    var document = hmtl.load("https://localhost:7002/");
        //    var document = html.documentnode;
        //    document.queryselectorall(".content");
        //    document.queryselectorall("p");

        //    return index();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}