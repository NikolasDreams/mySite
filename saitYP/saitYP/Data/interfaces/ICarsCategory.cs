using saitYP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saitYP.Data.interfaces
{
  public  interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }//получает данные
    }
}
