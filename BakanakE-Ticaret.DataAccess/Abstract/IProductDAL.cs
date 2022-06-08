using BakanakE_Ticaret.Core.DataAccess;
using BakanakE_Ticaret.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakanakE_Ticaret.DataAccess.Abstract
{
    public interface IProductDAL: IEntityRepository<Product>
    {

    }
}
