using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class Dek9s8aheu55lvContext : DbContext
{
    public Dek9s8aheu55lvContext()
    {
    }

    public Dek9s8aheu55lvContext(DbContextOptions<Dek9s8aheu55lvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; }

    public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; }

    public virtual DbSet<ActiveStorageVariantRecord> ActiveStorageVariantRecords { get; set; }

    public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; }

    public virtual DbSet<ArchivalDrawing> ArchivalDrawings { get; set; }

    public virtual DbSet<ArchivalDrawingsArea> ArchivalDrawingsAreas { get; set; }

    public virtual DbSet<ArchivalDrawingsLocusCoating> ArchivalDrawingsLocusCoatings { get; set; }

    public virtual DbSet<ArchivalDrawingsLocusList> ArchivalDrawingsLocusLists { get; set; }

    public virtual DbSet<ArchivalDrawingsLocusWall> ArchivalDrawingsLocusWalls { get; set; }

    public virtual DbSet<ArchivalDrawingsRoom> ArchivalDrawingsRooms { get; set; }

    public virtual DbSet<ArchivalDrawingsTrench> ArchivalDrawingsTrenches { get; set; }

    public virtual DbSet<ArchivalDrawingsZone> ArchivalDrawingsZones { get; set; }

    public virtual DbSet<ArchivalSource> ArchivalSources { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreasPhotographicSource> AreasPhotographicSources { get; set; }

    public virtual DbSet<AreasRoom> AreasRooms { get; set; }

    public virtual DbSet<BiblioLink> BiblioLinks { get; set; }

    public virtual DbSet<BoneObject> BoneObjects { get; set; }

    public virtual DbSet<Brick> Bricks { get; set; }

    public virtual DbSet<BricksClay> BricksClays { get; set; }

    public virtual DbSet<BricksConsistence> BricksConsistences { get; set; }

    public virtual DbSet<BricksForm> BricksForms { get; set; }

    public virtual DbSet<BricksInstallation> BricksInstallations { get; set; }

    public virtual DbSet<BricksWorking> BricksWorkings { get; set; }

    public virtual DbSet<Coin> Coins { get; set; }

    public virtual DbSet<DrawType> DrawTypes { get; set; }

    public virtual DbSet<Drawing> Drawings { get; set; }

    public virtual DbSet<EpigraphicElement> EpigraphicElements { get; set; }

    public virtual DbSet<GeneralBibliography> GeneralBibliographies { get; set; }

    public virtual DbSet<Glass> Glasses { get; set; }

    public virtual DbSet<IconographicSource> IconographicSources { get; set; }

    public virtual DbSet<IntangibleElement> IntangibleElements { get; set; }

    public virtual DbSet<Locu> Locus { get; set; }

    public virtual DbSet<LocusCoating> LocusCoatings { get; set; }

    public virtual DbSet<LocusCoatingsPhotographicSource> LocusCoatingsPhotographicSources { get; set; }

    public virtual DbSet<LocusComponent> LocusComponents { get; set; }

    public virtual DbSet<LocusDefinition> LocusDefinitions { get; set; }

    public virtual DbSet<LocusFormation> LocusFormations { get; set; }

    public virtual DbSet<LocusList> LocusLists { get; set; }

    public virtual DbSet<LocusListsPhotographicSource> LocusListsPhotographicSources { get; set; }

    public virtual DbSet<LocusRoom> LocusRooms { get; set; }

    public virtual DbSet<LocusWall> LocusWalls { get; set; }

    public virtual DbSet<LocusWallsPhotographicSource> LocusWallsPhotographicSources { get; set; }

    public virtual DbSet<MaterialProvenance> MaterialProvenances { get; set; }

    public virtual DbSet<Metal> Metals { get; set; }

    public virtual DbSet<MetalMaterial> MetalMaterials { get; set; }

    public virtual DbSet<OverallMaterialList> OverallMaterialLists { get; set; }

    public virtual DbSet<Photograph> Photographs { get; set; }

    public virtual DbSet<PhotographicSource> PhotographicSources { get; set; }

    public virtual DbSet<PhotographicSourcesRoom> PhotographicSourcesRooms { get; set; }

    public virtual DbSet<PhotographicSourcesTrench> PhotographicSourcesTrenches { get; set; }

    public virtual DbSet<PhotographicSourcesZone> PhotographicSourcesZones { get; set; }

    public virtual DbSet<Pottery> Potteries { get; set; }

    public virtual DbSet<PreliminaryReport> PreliminaryReports { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomsTrench> RoomsTrenches { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<SpecialFind> SpecialFinds { get; set; }

    public virtual DbSet<SpotDate> SpotDates { get; set; }

    public virtual DbSet<StoneCutting> StoneCuttings { get; set; }

    public virtual DbSet<StoneForm> StoneForms { get; set; }

    public virtual DbSet<StoneInstallation> StoneInstallations { get; set; }

    public virtual DbSet<StoneObject> StoneObjects { get; set; }

    public virtual DbSet<StoneWorking> StoneWorkings { get; set; }

    public virtual DbSet<Trench> Trenches { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WoodenObject> WoodenObjects { get; set; }

    public virtual DbSet<WrittenSource> WrittenSources { get; set; }

    public virtual DbSet<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; }

    public virtual DbSet<WrittenSourcesObject> WrittenSourcesObjects { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=dek9s8aheu55lv;Username=postgres;Password= postgres;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveStorageAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_attachments_pkey");

            entity.ToTable("active_storage_attachments");

            entity.HasIndex(e => e.BlobId, "index_active_storage_attachments_on_blob_id");

            entity.HasIndex(e => new { e.RecordType, e.RecordId, e.Name, e.BlobId }, "index_active_storage_attachments_uniqueness").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlobId).HasColumnName("blob_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RecordId).HasColumnName("record_id");
            entity.Property(e => e.RecordType)
                .HasColumnType("character varying")
                .HasColumnName("record_type");

            entity.HasOne(d => d.Blob).WithMany(p => p.ActiveStorageAttachments)
                .HasForeignKey(d => d.BlobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_c3b3935057");
        });

        modelBuilder.Entity<ActiveStorageBlob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_blobs_pkey");

            entity.ToTable("active_storage_blobs");

            entity.HasIndex(e => e.Key, "index_active_storage_blobs_on_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ByteSize).HasColumnName("byte_size");
            entity.Property(e => e.Checksum)
                .HasColumnType("character varying")
                .HasColumnName("checksum");
            entity.Property(e => e.ContentType)
                .HasColumnType("character varying")
                .HasColumnName("content_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Filename)
                .HasColumnType("character varying")
                .HasColumnName("filename");
            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.ServiceName)
                .HasColumnType("character varying")
                .HasColumnName("service_name");
        });

        modelBuilder.Entity<ActiveStorageVariantRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_variant_records_pkey");

            entity.ToTable("active_storage_variant_records");

            entity.HasIndex(e => new { e.BlobId, e.VariationDigest }, "index_active_storage_variant_records_uniqueness").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlobId).HasColumnName("blob_id");
            entity.Property(e => e.VariationDigest)
                .HasColumnType("character varying")
                .HasColumnName("variation_digest");

            entity.HasOne(d => d.Blob).WithMany(p => p.ActiveStorageVariantRecords)
                .HasForeignKey(d => d.BlobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_993965df05");
        });

        modelBuilder.Entity<ArInternalMetadatum>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("ar_internal_metadata_pkey");

            entity.ToTable("ar_internal_metadata");

            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasColumnType("character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<ArchivalDrawing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("archival_drawings_pkey");

            entity.ToTable("archival_drawings");

            entity.HasIndex(e => e.DrawTypeId, "index_archival_drawings_on_draw_type_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_archival_drawings_on_general_bibliography_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DrawTypeId).HasColumnName("draw_type_id");
            entity.Property(e => e.Fond)
                .HasColumnType("character varying")
                .HasColumnName("fond");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");

            entity.HasOne(d => d.DrawType).WithMany(p => p.ArchivalDrawings)
                .HasForeignKey(d => d.DrawTypeId)
                .HasConstraintName("fk_rails_e6e1e57a67");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.ArchivalDrawings)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_849aee229a");
        });

        modelBuilder.Entity<ArchivalDrawingsArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_areas");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.AreaId }, "arcdraw_area");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
        });

        modelBuilder.Entity<ArchivalDrawingsLocusCoating>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_locus_coatings");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.LocusCoatingId }, "arcdraw_locus_coating");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.LocusCoatingId).HasColumnName("locus_coating_id");
        });

        modelBuilder.Entity<ArchivalDrawingsLocusList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_locus_lists");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.LocusListId }, "arcdraw_locus_list");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.LocusListId).HasColumnName("locus_list_id");
        });

        modelBuilder.Entity<ArchivalDrawingsLocusWall>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_locus_walls");

            entity.HasIndex(e => new { e.LocusWallId, e.ArchivalDrawingId }, "locucwall_archdrw");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.LocusWallId).HasColumnName("locus_wall_id");
        });

        modelBuilder.Entity<ArchivalDrawingsRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_rooms");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.RoomId }, "arcdraw_rooms");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
        });

        modelBuilder.Entity<ArchivalDrawingsTrench>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_trenches");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.TrenchId }, "arcdraw_trenches");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
        });

        modelBuilder.Entity<ArchivalDrawingsZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("archival_drawings_zones");

            entity.HasIndex(e => new { e.ArchivalDrawingId, e.ZoneId }, "arcdraw_zones");

            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
        });

        modelBuilder.Entity<ArchivalSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("archival_sources_pkey");

            entity.ToTable("archival_sources");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalSourceType)
                .HasColumnType("character varying")
                .HasColumnName("archival_source_type");
            entity.Property(e => e.Archive)
                .HasColumnType("character varying")
                .HasColumnName("archive");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Fond)
                .HasColumnType("character varying")
                .HasColumnName("fond");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("areas_pkey");

            entity.ToTable("areas");

            entity.HasIndex(e => e.ZoneId, "index_areas_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bibliography)
                .HasColumnType("character varying")
                .HasColumnName("bibliography");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DateOfEnd).HasColumnName("date_of_end");
            entity.Property(e => e.DateOfStart).HasColumnName("date_of_start");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Zone).WithMany(p => p.Areas)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_8e7dac241b");
        });

        modelBuilder.Entity<AreasPhotographicSource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("areas_photographic_sources");

            entity.HasIndex(e => new { e.PhotographicSourceId, e.AreaId }, "phsrc_area");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
        });

        modelBuilder.Entity<AreasRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("areas_rooms");

            entity.HasIndex(e => new { e.AreaId, e.RoomId }, "index_areas_rooms_on_area_id_and_room_id");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
        });

        modelBuilder.Entity<BiblioLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("biblio_links_pkey");

            entity.ToTable("biblio_links");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_biblio_links_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_biblio_links_on_iconographic_source_id");

            entity.HasIndex(e => e.IntangibleElementId, "index_biblio_links_on_intangible_element_id");

            entity.HasIndex(e => e.LocusListId, "index_biblio_links_on_locus_list_id");

            entity.HasIndex(e => e.TrenchId, "index_biblio_links_on_trench_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.IntangibleElementId).HasColumnName("intangible_element_id");
            entity.Property(e => e.LocusListId).HasColumnName("locus_list_id");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.BiblioLinks)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_f540e83e18");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.BiblioLinks)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_60145330c0");

            entity.HasOne(d => d.IntangibleElement).WithMany(p => p.BiblioLinks)
                .HasForeignKey(d => d.IntangibleElementId)
                .HasConstraintName("fk_rails_579dc7a5fe");

            entity.HasOne(d => d.LocusList).WithMany(p => p.BiblioLinks)
                .HasForeignKey(d => d.LocusListId)
                .HasConstraintName("fk_rails_24366682af");

            entity.HasOne(d => d.Trench).WithMany(p => p.BiblioLinks)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_c042a63e7c");
        });

        modelBuilder.Entity<BoneObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bone_objects_pkey");

            entity.ToTable("bone_objects");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_bone_objects_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_bone_objects_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_bone_objects_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_bone_objects_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_bone_objects_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_bone_objects_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_bone_objects_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_bone_objects_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_bone_objects_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_bone_objects_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_bone_objects_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_bone_objects_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_bone_objects_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DefObject)
                .HasColumnType("character varying")
                .HasColumnName("def_object");
            entity.Property(e => e.DescrDecor)
                .HasColumnType("character varying")
                .HasColumnName("descr_decor");
            entity.Property(e => e.DescrEp).HasColumnName("descr_ep");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DesignatedUse)
                .HasColumnType("character varying")
                .HasColumnName("designated_use");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightCm).HasColumnName("height_cm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.IdEpi)
                .HasColumnType("character varying")
                .HasColumnName("id_epi");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TotFrag)
                .HasColumnType("character varying")
                .HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WidthCm).HasColumnName("width_cm");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_ae59e9fc69");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_79c1a086a0");

            entity.HasOne(d => d.Drawing).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_c6065dada9");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_bb91356dc7");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_41aaacd396");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_ed86b9f97e");

            entity.HasOne(d => d.Photograph).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_4e37742702");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_8fc57edc4f");

            entity.HasOne(d => d.Room).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_820157f5f6");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_750d05a81f");

            entity.HasOne(d => d.Trench).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_1209475677");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_d3fc2da52c");

            entity.HasOne(d => d.Zone).WithMany(p => p.BoneObjects)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_e80199726e");
        });

        modelBuilder.Entity<Brick>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_pkey");

            entity.ToTable("bricks");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_bricks_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_bricks_on_archival_source_id");

            entity.HasIndex(e => e.BricksClayId, "index_bricks_on_bricks_clay_id");

            entity.HasIndex(e => e.BricksConsistenceId, "index_bricks_on_bricks_consistence_id");

            entity.HasIndex(e => e.BricksFormId, "index_bricks_on_bricks_form_id");

            entity.HasIndex(e => e.BricksInstallationId, "index_bricks_on_bricks_installation_id");

            entity.HasIndex(e => e.BricksWorkingId, "index_bricks_on_bricks_working_id");

            entity.HasIndex(e => e.DrawingId, "index_bricks_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_bricks_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_bricks_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_bricks_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_bricks_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_bricks_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_bricks_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_bricks_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_bricks_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_bricks_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_bricks_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.Baking)
                .HasColumnType("character varying")
                .HasColumnName("baking");
            entity.Property(e => e.BrickClass)
                .HasColumnType("character varying")
                .HasColumnName("brick_class");
            entity.Property(e => e.BrickType)
                .HasColumnType("character varying")
                .HasColumnName("brick_type");
            entity.Property(e => e.BricksClayId).HasColumnName("bricks_clay_id");
            entity.Property(e => e.BricksConsistenceId).HasColumnName("bricks_consistence_id");
            entity.Property(e => e.BricksFormId).HasColumnName("bricks_form_id");
            entity.Property(e => e.BricksInstallationId).HasColumnName("bricks_installation_id");
            entity.Property(e => e.BricksWorkingId).HasColumnName("bricks_working_id");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ClayColor)
                .HasColumnType("character varying")
                .HasColumnName("clay_color");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CookingLevel)
                .HasColumnType("character varying")
                .HasColumnName("cooking_level");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DescrEpi)
                .HasColumnType("character varying")
                .HasColumnName("descr_epi");
            entity.Property(e => e.DominusAPrediorum)
                .HasColumnType("character varying")
                .HasColumnName("dominus_a_prediorum");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.FiglineWorkshop)
                .HasColumnType("character varying")
                .HasColumnName("figline_workshop");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightCm).HasColumnName("height_cm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.ImpressionQuality)
                .HasColumnType("character varying")
                .HasColumnName("impression_quality");
            entity.Property(e => e.Integrity)
                .HasColumnType("character varying")
                .HasColumnName("integrity");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Officinator)
                .HasColumnType("character varying")
                .HasColumnName("officinator");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.PunchMaterial)
                .HasColumnType("character varying")
                .HasColumnName("punch_material");
            entity.Property(e => e.PunchQuality)
                .HasColumnType("character varying")
                .HasColumnName("punch_quality");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Refiniment)
                .HasColumnType("character varying")
                .HasColumnName("refiniment");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.ScrollForm)
                .HasColumnType("character varying")
                .HasColumnName("scroll_form");
            entity.Property(e => e.ScrollMeasures)
                .HasColumnType("character varying")
                .HasColumnName("scroll_measures");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.Stamp).HasColumnName("stamp");
            entity.Property(e => e.StampIntegrity)
                .HasColumnType("character varying")
                .HasColumnName("stamp_integrity");
            entity.Property(e => e.StampLegibility)
                .HasColumnType("character varying")
                .HasColumnName("stamp_legibility");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WeightG).HasColumnName("weight_g");
            entity.Property(e => e.WidthCm).HasColumnName("width_cm");
            entity.Property(e => e.Worker)
                .HasColumnType("character varying")
                .HasColumnName("worker");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_b857e2e1c8");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_815dd15bc6");

            entity.HasOne(d => d.BricksClay).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.BricksClayId)
                .HasConstraintName("fk_rails_343a086ee0");

            entity.HasOne(d => d.BricksConsistence).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.BricksConsistenceId)
                .HasConstraintName("fk_rails_29bba1405e");

            entity.HasOne(d => d.BricksForm).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.BricksFormId)
                .HasConstraintName("fk_rails_3109a6d951");

            entity.HasOne(d => d.BricksInstallation).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.BricksInstallationId)
                .HasConstraintName("fk_rails_e5e886bbef");

            entity.HasOne(d => d.BricksWorking).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.BricksWorkingId)
                .HasConstraintName("fk_rails_f285069939");

            entity.HasOne(d => d.Drawing).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_9287a96a80");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_9866f81175");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_5b5495ebc2");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_03ad9027c7");

            entity.HasOne(d => d.Photograph).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_3bb66fbb09");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_19cb10486a");

            entity.HasOne(d => d.Room).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_f648b1259a");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_f5c4511f00");

            entity.HasOne(d => d.Trench).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_e6a2f09a07");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_7039df7613");

            entity.HasOne(d => d.Zone).WithMany(p => p.Bricks)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_1d37e40b40");
        });

        modelBuilder.Entity<BricksClay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_clays_pkey");

            entity.ToTable("bricks_clays");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BricksConsistence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_consistences_pkey");

            entity.ToTable("bricks_consistences");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BricksForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_forms_pkey");

            entity.ToTable("bricks_forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BricksInstallation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_installations_pkey");

            entity.ToTable("bricks_installations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BricksWorking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bricks_workings_pkey");

            entity.ToTable("bricks_workings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Coin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("coins_pkey");

            entity.ToTable("coins");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_coins_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_coins_on_archival_source_id");

            entity.HasIndex(e => e.AreaId, "index_coins_on_area_id");

            entity.HasIndex(e => e.DrawingId, "index_coins_on_drawing_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_coins_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_coins_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_coins_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_coins_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_coins_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_coins_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_coins_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_coins_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_coins_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChronMax)
                .HasColumnType("character varying")
                .HasColumnName("chron_max");
            entity.Property(e => e.ChronMin)
                .HasColumnType("character varying")
                .HasColumnName("chron_min");
            entity.Property(e => e.CoinagePosition)
                .HasColumnType("character varying")
                .HasColumnName("coinage_position");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.DiameterMm).HasColumnName("diameter_mm");
            entity.Property(e => e.Director)
                .HasColumnType("character varying")
                .HasColumnName("director");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.Emperor)
                .HasColumnType("character varying")
                .HasColumnName("emperor");
            entity.Property(e => e.ExcEndDate).HasColumnName("exc_end_date");
            entity.Property(e => e.ExcStartDate).HasColumnName("exc_start_date");
            entity.Property(e => e.Exergue)
                .HasColumnType("character varying")
                .HasColumnName("exergue");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightMm).HasColumnName("height_mm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.IssuingAuthority)
                .HasColumnType("character varying")
                .HasColumnName("issuing_authority");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Mint)
                .HasColumnType("character varying")
                .HasColumnName("mint");
            entity.Property(e => e.Nominal)
                .HasColumnType("character varying")
                .HasColumnName("nominal");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ObverseDescr)
                .HasColumnType("character varying")
                .HasColumnName("obverse_descr");
            entity.Property(e => e.ObverseLegend)
                .HasColumnType("character varying")
                .HasColumnName("obverse_legend");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.ReasonsExcEnd)
                .HasColumnType("character varying")
                .HasColumnName("reasons_exc_end");
            entity.Property(e => e.ReasonsExcStart)
                .HasColumnType("character varying")
                .HasColumnName("reasons_exc_start");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Restored).HasColumnName("restored");
            entity.Property(e => e.ReverseDescr)
                .HasColumnType("character varying")
                .HasColumnName("reverse_descr");
            entity.Property(e => e.ReverseLegend)
                .HasColumnType("character varying")
                .HasColumnName("reverse_legend");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.Site)
                .HasColumnType("character varying")
                .HasColumnName("site");
            entity.Property(e => e.SpecMaterial)
                .HasColumnType("character varying")
                .HasColumnName("spec_material");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.StateCons)
                .HasColumnType("character varying")
                .HasColumnName("state_cons");
            entity.Property(e => e.SubjectObverse)
                .HasColumnType("character varying")
                .HasColumnName("subject_obverse");
            entity.Property(e => e.SubjectReverse)
                .HasColumnType("character varying")
                .HasColumnName("subject_reverse");
            entity.Property(e => e.ThicknessMm).HasColumnName("thickness_mm");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WeightG).HasColumnName("weight_g");
            entity.Property(e => e.WidthMm).HasColumnName("width_mm");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.Coins)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_9274944873");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.Coins)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_245890447f");

            entity.HasOne(d => d.Area).WithMany(p => p.Coins)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_852c58b08e");

            entity.HasOne(d => d.Drawing).WithMany(p => p.Coins)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_3c973fe92a");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.Coins)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_e66dfb413b");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.Coins)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_4e502e36fb");

            entity.HasOne(d => d.Photograph).WithMany(p => p.Coins)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_8ca94cb7ed");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.Coins)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_d9782f3c09");

            entity.HasOne(d => d.Room).WithMany(p => p.Coins)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_c4e6710737");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.Coins)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_7be688a3eb");

            entity.HasOne(d => d.Trench).WithMany(p => p.Coins)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_9b475533dc");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.Coins)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_e5a993ec21");

            entity.HasOne(d => d.Zone).WithMany(p => p.Coins)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_9e0d61b08f");
        });

        modelBuilder.Entity<DrawType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("draw_types_pkey");

            entity.ToTable("draw_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Drawing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("drawings_pkey");

            entity.ToTable("drawings");

            entity.HasIndex(e => e.AreaId, "index_drawings_on_area_id");

            entity.HasIndex(e => e.DrawTypeId, "index_drawings_on_draw_type_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annex)
                .HasColumnType("character varying")
                .HasColumnName("annex");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DrawTypeId).HasColumnName("draw_type_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Room)
                .HasColumnType("character varying")
                .HasColumnName("room");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Trench)
                .HasColumnType("character varying")
                .HasColumnName("trench");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Zone)
                .HasColumnType("character varying")
                .HasColumnName("zone");

            entity.HasOne(d => d.Area).WithMany(p => p.Drawings)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_1b6d79a393");

            entity.HasOne(d => d.DrawType).WithMany(p => p.Drawings)
                .HasForeignKey(d => d.DrawTypeId)
                .HasConstraintName("fk_rails_3feca8b207");
        });

        modelBuilder.Entity<EpigraphicElement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("epigraphic_elements_pkey");

            entity.ToTable("epigraphic_elements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abbreviations)
                .HasColumnType("character varying")
                .HasColumnName("abbreviations");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.Connections)
                .HasColumnType("character varying")
                .HasColumnName("connections");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DescrDecor)
                .HasColumnType("character varying")
                .HasColumnName("descr_decor");
            entity.Property(e => e.Edition).HasColumnName("edition");
            entity.Property(e => e.FabTechnique)
                .HasColumnType("character varying")
                .HasColumnName("fab_technique");
            entity.Property(e => e.Gaps)
                .HasColumnType("character varying")
                .HasColumnName("gaps");
            entity.Property(e => e.Guidelines)
                .HasColumnType("character varying")
                .HasColumnName("guidelines");
            entity.Property(e => e.IdObj).HasColumnName("id_obj");
            entity.Property(e => e.InterpunctionSeparationSystems)
                .HasColumnType("character varying")
                .HasColumnName("interpunction_separation_systems");
            entity.Property(e => e.LineSpacing)
                .HasColumnType("character varying")
                .HasColumnName("line_spacing");
            entity.Property(e => e.Margins)
                .HasColumnType("character varying")
                .HasColumnName("margins");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Notes)
                .HasColumnType("character varying")
                .HasColumnName("notes");
            entity.Property(e => e.OrigText).HasColumnName("orig_text");
            entity.Property(e => e.PaleographicComment).HasColumnName("paleographic_comment");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Reuse)
                .HasColumnType("character varying")
                .HasColumnName("reuse");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.TextLayout)
                .HasColumnType("character varying")
                .HasColumnName("text_layout");
            entity.Property(e => e.TransText).HasColumnName("trans_text");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum).HasColumnName("us_num");
            entity.Property(e => e.WritingTipology)
                .HasColumnType("character varying")
                .HasColumnName("writing_tipology");
        });

        modelBuilder.Entity<GeneralBibliography>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("general_bibliographies_pkey");

            entity.ToTable("general_bibliographies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abbreviation)
                .HasColumnType("character varying")
                .HasColumnName("abbreviation");
            entity.Property(e => e.Abstract).HasColumnName("abstract");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.Citation)
                .HasColumnType("character varying")
                .HasColumnName("citation");
            entity.Property(e => e.CitedBy)
                .HasColumnType("character varying")
                .HasColumnName("cited_by");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Consulted).HasColumnName("consulted");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Edition)
                .HasColumnType("character varying")
                .HasColumnName("edition");
            entity.Property(e => e.Editor)
                .HasColumnType("character varying")
                .HasColumnName("editor");
            entity.Property(e => e.Illustrations)
                .HasColumnType("character varying")
                .HasColumnName("illustrations");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Isbn)
                .HasColumnType("character varying")
                .HasColumnName("isbn");
            entity.Property(e => e.Language)
                .HasColumnType("character varying")
                .HasColumnName("language");
            entity.Property(e => e.Library)
                .HasColumnType("character varying")
                .HasColumnName("library");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OnlineResources)
                .HasColumnType("character varying")
                .HasColumnName("online_resources");
            entity.Property(e => e.Publisher)
                .HasColumnType("character varying")
                .HasColumnName("publisher");
            entity.Property(e => e.Review)
                .HasColumnType("character varying")
                .HasColumnName("review");
            entity.Property(e => e.Serial)
                .HasColumnType("character varying")
                .HasColumnName("serial");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.TypeProduct)
                .HasColumnType("character varying")
                .HasColumnName("type_product");
            entity.Property(e => e.Typographer)
                .HasColumnType("character varying")
                .HasColumnName("typographer");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Glass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("glasses_pkey");

            entity.ToTable("glasses");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_glasses_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_glasses_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_glasses_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_glasses_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_glasses_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_glasses_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_glasses_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_glasses_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_glasses_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_glasses_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_glasses_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_glasses_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_glasses_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.Beak).HasColumnName("beak");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Bottom).HasColumnName("bottom");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations).HasColumnName("decorations");
            entity.Property(e => e.DescrDecor).HasColumnName("descr_decor");
            entity.Property(e => e.DescrEp).HasColumnName("descr_ep");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DiameterBottomCm).HasColumnName("diameter_bottom_cm");
            entity.Property(e => e.DiameterRimCm).HasColumnName("diameter_rim_cm");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.FabTechnique)
                .HasColumnType("character varying")
                .HasColumnName("fab_technique");
            entity.Property(e => e.Form)
                .HasColumnType("character varying")
                .HasColumnName("form");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.GlassClass)
                .HasColumnType("character varying")
                .HasColumnName("glass_class");
            entity.Property(e => e.GlassColor)
                .HasColumnType("character varying")
                .HasColumnName("glass_color");
            entity.Property(e => e.GlassType)
                .HasColumnType("character varying")
                .HasColumnName("glass_type");
            entity.Property(e => e.Grip).HasColumnName("grip");
            entity.Property(e => e.Handle).HasColumnName("handle");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.MeasuresCm).HasColumnName("measures_cm");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Production)
                .HasColumnType("character varying")
                .HasColumnName("production");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Rim).HasColumnName("rim");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WeightG).HasColumnName("weight_g");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_45b9636301");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_6dc492be01");

            entity.HasOne(d => d.Drawing).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_2d5f5e7665");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_9792603952");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_8f4b7fe304");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_9425884daa");

            entity.HasOne(d => d.Photograph).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_5defe0d3cd");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_a4b9bbea8c");

            entity.HasOne(d => d.Room).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_35621b4fb1");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_860501a088");

            entity.HasOne(d => d.Trench).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_2155dc0912");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_5e82a81d77");

            entity.HasOne(d => d.Zone).WithMany(p => p.Glasses)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_2f0a3377ed");
        });

        modelBuilder.Entity<IconographicSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iconographic_sources_pkey");

            entity.ToTable("iconographic_sources");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_iconographic_sources_on_general_bibliography_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.Bibliography).HasColumnName("bibliography");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrentLocation)
                .HasColumnType("character varying")
                .HasColumnName("current_location");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.ShortDescr).HasColumnName("short_descr");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.Type1)
                .HasColumnType("character varying")
                .HasColumnName("type_1");
            entity.Property(e => e.Type2)
                .HasColumnType("character varying")
                .HasColumnName("type_2");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Zone)
                .HasColumnType("character varying")
                .HasColumnName("zone");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.IconographicSources)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_13613f7094");
        });

        modelBuilder.Entity<IntangibleElement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("intangible_elements_pkey");

            entity.ToTable("intangible_elements");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_intangible_elements_on_archival_drawing_id");

            entity.HasIndex(e => e.DrawingId, "index_intangible_elements_on_drawing_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_intangible_elements_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_intangible_elements_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_intangible_elements_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_intangible_elements_on_photographic_source_id");

            entity.HasIndex(e => e.WrittenSourceId, "index_intangible_elements_on_written_source_id");

            entity.HasIndex(e => e.WrittenSourcesExtractId, "index_intangible_elements_on_written_sources_extract_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_intangible_elements_on_written_sources_object_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.Calendar)
                .HasColumnType("character varying")
                .HasColumnName("calendar");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Location)
                .HasColumnType("character varying")
                .HasColumnName("location");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.ShortDescr).HasColumnName("short_descr");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WrittenSourceId).HasColumnName("written_source_id");
            entity.Property(e => e.WrittenSourcesExtractId).HasColumnName("written_sources_extract_id");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.Zone)
                .HasColumnType("character varying")
                .HasColumnName("zone");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_bd8631f0f8");

            entity.HasOne(d => d.Drawing).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_d001072e26");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_32dfb55fd9");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_708e642760");

            entity.HasOne(d => d.Photograph).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_357acb3c4c");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_8e7785ca27");

            entity.HasOne(d => d.WrittenSource).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.WrittenSourceId)
                .HasConstraintName("fk_rails_0dfcbca0e5");

            entity.HasOne(d => d.WrittenSourcesExtract).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.WrittenSourcesExtractId)
                .HasConstraintName("fk_rails_31af2d82b0");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.IntangibleElements)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_ec715fdce7");
        });

        modelBuilder.Entity<Locu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_pkey");

            entity.ToTable("locus");

            entity.HasIndex(e => e.AreaId, "index_locus_on_area_id");

            entity.HasIndex(e => e.DrawTypeId, "index_locus_on_draw_type_id");

            entity.HasIndex(e => e.LocusFormationId, "index_locus_on_locus_formation_id");

            entity.HasIndex(e => e.TrenchId, "index_locus_on_trench_id");

            entity.HasIndex(e => e.ZoneId, "index_locus_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abuts)
                .HasColumnType("character varying")
                .HasColumnName("abuts");
            entity.Property(e => e.AbuttedBy)
                .HasColumnType("character varying")
                .HasColumnName("abutted_by");
            entity.Property(e => e.Activity)
                .HasColumnType("character varying")
                .HasColumnName("activity");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.BindsWith)
                .HasColumnType("character varying")
                .HasColumnName("binds_with");
            entity.Property(e => e.Color)
                .HasColumnType("character varying")
                .HasColumnName("color");
            entity.Property(e => e.CompArt)
                .HasColumnType("character varying")
                .HasColumnName("comp_art");
            entity.Property(e => e.CompGeo)
                .HasColumnType("character varying")
                .HasColumnName("comp_geo");
            entity.Property(e => e.CompOrg)
                .HasColumnType("character varying")
                .HasColumnName("comp_org");
            entity.Property(e => e.Consistency)
                .HasColumnType("character varying")
                .HasColumnName("consistency");
            entity.Property(e => e.CoveredBy)
                .HasColumnType("character varying")
                .HasColumnName("covered_by");
            entity.Property(e => e.Covers)
                .HasColumnType("character varying")
                .HasColumnName("covers");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CronMax)
                .HasColumnType("character varying")
                .HasColumnName("cron_max");
            entity.Property(e => e.CronMin)
                .HasColumnType("character varying")
                .HasColumnName("cron_min");
            entity.Property(e => e.CutBy)
                .HasColumnType("character varying")
                .HasColumnName("cut_by");
            entity.Property(e => e.Cuts)
                .HasColumnType("character varying")
                .HasColumnName("cuts");
            entity.Property(e => e.DateComp)
                .HasColumnType("character varying")
                .HasColumnName("date_comp");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.Dependability)
                .HasColumnType("character varying")
                .HasColumnName("dependability");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Director)
                .HasColumnType("character varying")
                .HasColumnName("director");
            entity.Property(e => e.DistCriteria)
                .HasColumnType("character varying")
                .HasColumnName("dist_criteria");
            entity.Property(e => e.DrawType1)
                .HasColumnType("character varying")
                .HasColumnName("draw_type1");
            entity.Property(e => e.DrawTypeId).HasColumnName("draw_type_id");
            entity.Property(e => e.Emax).HasColumnName("emax");
            entity.Property(e => e.Emin).HasColumnName("emin");
            entity.Property(e => e.EndExcavationsUsReason).HasColumnName("end_excavations_us_reason");
            entity.Property(e => e.ExcYear)
                .HasColumnType("character varying")
                .HasColumnName("exc_year");
            entity.Property(e => e.FilledBy)
                .HasColumnType("character varying")
                .HasColumnName("filled_by");
            entity.Property(e => e.Fills)
                .HasColumnType("character varying")
                .HasColumnName("fills");
            entity.Property(e => e.IdAdw)
                .HasColumnType("character varying")
                .HasColumnName("id_adw");
            entity.Property(e => e.IdBiblio)
                .HasColumnType("character varying")
                .HasColumnName("id_biblio");
            entity.Property(e => e.IdPhs)
                .HasColumnType("character varying")
                .HasColumnName("id_phs");
            entity.Property(e => e.ImageDw)
                .HasColumnType("character varying")
                .HasColumnName("image_dw");
            entity.Property(e => e.ImageDw1)
                .HasColumnType("character varying")
                .HasColumnName("image_dw1");
            entity.Property(e => e.ImagePh)
                .HasColumnType("character varying")
                .HasColumnName("image_ph");
            entity.Property(e => e.ImagePh1)
                .HasColumnType("character varying")
                .HasColumnName("image_ph1");
            entity.Property(e => e.Interpretation)
                .HasColumnType("character varying")
                .HasColumnName("interpretation");
            entity.Property(e => e.Later).HasColumnName("later");
            entity.Property(e => e.LocusFormationId).HasColumnName("locus_formation_id");
            entity.Property(e => e.Measures)
                .HasColumnType("character varying")
                .HasColumnName("measures");
            entity.Property(e => e.Observations)
                .HasColumnType("character varying")
                .HasColumnName("observations");
            entity.Property(e => e.Period)
                .HasColumnType("character varying")
                .HasColumnName("period");
            entity.Property(e => e.Phase)
                .HasColumnType("character varying")
                .HasColumnName("phase");
            entity.Property(e => e.Preservation)
                .HasColumnType("character varying")
                .HasColumnName("preservation");
            entity.Property(e => e.PriorTo).HasColumnName("prior_to");
            entity.Property(e => e.QMaxEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_max_end");
            entity.Property(e => e.QMaxStart)
                .HasColumnType("character varying")
                .HasColumnName("q_max_start");
            entity.Property(e => e.QMinEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_min_end");
            entity.Property(e => e.QMinStart)
                .HasColumnType("character varying")
                .HasColumnName("q_min_start");
            entity.Property(e => e.SameAs)
                .HasColumnType("character varying")
                .HasColumnName("same_as");
            entity.Property(e => e.Sampling).HasColumnName("sampling");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.StartExcavationsUs).HasColumnName("start_excavations_us");
            entity.Property(e => e.StartExcavationsUsReason).HasColumnName("start_excavations_us_reason");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsLocation)
                .HasColumnType("character varying")
                .HasColumnName("us_location");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Area).WithMany(p => p.Locus)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_14bcaa326a");

            entity.HasOne(d => d.DrawType).WithMany(p => p.Locus)
                .HasForeignKey(d => d.DrawTypeId)
                .HasConstraintName("fk_rails_be93115fb7");

            entity.HasOne(d => d.LocusFormation).WithMany(p => p.Locus)
                .HasForeignKey(d => d.LocusFormationId)
                .HasConstraintName("fk_rails_0a1ca24430");

            entity.HasOne(d => d.Trench).WithMany(p => p.Locus)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_9174380a5a");

            entity.HasOne(d => d.Zone).WithMany(p => p.Locus)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_bf3b060caa");
        });

        modelBuilder.Entity<LocusCoating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_coatings_pkey");

            entity.ToTable("locus_coatings");

            entity.HasIndex(e => e.AreaId, "index_locus_coatings_on_area_id");

            entity.HasIndex(e => e.DrawTypeId, "index_locus_coatings_on_draw_type_id");

            entity.HasIndex(e => e.RoomId, "index_locus_coatings_on_room_id");

            entity.HasIndex(e => e.TrenchId, "index_locus_coatings_on_trench_id");

            entity.HasIndex(e => e.ZoneId, "index_locus_coatings_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abuts)
                .HasColumnType("character varying")
                .HasColumnName("abuts");
            entity.Property(e => e.AbuttedBy)
                .HasColumnType("character varying")
                .HasColumnName("abutted_by");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.BackPrints1)
                .HasColumnType("character varying")
                .HasColumnName("back_prints_1");
            entity.Property(e => e.BackPrints2)
                .HasColumnType("character varying")
                .HasColumnName("back_prints_2");
            entity.Property(e => e.BackPrints3)
                .HasColumnType("character varying")
                .HasColumnName("back_prints_3");
            entity.Property(e => e.BackPrints4)
                .HasColumnType("character varying")
                .HasColumnName("back_prints_4");
            entity.Property(e => e.BindsWith)
                .HasColumnType("character varying")
                .HasColumnName("binds_with");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CoatingTechnique)
                .HasColumnType("character varying")
                .HasColumnName("coating_technique");
            entity.Property(e => e.Color1)
                .HasColumnType("character varying")
                .HasColumnName("color_1");
            entity.Property(e => e.Color2)
                .HasColumnType("character varying")
                .HasColumnName("color_2");
            entity.Property(e => e.Color3)
                .HasColumnType("character varying")
                .HasColumnName("color_3");
            entity.Property(e => e.Color4)
                .HasColumnType("character varying")
                .HasColumnName("color_4");
            entity.Property(e => e.CompInorg1)
                .HasColumnType("character varying")
                .HasColumnName("comp_inorg_1");
            entity.Property(e => e.CompInorg2)
                .HasColumnType("character varying")
                .HasColumnName("comp_inorg_2");
            entity.Property(e => e.CompInorg3)
                .HasColumnType("character varying")
                .HasColumnName("comp_inorg_3");
            entity.Property(e => e.CompInorg4)
                .HasColumnType("character varying")
                .HasColumnName("comp_inorg_4");
            entity.Property(e => e.CompOrg1)
                .HasColumnType("character varying")
                .HasColumnName("comp_org_1");
            entity.Property(e => e.CompOrg2)
                .HasColumnType("character varying")
                .HasColumnName("comp_org_2");
            entity.Property(e => e.CompOrg3)
                .HasColumnType("character varying")
                .HasColumnName("comp_org_3");
            entity.Property(e => e.CompOrg4)
                .HasColumnType("character varying")
                .HasColumnName("comp_org_4");
            entity.Property(e => e.Consolidation)
                .HasColumnType("character varying")
                .HasColumnName("consolidation");
            entity.Property(e => e.CordBeat1)
                .HasColumnType("character varying")
                .HasColumnName("cord_beat_1");
            entity.Property(e => e.CordBeat2)
                .HasColumnType("character varying")
                .HasColumnName("cord_beat_2");
            entity.Property(e => e.CordBeat3)
                .HasColumnType("character varying")
                .HasColumnName("cord_beat_3");
            entity.Property(e => e.CordBeat4)
                .HasColumnType("character varying")
                .HasColumnName("cord_beat_4");
            entity.Property(e => e.CornerProfile).HasColumnName("corner_profile");
            entity.Property(e => e.CoveredBy)
                .HasColumnType("character varying")
                .HasColumnName("covered_by");
            entity.Property(e => e.Covers)
                .HasColumnType("character varying")
                .HasColumnName("covers");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DateComp).HasColumnName("date_comp");
            entity.Property(e => e.DatingElements)
                .HasColumnType("character varying")
                .HasColumnName("dating_elements");
            entity.Property(e => e.DefectsInAdesion)
                .HasColumnType("character varying")
                .HasColumnName("defects_in_adesion");
            entity.Property(e => e.DefectsInCohesion)
                .HasColumnType("character varying")
                .HasColumnName("defects_in_cohesion");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.Dependability)
                .HasColumnType("character varying")
                .HasColumnName("dependability");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Detachment)
                .HasColumnType("character varying")
                .HasColumnName("detachment");
            entity.Property(e => e.Director)
                .HasColumnType("character varying")
                .HasColumnName("director");
            entity.Property(e => e.DrawTypeId).HasColumnName("draw_type_id");
            entity.Property(e => e.Emax).HasColumnName("emax");
            entity.Property(e => e.Emin).HasColumnName("emin");
            entity.Property(e => e.EndExcavationsUsReason).HasColumnName("end_excavations_us_reason");
            entity.Property(e => e.EpigraphicDate)
                .HasColumnType("character varying")
                .HasColumnName("epigraphic_date");
            entity.Property(e => e.ExcYear).HasColumnName("exc_year");
            entity.Property(e => e.Form)
                .HasColumnType("character varying")
                .HasColumnName("form");
            entity.Property(e => e.Gaps)
                .HasColumnType("character varying")
                .HasColumnName("gaps");
            entity.Property(e => e.Glazing)
                .HasColumnType("character varying")
                .HasColumnName("glazing");
            entity.Property(e => e.Gluing)
                .HasColumnType("character varying")
                .HasColumnName("gluing");
            entity.Property(e => e.Graffito1)
                .HasColumnType("character varying")
                .HasColumnName("graffito_1");
            entity.Property(e => e.Graffito2)
                .HasColumnType("character varying")
                .HasColumnName("graffito_2");
            entity.Property(e => e.Graffito3)
                .HasColumnType("character varying")
                .HasColumnName("graffito_3");
            entity.Property(e => e.Graffito4)
                .HasColumnType("character varying")
                .HasColumnName("graffito_4");
            entity.Property(e => e.IdAdw)
                .HasColumnType("character varying")
                .HasColumnName("id_adw");
            entity.Property(e => e.IdAs)
                .HasColumnType("character varying")
                .HasColumnName("id_as");
            entity.Property(e => e.IdBiblio)
                .HasColumnType("character varying")
                .HasColumnName("id_biblio");
            entity.Property(e => e.IdDw)
                .HasColumnType("character varying")
                .HasColumnName("id_dw");
            entity.Property(e => e.IdExtract)
                .HasColumnType("character varying")
                .HasColumnName("id_extract");
            entity.Property(e => e.IdIco)
                .HasColumnType("character varying")
                .HasColumnName("id_ico");
            entity.Property(e => e.IdIe)
                .HasColumnType("character varying")
                .HasColumnName("id_ie");
            entity.Property(e => e.IdPh)
                .HasColumnType("character varying")
                .HasColumnName("id_ph");
            entity.Property(e => e.IdPhs)
                .HasColumnType("character varying")
                .HasColumnName("id_phs");
            entity.Property(e => e.IdWs)
                .HasColumnType("character varying")
                .HasColumnName("id_ws");
            entity.Property(e => e.Incrustations)
                .HasColumnType("character varying")
                .HasColumnName("incrustations");
            entity.Property(e => e.LabAddress)
                .HasColumnType("character varying")
                .HasColumnName("lab_address");
            entity.Property(e => e.Later).HasColumnName("later");
            entity.Property(e => e.Layer1)
                .HasColumnType("character varying")
                .HasColumnName("layer_1");
            entity.Property(e => e.Layer2)
                .HasColumnType("character varying")
                .HasColumnName("layer_2");
            entity.Property(e => e.Layer3)
                .HasColumnType("character varying")
                .HasColumnName("layer_3");
            entity.Property(e => e.Layer4)
                .HasColumnType("character varying")
                .HasColumnName("layer_4");
            entity.Property(e => e.Materials)
                .HasColumnType("character varying")
                .HasColumnName("materials");
            entity.Property(e => e.Measures)
                .HasColumnType("character varying")
                .HasColumnName("measures");
            entity.Property(e => e.N100Cmq)
                .HasColumnType("character varying")
                .HasColumnName("n_100_cmq");
            entity.Property(e => e.Observations).HasColumnName("observations");
            entity.Property(e => e.Other)
                .HasColumnType("character varying")
                .HasColumnName("other");
            entity.Property(e => e.OverlaysColors)
                .HasColumnType("character varying")
                .HasColumnName("overlays_colors");
            entity.Property(e => e.Packaging)
                .HasColumnType("character varying")
                .HasColumnName("packaging");
            entity.Property(e => e.PeriodEnd)
                .HasColumnType("character varying")
                .HasColumnName("period_end");
            entity.Property(e => e.PeriodStart)
                .HasColumnType("character varying")
                .HasColumnName("period_start");
            entity.Property(e => e.Phase)
                .HasColumnType("character varying")
                .HasColumnName("phase");
            entity.Property(e => e.PriorTo).HasColumnName("prior_to");
            entity.Property(e => e.QMaxEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_max_end");
            entity.Property(e => e.QMaxStart)
                .HasColumnType("character varying")
                .HasColumnName("q_max_start");
            entity.Property(e => e.QMinEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_min_end");
            entity.Property(e => e.QMinStart)
                .HasColumnType("character varying")
                .HasColumnName("q_min_start");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SameAs)
                .HasColumnType("character varying")
                .HasColumnName("same_as");
            entity.Property(e => e.SamplyngToAnalysis)
                .HasColumnType("character varying")
                .HasColumnName("samplyng_to_analysis");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.Sinopia1)
                .HasColumnType("character varying")
                .HasColumnName("sinopia_1");
            entity.Property(e => e.Sinopia2)
                .HasColumnType("character varying")
                .HasColumnName("sinopia_2");
            entity.Property(e => e.Sinopia3)
                .HasColumnType("character varying")
                .HasColumnName("sinopia_3");
            entity.Property(e => e.Sinopia4)
                .HasColumnType("character varying")
                .HasColumnName("sinopia_4");
            entity.Property(e => e.StartExcavationsUs).HasColumnName("start_excavations_us");
            entity.Property(e => e.StartExcavationsUsReason).HasColumnName("start_excavations_us_reason");
            entity.Property(e => e.StuctureRel)
                .HasColumnType("character varying")
                .HasColumnName("stucture_rel");
            entity.Property(e => e.StylisticPhase)
                .HasColumnType("character varying")
                .HasColumnName("stylistic_phase");
            entity.Property(e => e.Surface)
                .HasColumnType("character varying")
                .HasColumnName("surface");
            entity.Property(e => e.SurfaceColors)
                .HasColumnType("character varying")
                .HasColumnName("surface_colors");
            entity.Property(e => e.SurfaceDeposits)
                .HasColumnType("character varying")
                .HasColumnName("surface_deposits");
            entity.Property(e => e.TemporaryCovering)
                .HasColumnType("character varying")
                .HasColumnName("temporary_covering");
            entity.Property(e => e.Tickhess1)
                .HasColumnType("character varying")
                .HasColumnName("tickhess_1");
            entity.Property(e => e.Tickhess2)
                .HasColumnType("character varying")
                .HasColumnName("tickhess_2");
            entity.Property(e => e.Tickhess3)
                .HasColumnType("character varying")
                .HasColumnName("tickhess_3");
            entity.Property(e => e.Tickhess4)
                .HasColumnType("character varying")
                .HasColumnName("tickhess_4");
            entity.Property(e => e.Trama).HasColumnName("trama");
            entity.Property(e => e.TramaMaterials)
                .HasColumnType("character varying")
                .HasColumnName("trama_materials");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsLocation)
                .HasColumnType("character varying")
                .HasColumnName("us_location");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.Usury)
                .HasColumnType("character varying")
                .HasColumnName("usury");
            entity.Property(e => e.Warp)
                .HasColumnType("character varying")
                .HasColumnName("warp");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Area).WithMany(p => p.LocusCoatings)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_1dd1502da8");

            entity.HasOne(d => d.DrawType).WithMany(p => p.LocusCoatings)
                .HasForeignKey(d => d.DrawTypeId)
                .HasConstraintName("fk_rails_c6c5609343");

            entity.HasOne(d => d.Room).WithMany(p => p.LocusCoatings)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_92f8f12fb2");

            entity.HasOne(d => d.Trench).WithMany(p => p.LocusCoatings)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_b980f12fd0");

            entity.HasOne(d => d.Zone).WithMany(p => p.LocusCoatings)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_d21bec3ff5");
        });

        modelBuilder.Entity<LocusCoatingsPhotographicSource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locus_coatings_photographic_sources");

            entity.HasIndex(e => new { e.LocusCoatingId, e.PhotographicSourceId }, "locucoat_phsrc");

            entity.Property(e => e.LocusCoatingId).HasColumnName("locus_coating_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
        });

        modelBuilder.Entity<LocusComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_components_pkey");

            entity.ToTable("locus_components");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<LocusDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_definitions_pkey");

            entity.ToTable("locus_definitions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<LocusFormation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_formations_pkey");

            entity.ToTable("locus_formations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<LocusList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_lists_pkey");

            entity.ToTable("locus_lists");

            entity.HasIndex(e => e.AreaId, "index_locus_lists_on_area_id");

            entity.HasIndex(e => e.TrenchId, "index_locus_lists_on_trench_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsLocation)
                .HasColumnType("character varying")
                .HasColumnName("us_location");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.UsType)
                .HasColumnType("character varying")
                .HasColumnName("us_type");

            entity.HasOne(d => d.Area).WithMany(p => p.LocusLists)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_e0492e2cef");

            entity.HasOne(d => d.Trench).WithMany(p => p.LocusLists)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_f8327c513c");
        });

        modelBuilder.Entity<LocusListsPhotographicSource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locus_lists_photographic_sources");

            entity.HasIndex(e => new { e.PhotographicSourceId, e.LocusListId }, "phsrc_loclist");

            entity.Property(e => e.LocusListId).HasColumnName("locus_list_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
        });

        modelBuilder.Entity<LocusRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locus_rooms");

            entity.HasIndex(e => new { e.LocuId, e.RoomId }, "index_locus_rooms_on_locu_id_and_room_id");

            entity.Property(e => e.LocuId).HasColumnName("locu_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
        });

        modelBuilder.Entity<LocusWall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("locus_walls_pkey");

            entity.ToTable("locus_walls");

            entity.HasIndex(e => e.AreaId, "index_locus_walls_on_area_id");

            entity.HasIndex(e => e.BricksClayId, "index_locus_walls_on_bricks_clay_id");

            entity.HasIndex(e => e.BricksConsistenceId, "index_locus_walls_on_bricks_consistence_id");

            entity.HasIndex(e => e.BricksFormId, "index_locus_walls_on_bricks_form_id");

            entity.HasIndex(e => e.BricksInstallationId, "index_locus_walls_on_bricks_installation_id");

            entity.HasIndex(e => e.BricksWorkingId, "index_locus_walls_on_bricks_working_id");

            entity.HasIndex(e => e.DrawTypeId, "index_locus_walls_on_draw_type_id");

            entity.HasIndex(e => e.MaterialProvenanceId, "index_locus_walls_on_material_provenance_id");

            entity.HasIndex(e => e.RoomId, "index_locus_walls_on_room_id");

            entity.HasIndex(e => e.StoneCuttingId, "index_locus_walls_on_stone_cutting_id");

            entity.HasIndex(e => e.StoneFormId, "index_locus_walls_on_stone_form_id");

            entity.HasIndex(e => e.StoneInstallationId, "index_locus_walls_on_stone_installation_id");

            entity.HasIndex(e => e.StoneWorkingId, "index_locus_walls_on_stone_working_id");

            entity.HasIndex(e => e.TrenchId, "index_locus_walls_on_trench_id");

            entity.HasIndex(e => e.ZoneId, "index_locus_walls_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abuts)
                .HasColumnType("character varying")
                .HasColumnName("abuts");
            entity.Property(e => e.AbuttedBy)
                .HasColumnType("character varying")
                .HasColumnName("abutted_by");
            entity.Property(e => e.Activity)
                .HasColumnType("character varying")
                .HasColumnName("activity");
            entity.Property(e => e.Aggregates)
                .HasColumnType("character varying")
                .HasColumnName("aggregates");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Binder)
                .HasColumnType("character varying")
                .HasColumnName("binder");
            entity.Property(e => e.BinderColor)
                .HasColumnType("character varying")
                .HasColumnName("binder_color");
            entity.Property(e => e.BinderConsistency)
                .HasColumnType("character varying")
                .HasColumnName("binder_consistency");
            entity.Property(e => e.BinderType)
                .HasColumnType("character varying")
                .HasColumnName("binder_type");
            entity.Property(e => e.BindsWith)
                .HasColumnType("character varying")
                .HasColumnName("binds_with");
            entity.Property(e => e.Bricks)
                .HasColumnType("character varying")
                .HasColumnName("bricks");
            entity.Property(e => e.BricksClayId).HasColumnName("bricks_clay_id");
            entity.Property(e => e.BricksColor)
                .HasColumnType("character varying")
                .HasColumnName("bricks_color");
            entity.Property(e => e.BricksConsistenceId).HasColumnName("bricks_consistence_id");
            entity.Property(e => e.BricksFormId).HasColumnName("bricks_form_id");
            entity.Property(e => e.BricksInstallationId).HasColumnName("bricks_installation_id");
            entity.Property(e => e.BricksWorkingId).HasColumnName("bricks_working_id");
            entity.Property(e => e.CoveredBy)
                .HasColumnType("character varying")
                .HasColumnName("covered_by");
            entity.Property(e => e.Covers)
                .HasColumnType("character varying")
                .HasColumnName("covers");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CronMax).HasColumnName("cron_max");
            entity.Property(e => e.CronMin).HasColumnName("cron_min");
            entity.Property(e => e.CutBy)
                .HasColumnType("character varying")
                .HasColumnName("cut_by");
            entity.Property(e => e.Cuts)
                .HasColumnType("character varying")
                .HasColumnName("cuts");
            entity.Property(e => e.DateComp)
                .HasColumnType("character varying")
                .HasColumnName("date_comp");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.Dependability)
                .HasColumnType("character varying")
                .HasColumnName("dependability");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Director)
                .HasColumnType("character varying")
                .HasColumnName("director");
            entity.Property(e => e.DistCriteria)
                .HasColumnType("character varying")
                .HasColumnName("dist_criteria");
            entity.Property(e => e.DrawTypeId).HasColumnName("draw_type_id");
            entity.Property(e => e.Emax).HasColumnName("emax");
            entity.Property(e => e.Emin).HasColumnName("emin");
            entity.Property(e => e.EndExcavationsUsReason).HasColumnName("end_excavations_us_reason");
            entity.Property(e => e.ExcYear).HasColumnName("exc_year");
            entity.Property(e => e.FilledBy)
                .HasColumnType("character varying")
                .HasColumnName("filled_by");
            entity.Property(e => e.Fills)
                .HasColumnType("character varying")
                .HasColumnName("fills");
            entity.Property(e => e.Finishing)
                .HasColumnType("character varying")
                .HasColumnName("finishing");
            entity.Property(e => e.IdAdw)
                .HasColumnType("character varying")
                .HasColumnName("id_adw");
            entity.Property(e => e.IdAs)
                .HasColumnType("character varying")
                .HasColumnName("id_as");
            entity.Property(e => e.IdBiblio)
                .HasColumnType("character varying")
                .HasColumnName("id_biblio");
            entity.Property(e => e.IdDw)
                .HasColumnType("character varying")
                .HasColumnName("id_dw");
            entity.Property(e => e.IdIco)
                .HasColumnType("character varying")
                .HasColumnName("id_ico");
            entity.Property(e => e.IdIe)
                .HasColumnType("character varying")
                .HasColumnName("id_ie");
            entity.Property(e => e.IdPh)
                .HasColumnType("character varying")
                .HasColumnName("id_ph");
            entity.Property(e => e.IdPhs)
                .HasColumnType("character varying")
                .HasColumnName("id_phs");
            entity.Property(e => e.IdWs)
                .HasColumnType("character varying")
                .HasColumnName("id_ws");
            entity.Property(e => e.IdWse)
                .HasColumnType("character varying")
                .HasColumnName("id_wse");
            entity.Property(e => e.ImageDw)
                .HasColumnType("character varying")
                .HasColumnName("image_dw");
            entity.Property(e => e.ImagePh)
                .HasColumnType("character varying")
                .HasColumnName("image_ph");
            entity.Property(e => e.Interpretation).HasColumnName("interpretation");
            entity.Property(e => e.Later).HasColumnName("later");
            entity.Property(e => e.MaterialProvenanceId).HasColumnName("material_provenance_id");
            entity.Property(e => e.Observation).HasColumnName("observation");
            entity.Property(e => e.PeriodEnd)
                .HasColumnType("character varying")
                .HasColumnName("period_end");
            entity.Property(e => e.PeriodStart)
                .HasColumnType("character varying")
                .HasColumnName("period_start");
            entity.Property(e => e.Phase)
                .HasColumnType("character varying")
                .HasColumnName("phase");
            entity.Property(e => e.Preservation)
                .HasColumnType("character varying")
                .HasColumnName("preservation");
            entity.Property(e => e.PriorTo).HasColumnName("prior_to");
            entity.Property(e => e.QMaxEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_max_end");
            entity.Property(e => e.QMaxStart)
                .HasColumnType("character varying")
                .HasColumnName("q_max_start");
            entity.Property(e => e.QMinEnd)
                .HasColumnType("character varying")
                .HasColumnName("q_min_end");
            entity.Property(e => e.QMinStart)
                .HasColumnType("character varying")
                .HasColumnName("q_min_start");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SameAs)
                .HasColumnType("character varying")
                .HasColumnName("same_as");
            entity.Property(e => e.Sampling).HasColumnName("sampling");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.StartExcavationsUs).HasColumnName("start_excavations_us");
            entity.Property(e => e.StartExcavationsUsReason).HasColumnName("start_excavations_us_reason");
            entity.Property(e => e.Stone)
                .HasColumnType("character varying")
                .HasColumnName("stone");
            entity.Property(e => e.StoneCuttingId).HasColumnName("stone_cutting_id");
            entity.Property(e => e.StoneFormId).HasColumnName("stone_form_id");
            entity.Property(e => e.StoneInstallationId).HasColumnName("stone_installation_id");
            entity.Property(e => e.StoneWorkingId).HasColumnName("stone_working_id");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsLocation)
                .HasColumnType("character varying")
                .HasColumnName("us_location");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Area).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_4961800735");

            entity.HasOne(d => d.BricksClay).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.BricksClayId)
                .HasConstraintName("fk_rails_86e3c86e06");

            entity.HasOne(d => d.BricksConsistence).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.BricksConsistenceId)
                .HasConstraintName("fk_rails_3b5bd95bae");

            entity.HasOne(d => d.BricksForm).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.BricksFormId)
                .HasConstraintName("fk_rails_c0823cbe21");

            entity.HasOne(d => d.BricksInstallation).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.BricksInstallationId)
                .HasConstraintName("fk_rails_8b68b799a5");

            entity.HasOne(d => d.BricksWorking).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.BricksWorkingId)
                .HasConstraintName("fk_rails_fbb35cee71");

            entity.HasOne(d => d.DrawType).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.DrawTypeId)
                .HasConstraintName("fk_rails_bf4748d737");

            entity.HasOne(d => d.MaterialProvenance).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.MaterialProvenanceId)
                .HasConstraintName("fk_rails_707adb012b");

            entity.HasOne(d => d.Room).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_8a200001ed");

            entity.HasOne(d => d.StoneCutting).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.StoneCuttingId)
                .HasConstraintName("fk_rails_208aa48685");

            entity.HasOne(d => d.StoneForm).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.StoneFormId)
                .HasConstraintName("fk_rails_366b54ae5d");

            entity.HasOne(d => d.StoneInstallation).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.StoneInstallationId)
                .HasConstraintName("fk_rails_5d03c89611");

            entity.HasOne(d => d.StoneWorking).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.StoneWorkingId)
                .HasConstraintName("fk_rails_6bc26a34dd");

            entity.HasOne(d => d.Trench).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_9e275a7881");

            entity.HasOne(d => d.Zone).WithMany(p => p.LocusWalls)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_7a7091f650");
        });

        modelBuilder.Entity<LocusWallsPhotographicSource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locus_walls_photographic_sources");

            entity.HasIndex(e => new { e.LocusWallId, e.PhotographicSourceId }, "locuswall_phsrc");

            entity.Property(e => e.LocusWallId).HasColumnName("locus_wall_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
        });

        modelBuilder.Entity<MaterialProvenance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("material_provenances_pkey");

            entity.ToTable("material_provenances");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Metal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("metals_pkey");

            entity.ToTable("metals");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_metals_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_metals_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_metals_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_metals_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_metals_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_metals_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_metals_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_metals_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_metals_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_metals_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_metals_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_metals_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_metals_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ClassMetal).HasColumnName("class_metal");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DefObject).HasColumnName("def_object");
            entity.Property(e => e.DescrDecor)
                .HasColumnType("character varying")
                .HasColumnName("descr_decor");
            entity.Property(e => e.DescrEp).HasColumnName("descr_ep");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.DesignatedUse)
                .HasColumnType("character varying")
                .HasColumnName("designated_use");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightCm).HasColumnName("height_cm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecMaterial)
                .HasColumnType("character varying")
                .HasColumnName("spec_material");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.SubclassMetal).HasColumnName("subclass_metal");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WeightG).HasColumnName("weight_g");
            entity.Property(e => e.WidthCm).HasColumnName("width_cm");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.Metals)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_776af471dc");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.Metals)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_a8e137493c");

            entity.HasOne(d => d.Drawing).WithMany(p => p.Metals)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_e73429b803");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.Metals)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_bb2195eb88");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.Metals)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_8bd209e034");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.Metals)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_ebc43ec35b");

            entity.HasOne(d => d.Photograph).WithMany(p => p.Metals)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_2849744811");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.Metals)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_6b9ef21213");

            entity.HasOne(d => d.Room).WithMany(p => p.Metals)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_b78d32d49a");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.Metals)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_bff85854e4");

            entity.HasOne(d => d.Trench).WithMany(p => p.Metals)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_ddaca601c7");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.Metals)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_10a71a520d");

            entity.HasOne(d => d.Zone).WithMany(p => p.Metals)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_9958df7d2b");
        });

        modelBuilder.Entity<MetalMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("metal_materials_pkey");

            entity.ToTable("metal_materials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OverallMaterialList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("overall_material_lists_pkey");

            entity.ToTable("overall_material_lists");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasColumnType("character varying")
                .HasColumnName("area");
            entity.Property(e => e.Basket)
                .HasColumnType("character varying")
                .HasColumnName("basket");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Drawed).HasColumnName("drawed");
            entity.Property(e => e.Filed).HasColumnName("filed");
            entity.Property(e => e.IdFinds)
                .HasColumnType("character varying")
                .HasColumnName("id_finds");
            entity.Property(e => e.IdSf)
                .HasColumnType("character varying")
                .HasColumnName("id_sf");
            entity.Property(e => e.Locus)
                .HasColumnType("character varying")
                .HasColumnName("locus");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Photographed).HasColumnName("photographed");
            entity.Property(e => e.Specifications).HasColumnName("specifications");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Photograph>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("photographs_pkey");

            entity.ToTable("photographs");

            entity.HasIndex(e => e.AreaId, "index_photographs_on_area_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Area).WithMany(p => p.Photographs)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_b3c58e35e6");
        });

        modelBuilder.Entity<PhotographicSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("photographic_sources_pkey");

            entity.ToTable("photographic_sources");

            entity.HasIndex(e => e.AreaId, "index_photographic_sources_on_area_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_photographic_sources_on_general_bibliography_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Fond)
                .HasColumnType("character varying")
                .HasColumnName("fond");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.IdAs)
                .HasColumnType("character varying")
                .HasColumnName("id_as");
            entity.Property(e => e.IdWs)
                .HasColumnType("character varying")
                .HasColumnName("id_ws");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Area).WithMany(p => p.PhotographicSources)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_rails_f349efcc7b");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.PhotographicSources)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_5924e893b3");
        });

        modelBuilder.Entity<PhotographicSourcesRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("photographic_sources_rooms");

            entity.HasIndex(e => new { e.PhotographicSourceId, e.RoomId }, "phsrc_rooms");

            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
        });

        modelBuilder.Entity<PhotographicSourcesTrench>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("photographic_sources_trenches");

            entity.HasIndex(e => new { e.PhotographicSourceId, e.TrenchId }, "phsrc_trenches");

            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
        });

        modelBuilder.Entity<PhotographicSourcesZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("photographic_sources_zones");

            entity.HasIndex(e => new { e.PhotographicSourceId, e.ZoneId }, "phsrc_zones");

            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
        });

        modelBuilder.Entity<Pottery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("potteries_pkey");

            entity.ToTable("potteries");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_potteries_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_potteries_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_potteries_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_potteries_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_potteries_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_potteries_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_potteries_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_potteries_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_potteries_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_potteries_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_potteries_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_potteries_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_potteries_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.Beak).HasColumnName("beak");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Bottom).HasColumnName("bottom");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ClayType)
                .HasColumnType("character varying")
                .HasColumnName("clay_type");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DescrEp).HasColumnName("descr_ep");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DiameterBottomCm).HasColumnName("diameter_bottom_cm");
            entity.Property(e => e.DiameterRimCm).HasColumnName("diameter_rim_cm");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.ExtCoating)
                .HasColumnType("character varying")
                .HasColumnName("ext_coating");
            entity.Property(e => e.FabTechnique)
                .HasColumnType("character varying")
                .HasColumnName("fab_technique");
            entity.Property(e => e.Form)
                .HasColumnType("character varying")
                .HasColumnName("form");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.Grip).HasColumnName("grip");
            entity.Property(e => e.Handle).HasColumnName("handle");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.IntCoating)
                .HasColumnType("character varying")
                .HasColumnName("int_coating");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.MeasuresCm).HasColumnName("measures_cm");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.PotteryClass)
                .HasColumnType("character varying")
                .HasColumnName("pottery_class");
            entity.Property(e => e.PotteryType)
                .HasColumnType("character varying")
                .HasColumnName("pottery_type");
            entity.Property(e => e.Production)
                .HasColumnType("character varying")
                .HasColumnName("production");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Rim).HasColumnName("rim");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WeightG).HasColumnName("weight_g");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_3f58eff6ba");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_a25fb93e5f");

            entity.HasOne(d => d.Drawing).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_c235607829");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_c459179e7f");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_4ef9dbe1ed");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_430ec8952f");

            entity.HasOne(d => d.Photograph).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_d5de8a6ece");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_4e02ba4b91");

            entity.HasOne(d => d.Room).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_e653c284a9");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_355e3719a6");

            entity.HasOne(d => d.Trench).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_5909ad6359");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_3569aefb64");

            entity.HasOne(d => d.Zone).WithMany(p => p.Potteries)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_928a8052da");
        });

        modelBuilder.Entity<PreliminaryReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("preliminary_reports_pkey");

            entity.ToTable("preliminary_reports");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Beak).HasColumnName("beak");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Bottom).HasColumnName("bottom");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Grip).HasColumnName("grip");
            entity.Property(e => e.Handle).HasColumnName("handle");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Notes)
                .HasColumnType("character varying")
                .HasColumnName("notes");
            entity.Property(e => e.ReportClass)
                .HasColumnType("character varying")
                .HasColumnName("report_class");
            entity.Property(e => e.Rim).HasColumnName("rim");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rooms_pkey");

            entity.ToTable("rooms");

            entity.HasIndex(e => e.ZoneId, "index_rooms_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EdCorbo).HasColumnName("ed_corbo");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PeriodEnd).HasColumnName("period_end");
            entity.Property(e => e.PeriodStart).HasColumnName("period_start");
            entity.Property(e => e.RoomNum).HasColumnName("room_num");
            entity.Property(e => e.SpaceType)
                .HasColumnType("character varying")
                .HasColumnName("space_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Zone).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_278c89d8ac");
        });

        modelBuilder.Entity<RoomsTrench>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rooms_trenches");

            entity.HasIndex(e => new { e.TrenchId, e.RoomId }, "index_rooms_trenches_on_trench_id_and_room_id");

            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations");

            entity.Property(e => e.Version)
                .HasColumnType("character varying")
                .HasColumnName("version");
        });

        modelBuilder.Entity<SpecialFind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("special_finds_pkey");

            entity.ToTable("special_finds");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbsoluteElevation)
                .HasColumnType("character varying")
                .HasColumnName("absolute_elevation");
            entity.Property(e => e.Chronology)
                .HasColumnType("character varying")
                .HasColumnName("chronology");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition)
                .HasColumnType("character varying")
                .HasColumnName("definition");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdObj)
                .HasColumnType("character varying")
                .HasColumnName("id_obj");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.LocationTsNumber)
                .HasColumnType("character varying")
                .HasColumnName("location_ts_number");
            entity.Property(e => e.Material)
                .HasColumnType("character varying")
                .HasColumnName("material");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
        });

        modelBuilder.Entity<SpotDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("spot_dates_pkey");

            entity.ToTable("spot_dates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Period)
                .HasColumnType("character varying")
                .HasColumnName("period");
            entity.Property(e => e.Phase)
                .HasColumnType("character varying")
                .HasColumnName("phase");
            entity.Property(e => e.TerminiusPost).HasColumnName("terminius_post");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
        });

        modelBuilder.Entity<StoneCutting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stone_cuttings_pkey");

            entity.ToTable("stone_cuttings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoneForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stone_forms_pkey");

            entity.ToTable("stone_forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoneInstallation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stone_installations_pkey");

            entity.ToTable("stone_installations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoneObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stone_objects_pkey");

            entity.ToTable("stone_objects");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_stone_objects_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_stone_objects_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_stone_objects_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_stone_objects_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_stone_objects_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_stone_objects_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_stone_objects_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_stone_objects_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_stone_objects_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_stone_objects_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_stone_objects_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_stone_objects_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_stone_objects_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement)
                .HasColumnType("character varying")
                .HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DefObj)
                .HasColumnType("character varying")
                .HasColumnName("def_obj");
            entity.Property(e => e.DescrDecor)
                .HasColumnType("character varying")
                .HasColumnName("descr_decor");
            entity.Property(e => e.DescrEp)
                .HasColumnType("character varying")
                .HasColumnName("descr_ep");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.DesignatedUse)
                .HasColumnType("character varying")
                .HasColumnName("designated_use");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightCm).HasColumnName("height_cm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance)
                .HasColumnType("character varying")
                .HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TotFrag).HasColumnName("tot_frag");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WidthCm).HasColumnName("width_cm");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_e76dfc24df");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_40ae0dfb00");

            entity.HasOne(d => d.Drawing).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_2af8e37c41");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_83ccc4fe4f");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_80fb8bfa04");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_5b77c51361");

            entity.HasOne(d => d.Photograph).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_fec075eba0");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_078f91f2c1");

            entity.HasOne(d => d.Room).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_21fb9bb88e");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_4dc342da78");

            entity.HasOne(d => d.Trench).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_c343c567e7");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_9a5c71dafa");

            entity.HasOne(d => d.Zone).WithMany(p => p.StoneObjects)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_52ff489301");
        });

        modelBuilder.Entity<StoneWorking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stone_workings_pkey");

            entity.ToTable("stone_workings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Trench>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("trenches_pkey");

            entity.ToTable("trenches");

            entity.HasIndex(e => e.ZoneId, "index_trenches_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bibliography)
                .HasColumnType("character varying")
                .HasColumnName("bibliography");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Zone).WithMany(p => p.Trenches)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_33e8340939");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(false)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasColumnType("character varying")
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasColumnType("character varying")
                .HasColumnName("lastname");
            entity.Property(e => e.PasswordDigest)
                .HasColumnType("character varying")
                .HasColumnName("password_digest");
            entity.Property(e => e.RecoveryPasswordDigest)
                .HasColumnType("character varying")
                .HasColumnName("recovery_password_digest");
            entity.Property(e => e.Role)
                .HasColumnType("character varying")
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WoodenObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wooden_objects_pkey");

            entity.ToTable("wooden_objects");

            entity.HasIndex(e => e.ArchivalDrawingId, "index_wooden_objects_on_archival_drawing_id");

            entity.HasIndex(e => e.ArchivalSourceId, "index_wooden_objects_on_archival_source_id");

            entity.HasIndex(e => e.DrawingId, "index_wooden_objects_on_drawing_id");

            entity.HasIndex(e => e.EpigraphicElementId, "index_wooden_objects_on_epigraphic_element_id");

            entity.HasIndex(e => e.GeneralBibliographyId, "index_wooden_objects_on_general_bibliography_id");

            entity.HasIndex(e => e.IconographicSourceId, "index_wooden_objects_on_iconographic_source_id");

            entity.HasIndex(e => e.PhotographId, "index_wooden_objects_on_photograph_id");

            entity.HasIndex(e => e.PhotographicSourceId, "index_wooden_objects_on_photographic_source_id");

            entity.HasIndex(e => e.RoomId, "index_wooden_objects_on_room_id");

            entity.HasIndex(e => e.SpecialFindId, "index_wooden_objects_on_special_find_id");

            entity.HasIndex(e => e.TrenchId, "index_wooden_objects_on_trench_id");

            entity.HasIndex(e => e.WrittenSourcesObjectId, "index_wooden_objects_on_written_sources_object_id");

            entity.HasIndex(e => e.ZoneId, "index_wooden_objects_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArchivalDrawingId).HasColumnName("archival_drawing_id");
            entity.Property(e => e.ArchivalSourceId).HasColumnName("archival_source_id");
            entity.Property(e => e.ChronMax).HasColumnName("chron_max");
            entity.Property(e => e.ChronMin).HasColumnName("chron_min");
            entity.Property(e => e.ConsPlace)
                .HasColumnType("character varying")
                .HasColumnName("cons_place");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DatingElement).HasColumnName("dating_element");
            entity.Property(e => e.Decorations)
                .HasColumnType("character varying")
                .HasColumnName("decorations");
            entity.Property(e => e.DefObj)
                .HasColumnType("character varying")
                .HasColumnName("def_obj");
            entity.Property(e => e.DescrDecor)
                .HasColumnType("character varying")
                .HasColumnName("descr_decor");
            entity.Property(e => e.DescrEp).HasColumnName("descr_ep");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DesignatedUse).HasColumnName("designated_use");
            entity.Property(e => e.DrawingId).HasColumnName("drawing_id");
            entity.Property(e => e.EpigraphicElementId).HasColumnName("epigraphic_element_id");
            entity.Property(e => e.Epigraphics).HasColumnName("epigraphics");
            entity.Property(e => e.GeneralBibliographyId).HasColumnName("general_bibliography_id");
            entity.Property(e => e.HeightCm).HasColumnName("height_cm");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.Intact).HasColumnName("intact");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PhotographId).HasColumnName("photograph_id");
            entity.Property(e => e.PhotographicSourceId).HasColumnName("photographic_source_id");
            entity.Property(e => e.Provenance).HasColumnName("provenance");
            entity.Property(e => e.Reconstr).HasColumnName("reconstr");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.SheetAuthor)
                .HasColumnType("character varying")
                .HasColumnName("sheet_author");
            entity.Property(e => e.SpecialFindId).HasColumnName("special_find_id");
            entity.Property(e => e.ThicknessCm).HasColumnName("thickness_cm");
            entity.Property(e => e.TotFragm).HasColumnName("tot_fragm");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsNum)
                .HasColumnType("character varying")
                .HasColumnName("us_num");
            entity.Property(e => e.WidthCm).HasColumnName("width_cm");
            entity.Property(e => e.WrittenSourcesObjectId).HasColumnName("written_sources_object_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.ArchivalDrawing).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.ArchivalDrawingId)
                .HasConstraintName("fk_rails_e7e08607b5");

            entity.HasOne(d => d.ArchivalSource).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.ArchivalSourceId)
                .HasConstraintName("fk_rails_fab00fef4a");

            entity.HasOne(d => d.Drawing).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.DrawingId)
                .HasConstraintName("fk_rails_9722381381");

            entity.HasOne(d => d.EpigraphicElement).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.EpigraphicElementId)
                .HasConstraintName("fk_rails_b050acb35f");

            entity.HasOne(d => d.GeneralBibliography).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.GeneralBibliographyId)
                .HasConstraintName("fk_rails_0544a7dbc1");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_5ce7f89ca0");

            entity.HasOne(d => d.Photograph).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.PhotographId)
                .HasConstraintName("fk_rails_7d790448a5");

            entity.HasOne(d => d.PhotographicSource).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.PhotographicSourceId)
                .HasConstraintName("fk_rails_a9450548aa");

            entity.HasOne(d => d.Room).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_758abcf434");

            entity.HasOne(d => d.SpecialFind).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.SpecialFindId)
                .HasConstraintName("fk_rails_549ceb77f3");

            entity.HasOne(d => d.Trench).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_4287b3f774");

            entity.HasOne(d => d.WrittenSourcesObject).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.WrittenSourcesObjectId)
                .HasConstraintName("fk_rails_5fe1f0c2e5");

            entity.HasOne(d => d.Zone).WithMany(p => p.WoodenObjects)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_07996c9ab8");
        });

        modelBuilder.Entity<WrittenSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("written_sources_pkey");

            entity.ToTable("written_sources");

            entity.HasIndex(e => e.BiblioCriticalEditionId, "index_written_sources_on_biblio_critical_edition_id");

            entity.HasIndex(e => e.BiblioOriginalTextId, "index_written_sources_on_biblio_original_text_id");

            entity.HasIndex(e => e.BiblioTransTextId, "index_written_sources_on_biblio_trans_text_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annex)
                .HasColumnType("character varying")
                .HasColumnName("annex");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.BiblioCriticalEditionId).HasColumnName("biblio_critical_edition_id");
            entity.Property(e => e.BiblioOriginalTextId).HasColumnName("biblio_original_text_id");
            entity.Property(e => e.BiblioTransTextId).HasColumnName("biblio_trans_text_id");
            entity.Property(e => e.ChronMax)
                .HasColumnType("character varying")
                .HasColumnName("chron_max");
            entity.Property(e => e.ChronMin)
                .HasColumnType("character varying")
                .HasColumnName("chron_min");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Manuscript)
                .HasColumnType("character varying")
                .HasColumnName("manuscript");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OrigText).HasColumnName("orig_text");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.SourceType)
                .HasColumnType("character varying")
                .HasColumnName("source_type");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
            entity.Property(e => e.TransText).HasColumnName("trans_text");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<WrittenSourcesExtract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("written_sources_extracts_pkey");

            entity.ToTable("written_sources_extracts");

            entity.HasIndex(e => e.IconographicSourceId, "index_written_sources_extracts_on_iconographic_source_id");

            entity.HasIndex(e => e.LocusListId, "index_written_sources_extracts_on_locus_list_id");

            entity.HasIndex(e => e.RoomId, "index_written_sources_extracts_on_room_id");

            entity.HasIndex(e => e.TrenchId, "index_written_sources_extracts_on_trench_id");

            entity.HasIndex(e => e.WrittenSourceId, "index_written_sources_extracts_on_written_source_id");

            entity.HasIndex(e => e.ZoneId, "index_written_sources_extracts_on_zone_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IconographicSourceId).HasColumnName("iconographic_source_id");
            entity.Property(e => e.LocusListId).HasColumnName("locus_list_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OrigText).HasColumnName("orig_text");
            entity.Property(e => e.Ref)
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.TransText).HasColumnName("trans_text");
            entity.Property(e => e.TrenchId).HasColumnName("trench_id");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WrittenSourceId).HasColumnName("written_source_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.IconographicSource).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.IconographicSourceId)
                .HasConstraintName("fk_rails_bca9ccc3b8");

            entity.HasOne(d => d.LocusList).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.LocusListId)
                .HasConstraintName("fk_rails_bb59e6f447");

            entity.HasOne(d => d.Room).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_rails_dbe380559b");

            entity.HasOne(d => d.Trench).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.TrenchId)
                .HasConstraintName("fk_rails_6cbfd06bc6");

            entity.HasOne(d => d.WrittenSource).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.WrittenSourceId)
                .HasConstraintName("fk_rails_f3dd842dc4");

            entity.HasOne(d => d.Zone).WithMany(p => p.WrittenSourcesExtracts)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_rails_264a8a9040");
        });

        modelBuilder.Entity<WrittenSourcesObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("written_sources_objects_pkey");

            entity.ToTable("written_sources_objects");

            entity.HasIndex(e => e.WrittenSourceId, "index_written_sources_objects_on_written_source_id");

            entity.HasIndex(e => e.WrittenSourcesExtractId, "index_written_sources_objects_on_written_sources_extract_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OrigTerm)
                .HasColumnType("character varying")
                .HasColumnName("orig_term");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.TransTerm)
                .HasColumnType("character varying")
                .HasColumnName("trans_term");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WrittenSourceId).HasColumnName("written_source_id");
            entity.Property(e => e.WrittenSourcesExtractId).HasColumnName("written_sources_extract_id");

            entity.HasOne(d => d.WrittenSource).WithMany(p => p.WrittenSourcesObjects)
                .HasForeignKey(d => d.WrittenSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_71da28774f");

            entity.HasOne(d => d.WrittenSourcesExtract).WithMany(p => p.WrittenSourcesObjects)
                .HasForeignKey(d => d.WrittenSourcesExtractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_915e63942c");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zones_pkey");

            entity.ToTable("zones");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EdCorbo).HasColumnName("ed_corbo");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PeriodEnd).HasColumnName("period_end");
            entity.Property(e => e.PeriodStart).HasColumnName("period_start");
            entity.Property(e => e.SpaceType)
                .HasColumnType("character varying")
                .HasColumnName("space_type");
            entity.Property(e => e.Tsdbcode)
                .HasColumnType("character varying")
                .HasColumnName("tsdbcode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ZoneNum)
                .HasColumnType("character varying")
                .HasColumnName("zone_num");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
