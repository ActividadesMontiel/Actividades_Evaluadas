using IntroduccionMVC.Models;
using System.Web.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            Datos objModelo = new Datos();
            //datos quemados sease, datos predeterminados 
            objModelo.variableA = 3;
            objModelo.variableB = 5;

            objModelo.resultado = objModelo.variableA + objModelo.variableB;
            ViewData["Resultado"] = objModelo.resultado;
            return View();

        }

        public ActionResult Resta()
        {
            Datos objModelo = new Datos();
            //datos quemados sease, datos predeterminados 
            objModelo.variableA = double.Parse(Request.Form["txtValor1"].ToString());
            objModelo.variableB = double.Parse(Request.Form["txtValor2"].ToString());

            objModelo.resultado = objModelo.variableA - objModelo.variableB;
            
            return View("Resta",objModelo);

        }

        //---------------------------------------------------------
        public ActionResult Multi()
        {
            return View();
        }

        public ActionResult Multiplicar()
        {
            Datos objModelo = new Datos();
            //datos quemados sease, datos predeterminados 
            objModelo.variableA = double.Parse(Request.Form["num1"].ToString());
            objModelo.variableB = double.Parse(Request.Form["num2"].ToString());

            objModelo.resultado = objModelo.variableA * objModelo.variableB;

            return View("Multiplicar", objModelo);

        }

        //---------------------------------------------------------

        public ActionResult divi()
        {
            return View();
        }

        public ActionResult Division()
        {
            Datos objModelo = new Datos();
            //datos quemados sease, datos predeterminados 
            objModelo.variableA = double.Parse(Request.Form["numero1"].ToString());
            objModelo.variableB = double.Parse(Request.Form["numero2"].ToString());

            objModelo.resultado = objModelo.variableA / objModelo.variableB;

            return View("Division", objModelo);

        }

    }
}