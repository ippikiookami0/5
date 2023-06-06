using LataPrzestepne.Models;
using System;

namespace LataPrzestepne.Interfaces
{
    public interface IHistoryDbService
    {
        public List<HistoryDB> HistoryDBList();
        public void AddHistoryDB(HistoryDB historyDB);
        //public IQueryable<HistoryDB> GetActivePeople();
    }
}
