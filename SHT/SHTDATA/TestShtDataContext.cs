using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHT.SHTDATA
{
    public class TestShtDataContext : DbContext
    {
        public TestShtDataContext() : base("Data Source=.;Initial Catalog=SHT.New;Integrated Security=True")
        {

        }
        public DbSet<User> TestUser { get; set; }
    }
}
