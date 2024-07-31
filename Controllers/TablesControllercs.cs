using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesControllercs : ControllerBase
    {
        private readonly Dek9s8aheu55lvContext dbContext;

        public TablesControllercs(Dek9s8aheu55lvContext dbContext)
        {
            this.dbContext = dbContext;
        }

            
        [HttpGet("tables")]
        public ActionResult<IEnumerable<string>> GetTables()
        {
            var tableNames = dbContext.Model
                .GetEntityTypes()
                .Select(t => t.GetTableName())
                .ToList();

            return Ok(tableNames);
        }
    }
}
