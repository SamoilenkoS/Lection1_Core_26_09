using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lection1_API.Services
{
    public class GoodsService : IGoodsService
    {
        public Task<Good> Create(Good good)
        {
            throw new NotImplementedException();
        }

        public Task<Good> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Good>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Good> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Good> Update(Good good)
        {
            throw new NotImplementedException();
        }
    }
}
