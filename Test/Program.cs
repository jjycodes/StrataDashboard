using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using StrataDashboard;
using StrataDashboard.EntityFramework.Repositories;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new BuildingsRepository();
            repo.GetAllList();
        }
    }
}
