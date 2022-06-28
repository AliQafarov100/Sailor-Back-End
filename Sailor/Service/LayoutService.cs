using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sailor.DAL;
using Sailor.Models;

namespace Sailor.Service
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }
    }
}
