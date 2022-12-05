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
            var List = _context.WatchLists.Where(w => w.UserID == id).ToList();

            List<WatchListList> ReviewsList = _mapper.Map<List<WatchListList>>(List);
            return ReviewsList;
        }

        public void AddWatchList(SingleWatchList singleWatchList)
        {
            //WatchList WatchList = _mapper.Map<WatchList>(singleWatchList);
            WatchList WatchList = new()
            {
                Id = singleWatchList.Id,
                MovieID = singleWatchList.MovieID,
                UserID= singleWatchList.UserID,
            };
            _context.WatchLists.Add(WatchList);
            _context.SaveChanges();
        }
        public void DeleteWatchList(decimal? id)
        {
            WatchList WatchList = _context.WatchLists.Find(id);
            if (WatchList != null)
                _context.WatchLists.Remove(WatchList);
            _context.SaveChanges();
        }

    }
}

