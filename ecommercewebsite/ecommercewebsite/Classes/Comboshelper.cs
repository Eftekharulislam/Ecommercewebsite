using ecommercewebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommercewebsite.Classes
{

    public class Comboshelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();
        public static List<Department> GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DpeartmentId = 0,
                name = "[Select a department...]"
            });
            return departments.OrderBy(d => d.name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}