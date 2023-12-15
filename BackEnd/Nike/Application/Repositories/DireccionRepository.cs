using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class DireccionRepository : GenericRepository<Direccion>, IDireccion
    {
        private readonly Context _context;

        public DireccionRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}