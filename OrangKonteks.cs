using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFT1
{
  class OrangKonteks : DbContext
  {
    public DbSet<Orang> dtOrang { get; set; }

  }
}
