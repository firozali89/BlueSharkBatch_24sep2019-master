﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoDotnetExample.Models;
namespace AdoDotnetExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDetail db = new Models.EmployeeDetail();

        public ActionResult Index()
        {

            return View(db.GetEmployeeData());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveData(emp);


            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Department()
        {
            DepartmentDetail db = new Models.DepartmentDetail();

            return View(db.GetDepartmentData());
        }
    }
}

//hello world