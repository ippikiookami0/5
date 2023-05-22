using LataPrzestepne.Models;
using System;

namespace LataPrzestepne.Interfaces
{
    public interface IHistoryDbService
    {
        public IQueryable<HistoryDB> GetActivePeople();
    }
}
