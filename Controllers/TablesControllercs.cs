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
            var excludedTables = new HashSet<string>
            {
                "active_storage_attachments",
                "active_storage_blobs",
                "active_storage_variant_records",
                "ar_internal_metadata",
                "archival_drawings_areas",
                "archival_drawings_locus_coatings",
                "archival_drawings_locus_lists",
                "archival_drawings_locus_walls",
                "archival_drawings_rooms",
                "archival_drawings_trenches",
                "archival_drawings_zones",
                "areas_photographic_sources",
                "areas_rooms",
                "biblio_links",
                "locus_coatings_photographic_sources",
                "locus_lists_photographic_sources",
                "locus_rooms",
                "locus_walls_photographic_sources",
                "overall_material_lists",
                "photographic_sources_rooms",
                "photographic_sources_trenches",
                "photographic_sources_zones",
                "preliminary_reports",
                "rooms_trenches",
                "schema_migrations"
            };

            var tableNames = dbContext.Model
                .GetEntityTypes()
                .Select(t => t.GetTableName())
                .Where(tableName => !excludedTables.Contains(tableName))
                .ToList(); ;

            return Ok(tableNames);
        }
    }
}
