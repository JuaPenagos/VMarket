using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMarket.Models;

namespace VMarket.Classes
{
    public class ComboxHelper :  IDisposable
    {
        private static VMarketContext db = new VMarketContext();
        public static List<Department> GetDepartment()
        {
            var Department = db.Departments.ToList();
            Department.Add(new Department { DepartmentId = 0, Name = "*Seleccione un departamento." });
            Department = Department.OrderBy(d => d.Name).ToList();
            return Department;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}