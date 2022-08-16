using System.Collections.Generic;

namespace MVCDb.Models
{
    public interface IDept
    {
        List<Dept> GetAllDepts();
        Dept GetDeptById(int id);
        void DeleteDept(int id);
        void EditDept(Dept dept);
        void AddDept(Dept dept);
    }
}
