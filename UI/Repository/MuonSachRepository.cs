using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace UI.Repository
{
    public class MuonSachRepository : GenericRepository<MuonSach>
    {
        public MuonSachRepository() : base() { }
        public override Task<List<MuonSach>> GetAllAsync() 
            => Context.MuonSaches
            .Include(m => m.DocGia)
            .Include(m => m.Sach)
            .ToListAsync();

    }
}
