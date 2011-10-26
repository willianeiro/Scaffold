using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcScallfolding.Models;

namespace MvcScallfolding.Controllers
{   
    public class EnderecoController : Controller
    {
        private MvcScallfoldingContext context = new MvcScallfoldingContext();

        //
        // GET: /Endereco/

        public ViewResult Index()
        {
            return View(context.Enderecos.ToList());
        }

        //
        // GET: /Endereco/Details/5

        public ViewResult Details(int id)
        {
            Endereco endereco = context.Enderecos.Single(x => x.Id == id);
            return View(endereco);
        }

        //
        // GET: /Endereco/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Endereco/Create

        [HttpPost]
        public ActionResult Create(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                context.Enderecos.Add(endereco);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(endereco);
        }
        
        //
        // GET: /Endereco/Edit/5
 
        public ActionResult Edit(int id)
        {
            Endereco endereco = context.Enderecos.Single(x => x.Id == id);
            return View(endereco);
        }

        //
        // POST: /Endereco/Edit/5

        [HttpPost]
        public ActionResult Edit(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                context.Entry(endereco).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endereco);
        }

        //
        // GET: /Endereco/Delete/5
 
        public ActionResult Delete(int id)
        {
            Endereco endereco = context.Enderecos.Single(x => x.Id == id);
            return View(endereco);
        }

        //
        // POST: /Endereco/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Endereco endereco = context.Enderecos.Single(x => x.Id == id);
            context.Enderecos.Remove(endereco);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}