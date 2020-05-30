using System.Web.Mvc;

namespace TestingDemo.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();

            return View();
        }
    }
}