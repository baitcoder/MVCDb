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
            throw new System.NotImplementedException();
        }

        public void DeleteDept(int id)
        {
            throw new System.NotImplementedException();
        }

        public void EditDept(Dept dept)
        {
            throw new System.NotImplementedException();
        }

        

        public Dept GetDeptById(int id)
        {
            var data=db.Depts.Find(id);
            return data;
        }
    }
}
