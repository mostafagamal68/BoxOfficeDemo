using BoxOfficeDemo.Client.Services;
using BoxOfficeDemo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoxOfficeDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchListController : ControllerBase
    {
        private readonly IWatchListLogic _watchListLogic;
        public WatchListController(IWatchListLogic watchListLogic)
        {
            _watchListLogic = watchListLogic;
        }
        [HttpGet("GetWatchList/{id}")]
        public IActionResult GetWatchList(string? id)
        {
            return Ok(_watchListLogic.GetWatchList(id));
        }

        [HttpPost("AddWatchList")]
        public IActionResult AddWatchList(SingleWatchList singleWatchList)
        {
            if (singleWatchList == null)
                return NotFound();
            _watchListLogic.AddWatchList(singleWatchList);
            return Ok();
        }

        [HttpDelete("DeleteWatchList/{id}")]
        //[Route("GetWatchList")]
        public IActionResult DeleteWatchList(decimal? id)
        {
            if (id == null)
                return NotFound();
            _watchListLogic.DeleteWatchList(id);
            return Ok();
        }
    }
}
