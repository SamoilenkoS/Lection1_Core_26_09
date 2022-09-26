using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lection1_API.Services
{
    public interface IGoodsService
    {
        Task<IEnumerable<Good>> GetAll();
        Task<Good> GetById(Guid id);
        Task<Good> Create(Good good);
        Task<Good> Update(Good good);
        Task<Good> Delete(Guid id);
    }
}
