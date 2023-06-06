using LataPrzestepne.Interfaces;
using LataPrzestepne.Models;
using LataPrzestepne.Data;
using System;

namespace LataPrzestepne.Services
{
    public class HistoryDbService : IHistoryDbService
    {
        //throw new NotImplementedException();
        public List<HistoryDB> HistoryDBList ()
        {
            return _context.HistoryDB.ToList ();
        }
            private readonly DataContext _context;
              public HistoryDbService(DataContext context)
              {
                  _context = context;
              }
             public void AddHistoryDB(HistoryDB historyDB)
                {
                    _context.HistoryDB.Add(historyDB);
                    _context.SaveChanges();
                }
        /*public IQueryable<HistoryDB> GetActivePeople()
        {
            return _context.HistoryDB.Where(p => p.IsActive);
        }*/

    }

}
