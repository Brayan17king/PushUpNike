using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories;

public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshToken
{
    private readonly Context _context;

    public RefreshTokenRepository(Context context) : base(context)
    {
        _context = context;
    }
}