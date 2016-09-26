using PesquisaEleitoral.Models;
using System.Linq;
using System.Web.Mvc;

namespace PesquisaEleitoral.Controllers
{
    public class VotoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.CandidatoContext.ToList());
        }

        public ActionResult Voto()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Voto(VotoViewModels model)
        {
            ApplicationUser user = new ApplicationUser();
            user.Email = System.Web.HttpContext.Current.User.Identity.Name;
            user = VerificarUsuarioPorEmail(user);
            user.CandidatoID = VerificarCandidatoPorNumero(model.CandidatoID);
            if(user == null)
            {
                HttpNotFound();
            }else
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        public ApplicationUser VerificarUsuarioPorEmail(ApplicationUser u)
        {
            return db.Users.FirstOrDefault(x => x.Email.Equals(u.Email));
        }
        public int VerificarCandidatoPorNumero(int num)
        {
            Candidato cd = new Candidato();
            cd = db.CandidatoContext.FirstOrDefault(x => x.CandidatoNumero.Equals(num));
            num = cd.CandidatoId;
            return num;
        }
        
    }
}
