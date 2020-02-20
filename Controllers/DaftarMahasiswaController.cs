using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tts72170101.Models;

namespace tts72170101.Controllers{
    public class DaftarMahasiswaController : Controller{
        
        public IActionResult GetAllAnggota(){
           List<Data> lstData = new List<Data>();
            lstData.Add(new Data {
                NIM = "72098787",
                Nama = "Erick Kurniawan",
                Jurusan = "Sistem Informasi",
                IPS = "3.4",
                IPK = "3.2"
            });
             lstData.Add(new Data {
                NIM = "72089567",
                Nama = "Argo Lawu",
                Jurusan = "Sistem Informasi",
                IPS = "3.6",
                IPK = "3.4"
            });
            lstData.Add(new Data {
                NIM = "72149878",
                Nama = "Argo Bromo",
                Jurusan = "Arsitektur",
                IPS = "2.6",
                IPK = "2.7"
            });
            lstData.Add(new Data {
                NIM = "72129876",
                Nama = "Argo Dwipangga",
                Jurusan = "Teologi",
                IPS = "3.7",
                IPK = "3.4"
            });

            return View(lstData);
        }

        // public IActionResult Tampil(Data data)
        // {
            
        //     return View(data);
        // }
        
    }
}