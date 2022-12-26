using BoxOfficeDemo.Server.Models;
using System.IO;
using System.Net.Http.Json;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BoxOfficeDemo.Shared.Configurations;

namespace BoxOfficeDemo.Client.Services
{
    public class WatchListLogic : IWatchListLogic
    {
        private readonly BoxOfficeDBContext _context;
        private readonly IMapper _mapper;

        public WatchListLogic(BoxOfficeDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<WatchListList> GetWatchList(string? id)
        {
            return _mapper.Map<List<WatchListList>>(_context.WatchList.Where(w => w.UserID == id).Include(i => i.Movie).ToList());
        }

        public void AddWatchList(SingleWatchList singleWatchList)
        {
            _context.WatchList.Add(_mapper.Map<WatchList>(singleWatchList));
            _context.SaveChanges();
        }
        public void DeleteWatchList(decimal? id)
        {
            var WatchList = _context.WatchList.Find(id);
            if (WatchList != null)
                _context.WatchList.Remove(WatchList);
            _context.SaveChanges();
        }

    }
}

