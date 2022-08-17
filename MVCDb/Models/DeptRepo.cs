using System.Collections.Generic;
using System.Linq;

namespace MVCDb.Models
{
    public class DeptRepo : IDept
    {
        DB1045Context db=new DB1045Context();
        public List<Dept> GetAllDepts()
        {
            var data = db.Depts.ToList();
            return data;
        }
        public void AddDept(Dept dept)
        {
            db.Depts.Add(dept);
            db.SaveChanges();

        }

        public void DeleteDept(int id)
        {
            Dept data =db.Depts.Find(id);  
            db.Depts.Remove(data);
            db.SaveChanges();
        }

        public void EditDept(Dept dept)
        {
            Dept odept = db.Depts.Find(dept.Id);
            odept.Name = dept.Name;
            odept.Location = dept.Location;
            db.SaveChanges();
        }

        

        public Dept FindDept(int id)
        {
            var data=db.Depts.Find(id);
            return data;
        }

    }
}
