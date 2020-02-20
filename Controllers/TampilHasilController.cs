using Microsoft.AspNetCore.Mvc;
using tts72170101.Models;

namespace tts72170101.Controllers{
    public class TampilHasilController : Controller{                     

        public IActionResult Tampil(Data data)
        {
            return View(data);
        }
        
    
    }
}