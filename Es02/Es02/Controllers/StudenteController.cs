using Microsoft.AspNetCore.Mvc;
using Es02.Models;
namespace Es02.Controllers
{
    public class StudenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudenteUno() {
            Studente studente = new Studente();
            studente.Nome = "Paolo";
            studente.Cognome = "Giraudo";
            studente.Sesso = "M";
            studente.Eta = 23;
            return View(studente);
        }

        public IActionResult Details(int id) 
        {
            int studenteId = id;
            StudenteBusinessLayer sbl =new StudenteBusinessLayer();
            Studente studente= sbl.GetStudent(studenteId);
            return View(studente);    
        }

        public IActionResult GetAll()
        {
            StudenteBusinessLayer sbk = new StudenteBusinessLayer();
                return View(sbk.GetAll());
        }
    }
}
