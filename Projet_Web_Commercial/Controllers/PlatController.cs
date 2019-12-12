using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Projet_Web_Commercial.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Projet_Web_Commercial;

namespace Projet_Web_Commercial.Controllers
{
    public class PlatController : Controller
    {
        const string chaineConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Julian\source\repos\Projet_Web_Commercial\CommercialProject\Projet_Web_Commercial\Data\ProjetCommercialData.mdf;Integrated Security=True";

        public IActionResult Index()
        {
            try
            {
                using (var connection = new SqlConnection(chaineConnexion))
                {
                    var liste = connection.Query<Plat>("SELECT * FROM Plat");

                    return View(liste);
                }
            } // Appel du Dispose de connection (ferme la connexion)
            catch (SqlException e)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}