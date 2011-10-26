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
    public class ClienteController : Controller
    {
        private MvcScallfoldingContext context = new MvcScallfoldingContext();

        //
        // GET: /Cliente/

        public ViewResult Index()
        {
            return View(context.Clientes.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ViewResult Details(int id)
        {
            Cliente cliente = context.Clientes.Single(x => x.Id == id);
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Endereco = new Endereco();
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(cliente);
        }
        
        //
        // GET: /Cliente/Edit/5
 
        public ActionResult Edit(int id)
        {
            Cliente cliente = context.Clientes.Single(x => x.Id == id);
            return View(cliente);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Delete/5
 
        public ActionResult Delete(int id)
        {
            Cliente cliente = context.Clientes.Single(x => x.Id == id);
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = context.Clientes.Single(x => x.Id == id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}