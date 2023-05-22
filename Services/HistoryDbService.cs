using LataPrzestepne.Interfaces;
using LataPrzestepne.Models;
using LataPrzestepne.Data;
using System;

namespace LataPrzestepne.Services
{
    public class HistoryDbService : IHistoryDbService
    {
            //throw new NotImplementedException();
            private readonly DataContext _context;
              public HistoryDbService(DataContext context)
              {
                  _context = context;
              }
              public IQueryable<HistoryDB> GetActivePeople()
              {
                  return _context.HistoryDB.Where(p => p.IsActive);
              }

    }

}
