using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCDb.Models;

namespace MVCDb.ViewModel
{
    public class EmpDept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int? Salary { get; set; }
        public int Bonus { get; set; }
    }
}
