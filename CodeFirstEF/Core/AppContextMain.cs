using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstEF.Models;

namespace CodeFirstEF.Core
{
    public class AppContextMain : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }        

        public AppContextMain()
            : base("name=MainConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
