using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TH02.Models;

namespace TH02.Controllers
{
    public class EmployeeController : Controller
    {
        //GET:Employee
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetView()
        {
            Employee employee = new Employee();

            /*ViewData*/
            employee.FirstName = "Phan Tuan";
            employee.LastName = "Anh";
            employee.Salary = 50000;
            ViewData["Employee"] = employee;

            /*ViewBag*/
            //ViewBag.FirstName = "Phan Tuan";
            //ViewBag.LastName = "Anh";
            //ViewBag.Salary = 50000;
            return View();

            /*Strongly-Typed View*/
            //return View(employee);
        }
        public IActionResult Display()
        {
            /*Strongly-Typed View*/
            Employee employee = new Employee();
            employee.FirstName = "Phan";
            employee.LastName = "Anh";
            employee.Salary = 10000;
            if (employee.Salary > 15000)
            {
                employee.SalaryColor = "red";
            }
            else
            {
                employee.SalaryColor = "blue";
            }
            return View(employee);
        }
        public IActionResult GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employee.FirstName = "abc";
            employee.LastName = "cde";
            employee.Salary = 14000;
            employees.Add(employee);

            employee = new Employee();
            employee.FirstName = "cddff";
            employee.LastName = "ddccc";
            employee.Salary = 20000;
            employees.Add(employee);

            employee = new Employee();
            employee.FirstName = "avvvvvvccc";
            employee.LastName = "adadasda";
            employee.Salary = 30000;
            employees.Add(employee);

            return View(employees);
        }
    }
}
