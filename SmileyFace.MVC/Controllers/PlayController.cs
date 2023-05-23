using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmileyFace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// correlates to AllPositionsMapper

namespace SmileyFacePOCMVC.Controllers
{
    public class PlayController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //Create a new Grid/Board and empty rack: 12x12
        //Update a Board with placement of chosen emoji
        //Save board/grid

    }
}

