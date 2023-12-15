using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class OrdenRepository : GenericRepository<Orden>, IOrden
    {
        private readonly Context _context;

        public OrdenRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}