using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.ViewModels;

namespace WebTestUI.Controllers
{
    public class CalisanController : Controller
    {
        private readonly KolayIkContext _context;
        //private readonly UnitOfWork work;
        EfCalisanDal efCalisan;
        EfEgitimBilgiDal efEgitim;
        EfCalisanHarcamaDal efCalisanHarcama;
        public CalisanController(KolayIkContext context)
        {
            _context = context;
            //work = new UnitOfWork(_context);
            efCalisan = new EfCalisanDal(context);
            efEgitim = new EfEgitimBilgiDal(context);
            efCalisanHarcama = new EfCalisanHarcamaDal(context);
        }
        public IActionResult Index()
        {
            return View(efCalisan.GetAll());
        }

        public IActionResult CalisanGoruntuleme(string ara)
        {
            if (Request.Cookies["UserId"]==null)
            {
                return NotFound();
            }
            int id = int.Parse(Request.Cookies["UserId"]);
            int sirketId = (int)efCalisan.GetById(id).SirketId;
            List<Calisan> calisans = efCalisan.GetAll(x=>x.SirketId==sirketId);
           
            if (!string.IsNullOrEmpty(ara))
            {
                calisans = calisans.Where(x => x.Adi.Contains(ara) || x.Soyadi.Contains(ara) || x.TelIs.Contains(ara)).ToList();
            }
            return View(calisans);
        }

        public IActionResult CalisanEgitimGoruntuleme(int id) 
        {
            CalisanEgitimViewModel model = new CalisanEgitimViewModel();
            model.Calisan = efCalisan.GetById(id);
            model.CalisanId = model.Calisan.CalisanId;
            model.EgitimBilgileri = efEgitim.GetAll(a => a.CalisanId == id);
            return View(model);
        }
        public IActionResult Create()
        {
            return View(new Calisan());
        }

        

        [HttpPost]
        public IActionResult Create(Calisan calisan)
        {
            //work.EfCalisanDal.Add(calisan);
            //work.Complete();
            return RedirectToAction("Index");
        }

        public IActionResult Harcamalar()        
        {
            if (Request.Cookies["UserId"] == null)
            {
                return NotFound();
            }
            int id = Convert.ToInt32(Request.Cookies["UserId"]);
            List<CalisanHarcama> harcamalar = efCalisanHarcama.GetAll(a => a.CalisanId == id);
            return View(harcamalar);
        }

    }
}
