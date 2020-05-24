using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WSGOPLAY.Models
{
    public partial class goplayco_redContext : DbContext
    {


        public goplayco_redContext(DbContextOptions<goplayco_redContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankReceipts> BankReceipts { get; set; }
        public virtual DbSet<EstadoCancha> EstadoCancha { get; set; }
        public virtual DbSet<Habilidades> Habilidades { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Partidos> Partidos { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Retos> Retos { get; set; }
        public virtual DbSet<Sinreserva> Sinreserva { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<WoActivities> WoActivities { get; set; }
        public virtual DbSet<WoAdmininvitations> WoAdmininvitations { get; set; }
        public virtual DbSet<WoAds> WoAds { get; set; }
        public virtual DbSet<WoAffiliatesRequests> WoAffiliatesRequests { get; set; }
        public virtual DbSet<WoAgoravideocall> WoAgoravideocall { get; set; }
        public virtual DbSet<WoAlbumsMedia> WoAlbumsMedia { get; set; }
        public virtual DbSet<WoAnnouncement> WoAnnouncement { get; set; }
        public virtual DbSet<WoAnnouncementViews> WoAnnouncementViews { get; set; }
        public virtual DbSet<WoApps> WoApps { get; set; }
        public virtual DbSet<WoAppsHash> WoAppsHash { get; set; }
        public virtual DbSet<WoAppsPermission> WoAppsPermission { get; set; }
        public virtual DbSet<WoAppssessions> WoAppssessions { get; set; }
        public virtual DbSet<WoAudiocalls> WoAudiocalls { get; set; }
        public virtual DbSet<WoBannedIp> WoBannedIp { get; set; }
        public virtual DbSet<WoBlocks> WoBlocks { get; set; }
        public virtual DbSet<WoBlog> WoBlog { get; set; }
        public virtual DbSet<WoBlogcommentreplies> WoBlogcommentreplies { get; set; }
        public virtual DbSet<WoBlogcomments> WoBlogcomments { get; set; }
        public virtual DbSet<WoBlogmoviedislikes> WoBlogmoviedislikes { get; set; }
        public virtual DbSet<WoBlogmovielikes> WoBlogmovielikes { get; set; }
        public virtual DbSet<WoBlogsCategories> WoBlogsCategories { get; set; }
        public virtual DbSet<WoCodes> WoCodes { get; set; }
        public virtual DbSet<WoCommentReplies> WoCommentReplies { get; set; }
        public virtual DbSet<WoCommentRepliesLikes> WoCommentRepliesLikes { get; set; }
        public virtual DbSet<WoCommentRepliesWonders> WoCommentRepliesWonders { get; set; }
        public virtual DbSet<WoCommentlikes> WoCommentlikes { get; set; }
        public virtual DbSet<WoComments> WoComments { get; set; }
        public virtual DbSet<WoCommentwonders> WoCommentwonders { get; set; }
        public virtual DbSet<WoConfig> WoConfig { get; set; }
        public virtual DbSet<WoCustompages> WoCustompages { get; set; }
        public virtual DbSet<WoEgoing> WoEgoing { get; set; }
        public virtual DbSet<WoEinterested> WoEinterested { get; set; }
        public virtual DbSet<WoEinvited> WoEinvited { get; set; }
        public virtual DbSet<WoEmails> WoEmails { get; set; }
        public virtual DbSet<WoEvents> WoEvents { get; set; }
        public virtual DbSet<WoFamily> WoFamily { get; set; }
        public virtual DbSet<WoFollowers> WoFollowers { get; set; }
        public virtual DbSet<WoForumSections> WoForumSections { get; set; }
        public virtual DbSet<WoForumThreads> WoForumThreads { get; set; }
        public virtual DbSet<WoForums> WoForums { get; set; }
        public virtual DbSet<WoForumthreadreplies> WoForumthreadreplies { get; set; }
        public virtual DbSet<WoGames> WoGames { get; set; }
        public virtual DbSet<WoGamesPlayers> WoGamesPlayers { get; set; }
        public virtual DbSet<WoGifts> WoGifts { get; set; }
        public virtual DbSet<WoGroupMembers> WoGroupMembers { get; set; }
        public virtual DbSet<WoGroupadmins> WoGroupadmins { get; set; }
        public virtual DbSet<WoGroupchat> WoGroupchat { get; set; }
        public virtual DbSet<WoGroupchatusers> WoGroupchatusers { get; set; }
        public virtual DbSet<WoGroups> WoGroups { get; set; }
        public virtual DbSet<WoGroupsCategories> WoGroupsCategories { get; set; }
        public virtual DbSet<WoHashtags> WoHashtags { get; set; }
        public virtual DbSet<WoHiddenposts> WoHiddenposts { get; set; }
        public virtual DbSet<WoLangs> WoLangs { get; set; }
        public virtual DbSet<WoLikes> WoLikes { get; set; }
        public virtual DbSet<WoManagePro> WoManagePro { get; set; }
        public virtual DbSet<WoMessages> WoMessages { get; set; }
        public virtual DbSet<WoMoviecommentreplies> WoMoviecommentreplies { get; set; }
        public virtual DbSet<WoMoviecomments> WoMoviecomments { get; set; }
        public virtual DbSet<WoMovies> WoMovies { get; set; }
        public virtual DbSet<WoNotifications> WoNotifications { get; set; }
        public virtual DbSet<WoPageadmins> WoPageadmins { get; set; }
        public virtual DbSet<WoPagerating> WoPagerating { get; set; }
        public virtual DbSet<WoPages> WoPages { get; set; }
        public virtual DbSet<WoPagesCategories> WoPagesCategories { get; set; }
        public virtual DbSet<WoPagesInvites> WoPagesInvites { get; set; }
        public virtual DbSet<WoPagesLikes> WoPagesLikes { get; set; }
        public virtual DbSet<WoPaymentTransactions> WoPaymentTransactions { get; set; }
        public virtual DbSet<WoPayments> WoPayments { get; set; }
        public virtual DbSet<WoPinnedposts> WoPinnedposts { get; set; }
        public virtual DbSet<WoPokes> WoPokes { get; set; }
        public virtual DbSet<WoPolls> WoPolls { get; set; }
        public virtual DbSet<WoPosts> WoPosts { get; set; }
        public virtual DbSet<WoProducts> WoProducts { get; set; }
        public virtual DbSet<WoProductsCategories> WoProductsCategories { get; set; }
        public virtual DbSet<WoProductsMedia> WoProductsMedia { get; set; }
        public virtual DbSet<WoProfilefields> WoProfilefields { get; set; }
        public virtual DbSet<WoReactions> WoReactions { get; set; }
        public virtual DbSet<WoRecentsearches> WoRecentsearches { get; set; }
        public virtual DbSet<WoRelationship> WoRelationship { get; set; }
        public virtual DbSet<WoReports> WoReports { get; set; }
        public virtual DbSet<WoSavedposts> WoSavedposts { get; set; }
        public virtual DbSet<WoStickers> WoStickers { get; set; }
        public virtual DbSet<WoStorySeen> WoStorySeen { get; set; }
        public virtual DbSet<WoTerms> WoTerms { get; set; }
        public virtual DbSet<WoTokens> WoTokens { get; set; }
        public virtual DbSet<WoUserGifts> WoUserGifts { get; set; }
        public virtual DbSet<WoUserads> WoUserads { get; set; }
        public virtual DbSet<WoUseradsData> WoUseradsData { get; set; }
        public virtual DbSet<WoUserfields> WoUserfields { get; set; }
        public virtual DbSet<WoUsers> WoUsers { get; set; }
        public virtual DbSet<WoUserschat> WoUserschat { get; set; }
        public virtual DbSet<WoUserstory> WoUserstory { get; set; }
        public virtual DbSet<WoUserstorymedia> WoUserstorymedia { get; set; }
        public virtual DbSet<WoVerificationRequests> WoVerificationRequests { get; set; }
        public virtual DbSet<WoVideocalles> WoVideocalles { get; set; }
        public virtual DbSet<WoVotes> WoVotes { get; set; }
        public virtual DbSet<WoWonders> WoWonders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankReceipts>(entity =>
            {
                entity.ToTable("bank_receipts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ApprovedAt)
                    .HasColumnName("approved_at")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnName("mode")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReceiptFile)
                    .IsRequired()
                    .HasColumnName("receipt_file")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<EstadoCancha>(entity =>
            {
                entity.ToTable("estado_cancha");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Habilidades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("habilidades");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Creado)
                    .IsRequired()
                    .HasColumnName("creado")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equipo)
                    .IsRequired()
                    .HasColumnName("equipo")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Habilidad)
                    .IsRequired()
                    .HasColumnName("habilidad")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posicion)
                    .IsRequired()
                    .HasColumnName("posicion")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.ToTable("horario");

                entity.HasIndex(e => e.IdCancha)
                    .HasName("FK_Horacho_pagina");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCancha)
                    .HasColumnName("id_cancha")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProNombre)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProPrecio)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCanchaNavigation)
                    .WithMany(p => p.Horario)
                    .HasForeignKey(d => d.IdCancha)
                    .HasConstraintName("FK_Horacho_pagina");
            });

            modelBuilder.Entity<Partidos>(entity =>
            {
                entity.ToTable("partidos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Equipoa)
                    .IsRequired()
                    .HasColumnName("equipoa")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equipob)
                    .IsRequired()
                    .HasColumnName("equipob")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto1)
                    .IsRequired()
                    .HasColumnName("foto1")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto2)
                    .IsRequired()
                    .HasColumnName("foto2")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto3)
                    .IsRequired()
                    .HasColumnName("foto3")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ganador)
                    .IsRequired()
                    .HasColumnName("ganador")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jugadora)
                    .IsRequired()
                    .HasColumnName("jugadora")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jugadorb)
                    .IsRequired()
                    .HasColumnName("jugadorb")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Resultadoa)
                    .IsRequired()
                    .HasColumnName("resultadoa")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Resultadob)
                    .IsRequired()
                    .HasColumnName("resultadob")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PRIMARY");

                entity.ToTable("reserva");

                entity.HasIndex(e => e.Idestado)
                    .HasName("FK_reserva_estado");

                entity.HasIndex(e => e.Idhorario)
                    .HasName("FK_reserva_horario");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("id_reserva")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("fecha")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HoraFinal)
                    .IsRequired()
                    .HasColumnName("hora_final")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasColumnName("hora_inicio")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idestado)
                    .HasColumnName("idestado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idhorario)
                    .HasColumnName("idhorario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reserva1)
                    .IsRequired()
                    .HasColumnName("reserva")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reto)
                    .IsRequired()
                    .HasColumnName("reto")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdestadoNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.Idestado)
                    .HasConstraintName("FK_reserva_estado");

                entity.HasOne(d => d.IdhorarioNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.Idhorario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_reserva_horario");
            });

            modelBuilder.Entity<Retos>(entity =>
            {
                entity.ToTable("retos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equiporetar)
                    .IsRequired()
                    .HasColumnName("equiporetar")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Equipouser)
                    .IsRequired()
                    .HasColumnName("equipouser")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaReto)
                    .IsRequired()
                    .HasColumnName("fecha_reto")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sinreserva>(entity =>
            {
                entity.HasKey(e => e.Idsin)
                    .HasName("PRIMARY");

                entity.ToTable("sinreserva");

                entity.HasIndex(e => e.Sinidhorario)
                    .HasName("FK_SINH");

                entity.Property(e => e.Idsin)
                    .HasColumnName("idsin")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sinfecha)
                    .HasColumnName("sinfecha")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Sinhora)
                    .HasColumnName("sinhora")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Sinidhorario)
                    .HasColumnName("sinidhorario")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SinidhorarioNavigation)
                    .WithMany(p => p.Sinreserva)
                    .HasForeignKey(d => d.Sinidhorario)
                    .HasConstraintName("FK_SINH");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("team");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Creado)
                    .IsRequired()
                    .HasColumnName("creado")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Longi)
                    .IsRequired()
                    .HasColumnName("longi")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoActivities>(entity =>
            {
                entity.ToTable("wo_activities");

                entity.HasIndex(e => e.ActivityType)
                    .HasName("activity_type");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.ReplyId)
                    .HasName("reply_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.PostId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("order1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasColumnName("activity_type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FollowId)
                    .HasColumnName("follow_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(255)");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("reply_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(255)");
            });

            modelBuilder.Entity<WoAdmininvitations>(entity =>
            {
                entity.ToTable("wo_admininvitations");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posted)
                    .IsRequired()
                    .HasColumnName("posted")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoAds>(entity =>
            {
                entity.ToTable("wo_ads");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoAffiliatesRequests>(entity =>
            {
                entity.ToTable("wo_affiliates_requests");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FullAmount)
                    .IsRequired()
                    .HasColumnName("full_amount")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoAgoravideocall>(entity =>
            {
                entity.ToTable("wo_agoravideocall");

                entity.HasIndex(e => e.FromId)
                    .HasName("from_id");

                entity.HasIndex(e => e.RoomName)
                    .HasName("room_name");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => e.ToId)
                    .HasName("to_id");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromId)
                    .HasColumnName("from_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasColumnName("room_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToId)
                    .HasColumnName("to_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'video'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<WoAlbumsMedia>(entity =>
            {
                entity.ToTable("wo_albums_media");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => new { e.PostId, e.Id })
                    .HasName("order1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoAnnouncement>(entity =>
            {
                entity.ToTable("wo_announcement");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(32)");
            });

            modelBuilder.Entity<WoAnnouncementViews>(entity =>
            {
                entity.ToTable("wo_announcement_views");

                entity.HasIndex(e => e.AnnouncementId)
                    .HasName("announcement_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("announcement_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoApps>(entity =>
            {
                entity.ToTable("wo_apps");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppAvatar)
                    .IsRequired()
                    .HasColumnName("app_avatar")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'upload/photos/app-default-icon.png'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppCallbackUrl)
                    .IsRequired()
                    .HasColumnName("app_callback_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppDescription)
                    .IsRequired()
                    .HasColumnName("app_description")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("app_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("app_name")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppSecret)
                    .IsRequired()
                    .HasColumnName("app_secret")
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AppUserId)
                    .HasColumnName("app_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppWebsiteUrl)
                    .IsRequired()
                    .HasColumnName("app_website_url")
                    .HasColumnType("varchar(55)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<WoAppsHash>(entity =>
            {
                entity.ToTable("wo_apps_hash");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.HashId)
                    .HasName("hash_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HashId)
                    .IsRequired()
                    .HasColumnName("hash_id")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoAppsPermission>(entity =>
            {
                entity.ToTable("wo_apps_permission");

                entity.HasIndex(e => new { e.UserId, e.AppId })
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoAppssessions>(entity =>
            {
                entity.ToTable("wo_appssessions");

                entity.HasIndex(e => e.Platform)
                    .HasName("platform");

                entity.HasIndex(e => e.SessionId)
                    .HasName("session_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnName("platform")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PlatformDetails)
                    .HasColumnName("platform_details")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoAudiocalls>(entity =>
            {
                entity.ToTable("wo_audiocalls");

                entity.HasIndex(e => e.CallId)
                    .HasName("call_id");

                entity.HasIndex(e => e.Called)
                    .HasName("called");

                entity.HasIndex(e => e.Declined)
                    .HasName("declined");

                entity.HasIndex(e => e.FromId)
                    .HasName("from_id");

                entity.HasIndex(e => e.ToId)
                    .HasName("to_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AccessToken2)
                    .HasColumnName("access_token_2")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallId)
                    .IsRequired()
                    .HasColumnName("call_id")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CallId2)
                    .IsRequired()
                    .HasColumnName("call_id_2")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Called)
                    .HasColumnName("called")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Declined)
                    .HasColumnName("declined")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromId)
                    .HasColumnName("from_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasColumnName("room_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToId)
                    .HasColumnName("to_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBannedIp>(entity =>
            {
                entity.ToTable("wo_banned_ip");

                entity.HasIndex(e => e.IpAddress)
                    .HasName("ip_address");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlocks>(entity =>
            {
                entity.ToTable("wo_blocks");

                entity.HasIndex(e => e.Blocked)
                    .HasName("blocked");

                entity.HasIndex(e => e.Blocker)
                    .HasName("blocker");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blocked)
                    .HasColumnName("blocked")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blocker)
                    .HasColumnName("blocker")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlog>(entity =>
            {
                entity.ToTable("wo_blog");

                entity.HasIndex(e => e.Category)
                    .HasName("category");

                entity.HasIndex(e => e.Title)
                    .HasName("title");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Shared)
                    .HasColumnName("shared")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'upload/photos/d-blog.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.View)
                    .HasColumnName("view")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WoBlogcommentreplies>(entity =>
            {
                entity.ToTable("wo_blogcommentreplies");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.CommId)
                    .HasName("comm_id");

                entity.HasIndex(e => new { e.BlogId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.CommId, e.Id })
                    .HasName("order1");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("order3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommId)
                    .HasColumnName("comm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Likes)
                    .HasColumnName("likes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlogcomments>(entity =>
            {
                entity.ToTable("wo_blogcomments");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Likes)
                    .HasColumnName("likes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlogmoviedislikes>(entity =>
            {
                entity.ToTable("wo_blogmoviedislikes");

                entity.HasIndex(e => e.BlogCommId)
                    .HasName("blog_comm_id");

                entity.HasIndex(e => e.BlogCommreplyId)
                    .HasName("blog_commreply_id");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.MovieCommId)
                    .HasName("movie_comm_id");

                entity.HasIndex(e => e.MovieCommreplyId)
                    .HasName("movie_commreply_id");

                entity.HasIndex(e => e.MovieId)
                    .HasName("movie_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlogCommId)
                    .HasColumnName("blog_comm_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.BlogCommreplyId)
                    .HasColumnName("blog_commreply_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(50)");

                entity.Property(e => e.MovieCommId)
                    .HasColumnName("movie_comm_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.MovieCommreplyId)
                    .HasColumnName("movie_commreply_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .HasColumnType("int(50)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlogmovielikes>(entity =>
            {
                entity.ToTable("wo_blogmovielikes");

                entity.HasIndex(e => e.BlogCommId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.BlogCommreplyId)
                    .HasName("blog_commreply_id");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id_2");

                entity.HasIndex(e => e.MovieCommId)
                    .HasName("movie_id");

                entity.HasIndex(e => e.MovieCommreplyId)
                    .HasName("movie_commreply_id");

                entity.HasIndex(e => e.MovieId)
                    .HasName("movie_id_2");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlogCommId)
                    .HasColumnName("blog_comm_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.BlogCommreplyId)
                    .HasColumnName("blog_commreply_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(50)");

                entity.Property(e => e.MovieCommId)
                    .HasColumnName("movie_comm_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.MovieCommreplyId)
                    .HasColumnName("movie_commreply_id")
                    .HasColumnType("int(20)");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .HasColumnType("int(50)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoBlogsCategories>(entity =>
            {
                entity.ToTable("wo_blogs_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LangKey)
                    .IsRequired()
                    .HasColumnName("lang_key")
                    .HasColumnType("varchar(160)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoCodes>(entity =>
            {
                entity.ToTable("wo_codes");

                entity.HasIndex(e => e.AppId)
                    .HasName("app_id");

                entity.HasIndex(e => e.Code)
                    .HasName("code");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("app_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoCommentReplies>(entity =>
            {
                entity.ToTable("wo_comment_replies");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => new { e.UserId, e.PageId })
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoCommentRepliesLikes>(entity =>
            {
                entity.ToTable("wo_comment_replies_likes");

                entity.HasIndex(e => e.ReplyId)
                    .HasName("reply_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("reply_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoCommentRepliesWonders>(entity =>
            {
                entity.ToTable("wo_comment_replies_wonders");

                entity.HasIndex(e => new { e.ReplyId, e.UserId })
                    .HasName("reply_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("reply_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoCommentlikes>(entity =>
            {
                entity.ToTable("wo_commentlikes");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoComments>(entity =>
            {
                entity.ToTable("wo_comments");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.PageId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.PostId, e.Id })
                    .HasName("order5");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("order4");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CFile)
                    .IsRequired()
                    .HasColumnName("c_file")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Record)
                    .IsRequired()
                    .HasColumnName("record")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoCommentwonders>(entity =>
            {
                entity.ToTable("wo_commentwonders");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoConfig>(entity =>
            {
                entity.ToTable("wo_config");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(20000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoCustompages>(entity =>
            {
                entity.ToTable("wo_custompages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageContent)
                    .HasColumnName("page_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnName("page_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnName("page_title")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PageType)
                    .HasColumnName("page_type")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoEgoing>(entity =>
            {
                entity.ToTable("wo_egoing");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoEinterested>(entity =>
            {
                entity.ToTable("wo_einterested");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoEinvited>(entity =>
            {
                entity.ToTable("wo_einvited");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_id");

                entity.HasIndex(e => e.InvitedId)
                    .HasName("inviter_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvitedId)
                    .HasColumnName("invited_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InviterId)
                    .HasColumnName("inviter_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoEmails>(entity =>
            {
                entity.ToTable("wo_emails");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .HasColumnName("email_to")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoEvents>(entity =>
            {
                entity.ToTable("wo_events");

                entity.HasIndex(e => e.EndDate)
                    .HasName("end_date");

                entity.HasIndex(e => e.EndTime)
                    .HasName("end_time");

                entity.HasIndex(e => e.Id)
                    .HasName("order2");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.PosterId)
                    .HasName("poster_id");

                entity.HasIndex(e => e.StartDate)
                    .HasName("start_date");

                entity.HasIndex(e => e.StartTime)
                    .HasName("start_time");

                entity.HasIndex(e => new { e.PosterId, e.Id })
                    .HasName("order1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'upload/photos/d-cover.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("time");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PosterId)
                    .HasColumnName("poster_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("time");
            });

            modelBuilder.Entity<WoFamily>(entity =>
            {
                entity.ToTable("wo_family");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.MemberId)
                    .HasName("member_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Member)
                    .HasColumnName("member")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Requesting)
                    .HasColumnName("requesting")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoFollowers>(entity =>
            {
                entity.ToTable("wo_followers");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.FollowerId)
                    .HasName("follower_id");

                entity.HasIndex(e => e.FollowingId)
                    .HasName("following_id");

                entity.HasIndex(e => new { e.FollowerId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.FollowingId, e.Id })
                    .HasName("order1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FollowerId)
                    .HasColumnName("follower_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FollowingId)
                    .HasColumnName("following_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsTyping)
                    .HasColumnName("is_typing")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoForumSections>(entity =>
            {
                entity.ToTable("wo_forum_sections");

                entity.HasIndex(e => e.Description)
                    .HasName("description");

                entity.HasIndex(e => e.SectionName)
                    .HasName("section_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasColumnName("section_name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoForumThreads>(entity =>
            {
                entity.ToTable("wo_forum_threads");

                entity.HasIndex(e => e.Forum)
                    .HasName("forum");

                entity.HasIndex(e => e.Headline)
                    .HasName("headline");

                entity.HasIndex(e => e.Posted)
                    .HasName("posted");

                entity.HasIndex(e => e.User)
                    .HasName("user");

                entity.HasIndex(e => e.Views)
                    .HasName("views");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Forum)
                    .HasColumnName("forum")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Headline)
                    .IsRequired()
                    .HasColumnName("headline")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastPost)
                    .HasColumnName("last_post")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Post)
                    .IsRequired()
                    .HasColumnName("post")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posted)
                    .IsRequired()
                    .HasColumnName("posted")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoForums>(entity =>
            {
                entity.ToTable("wo_forums");

                entity.HasIndex(e => e.Description)
                    .HasName("description");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Posts)
                    .HasName("posts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastPost)
                    .HasColumnName("last_post")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posts)
                    .HasColumnName("posts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sections)
                    .HasColumnName("sections")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoForumthreadreplies>(entity =>
            {
                entity.ToTable("wo_forumthreadreplies");

                entity.HasIndex(e => e.ForumId)
                    .HasName("forum_id");

                entity.HasIndex(e => e.PostQuoted)
                    .HasName("post_quoted");

                entity.HasIndex(e => e.PostSubject)
                    .HasName("post_subject");

                entity.HasIndex(e => e.PostedTime)
                    .HasName("posted_time");

                entity.HasIndex(e => e.PosterId)
                    .HasName("poster_id");

                entity.HasIndex(e => e.ThreadId)
                    .HasName("thread_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forum_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostQuoted)
                    .HasColumnName("post_quoted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostSubject)
                    .IsRequired()
                    .HasColumnName("post_subject")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostText)
                    .IsRequired()
                    .HasColumnName("post_text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostedTime)
                    .HasColumnName("posted_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosterId)
                    .HasColumnName("poster_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThreadId)
                    .HasColumnName("thread_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGames>(entity =>
            {
                entity.ToTable("wo_games");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GameAvatar)
                    .IsRequired()
                    .HasColumnName("game_avatar")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GameLink)
                    .IsRequired()
                    .HasColumnName("game_link")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasColumnName("game_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGamesPlayers>(entity =>
            {
                entity.ToTable("wo_games_players");

                entity.HasIndex(e => new { e.UserId, e.GameId, e.Active })
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GameId)
                    .HasColumnName("game_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastPlay)
                    .HasColumnName("last_play")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGifts>(entity =>
            {
                entity.ToTable("wo_gifts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.MediaFile)
                    .IsRequired()
                    .HasColumnName("media_file")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroupMembers>(entity =>
            {
                entity.ToTable("wo_group_members");

                entity.HasIndex(e => new { e.UserId, e.GroupId })
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroupadmins>(entity =>
            {
                entity.ToTable("wo_groupadmins");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroupchat>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("wo_groupchat");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("'upload/photos/d-group.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroupchatusers>(entity =>
            {
                entity.ToTable("wo_groupchatusers");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastSeen)
                    .IsRequired()
                    .HasColumnName("last_seen")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroups>(entity =>
            {
                entity.ToTable("wo_groups");

                entity.HasIndex(e => e.Privacy)
                    .HasName("privacy");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.About)
                    .IsRequired()
                    .HasColumnName("about")
                    .HasColumnType("varchar(550)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("'upload/photos/d-group.jpg '")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("'upload/photos/d-cover.jpg  '")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupTitle)
                    .IsRequired()
                    .HasColumnName("group_title")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinPrivacy)
                    .IsRequired()
                    .HasColumnName("join_privacy")
                    .HasColumnType("enum('1','2')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Privacy)
                    .IsRequired()
                    .HasColumnName("privacy")
                    .HasColumnType("enum('1','2')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Registered)
                    .IsRequired()
                    .HasColumnName("registered")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0/0000'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoGroupsCategories>(entity =>
            {
                entity.ToTable("wo_groups_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LangKey)
                    .IsRequired()
                    .HasColumnName("lang_key")
                    .HasColumnType("varchar(160)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoHashtags>(entity =>
            {
                entity.ToTable("wo_hashtags");

                entity.HasIndex(e => e.Expire)
                    .HasName("expire");

                entity.HasIndex(e => e.LastTrendTime)
                    .HasName("last_trend_time");

                entity.HasIndex(e => e.Tag)
                    .HasName("tag");

                entity.HasIndex(e => e.TrendUseNum)
                    .HasName("trend_use_num");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expire)
                    .HasColumnName("expire")
                    .HasColumnType("date");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("hash")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastTrendTime)
                    .HasColumnName("last_trend_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrendUseNum)
                    .HasColumnName("trend_use_num")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoHiddenposts>(entity =>
            {
                entity.ToTable("wo_hiddenposts");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoLangs>(entity =>
            {
                entity.ToTable("wo_langs");

                entity.HasIndex(e => e.LangKey)
                    .HasName("lang_key");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.English)
                    .HasColumnName("english")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LangKey)
                    .HasColumnName("lang_key")
                    .HasColumnType("varchar(160)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Spanish)
                    .HasColumnName("spanish")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoLikes>(entity =>
            {
                entity.ToTable("wo_likes");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoManagePro>(entity =>
            {
                entity.ToTable("wo_manage_pro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeaturedMember)
                    .HasColumnName("featured_member")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastSeen)
                    .HasColumnName("last_seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagesPromotion)
                    .HasColumnName("pages_promotion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostsPromotion)
                    .HasColumnName("posts_promotion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProfileVisitors)
                    .HasColumnName("profile_visitors")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBadge)
                    .HasColumnName("verified_badge")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoMessages>(entity =>
            {
                entity.ToTable("wo_messages");

                entity.HasIndex(e => e.DeletedOne)
                    .HasName("deleted_one");

                entity.HasIndex(e => e.DeletedTwo)
                    .HasName("deleted_two");

                entity.HasIndex(e => e.FromId)
                    .HasName("from_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.Seen)
                    .HasName("seen");

                entity.HasIndex(e => e.SentPush)
                    .HasName("sent_push");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => e.ToId)
                    .HasName("to_id");

                entity.HasIndex(e => new { e.FromId, e.Id })
                    .HasName("order4");

                entity.HasIndex(e => new { e.GroupId, e.Id })
                    .HasName("order5");

                entity.HasIndex(e => new { e.Seen, e.Id })
                    .HasName("order7");

                entity.HasIndex(e => new { e.Time, e.Id })
                    .HasName("order8");

                entity.HasIndex(e => new { e.ToId, e.Id })
                    .HasName("order6");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeletedOne)
                    .IsRequired()
                    .HasColumnName("deleted_one")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeletedTwo)
                    .IsRequired()
                    .HasColumnName("deleted_two")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromId)
                    .HasColumnName("from_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Media)
                    .IsRequired()
                    .HasColumnName("media")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MediaFileName)
                    .IsRequired()
                    .HasColumnName("mediaFileName")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MediaFileNames)
                    .IsRequired()
                    .HasColumnName("mediaFileNames")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationId)
                    .IsRequired()
                    .HasColumnName("notification_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SentPush)
                    .HasColumnName("sent_push")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stickers)
                    .HasColumnName("stickers")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToId)
                    .HasColumnName("to_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeTwo)
                    .IsRequired()
                    .HasColumnName("type_two")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoMoviecommentreplies>(entity =>
            {
                entity.ToTable("wo_moviecommentreplies");

                entity.HasIndex(e => e.CommId)
                    .HasName("comm_id");

                entity.HasIndex(e => e.MovieId)
                    .HasName("movie_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommId)
                    .HasColumnName("comm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Likes)
                    .HasColumnName("likes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoMoviecomments>(entity =>
            {
                entity.ToTable("wo_moviecomments");

                entity.HasIndex(e => e.MovieId)
                    .HasName("movie_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoMovies>(entity =>
            {
                entity.ToTable("wo_movies");

                entity.HasIndex(e => e.Country)
                    .HasName("country");

                entity.HasIndex(e => e.Genre)
                    .HasName("genre");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'upload/photos/d-film.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnName("genre")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Iframe)
                    .IsRequired()
                    .HasColumnName("iframe")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Producer)
                    .IsRequired()
                    .HasColumnName("producer")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasColumnName("rating")
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Stars)
                    .IsRequired()
                    .HasColumnName("stars")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Video)
                    .IsRequired()
                    .HasColumnName("video")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoNotifications>(entity =>
            {
                entity.ToTable("wo_notifications");

                entity.HasIndex(e => e.BlogId)
                    .HasName("blog_id");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.NotifierId)
                    .HasName("notifier_id");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.RecipientId)
                    .HasName("user_id");

                entity.HasIndex(e => e.ReplyId)
                    .HasName("reply_id");

                entity.HasIndex(e => e.Seen)
                    .HasName("seen");

                entity.HasIndex(e => e.SentPush)
                    .HasName("sent_push");

                entity.HasIndex(e => e.StoryId)
                    .HasName("story_id");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => new { e.GroupId, e.Id })
                    .HasName("order6");

                entity.HasIndex(e => new { e.GroupId, e.SeenPop })
                    .HasName("group_id");

                entity.HasIndex(e => new { e.NotifierId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.PageId, e.Id })
                    .HasName("order5");

                entity.HasIndex(e => new { e.PostId, e.Id })
                    .HasName("order4");

                entity.HasIndex(e => new { e.RecipientId, e.Id })
                    .HasName("order3");

                entity.HasIndex(e => new { e.Seen, e.Id })
                    .HasName("order1");

                entity.HasIndex(e => new { e.Time, e.Id })
                    .HasName("order7");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(255)");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FullLink)
                    .IsRequired()
                    .HasColumnName("full_link")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NotifierId)
                    .HasColumnName("notifier_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecipientId)
                    .HasColumnName("recipient_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("reply_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SeenPop)
                    .HasColumnName("seen_pop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SentPush)
                    .HasColumnName("sent_push")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThreadId)
                    .HasColumnName("thread_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type2)
                    .IsRequired()
                    .HasColumnName("type2")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoPageadmins>(entity =>
            {
                entity.ToTable("wo_pageadmins");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPagerating>(entity =>
            {
                entity.ToTable("wo_pagerating");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Review)
                    .HasColumnName("review")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valuation)
                    .HasColumnName("valuation")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WoPages>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PRIMARY");

                entity.ToTable("wo_pages");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.Boosted)
                    .HasName("boosted");

                entity.HasIndex(e => e.PageCategory)
                    .HasName("page_category");

                entity.HasIndex(e => e.Registered)
                    .HasName("registered");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => e.Verified)
                    .HasName("verified");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'upload/photos/d-page.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackgroundImage)
                    .IsRequired()
                    .HasColumnName("background_image")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackgroundImageStatus)
                    .HasColumnName("background_image_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Boosted)
                    .IsRequired()
                    .HasColumnName("boosted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallActionType)
                    .HasColumnName("call_action_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallActionTypeUrl)
                    .IsRequired()
                    .HasColumnName("call_action_type_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'upload/photos/d-cover.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Facebook)
                    .IsRequired()
                    .HasColumnName("facebook")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Google)
                    .IsRequired()
                    .HasColumnName("google")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Instgram)
                    .IsRequired()
                    .HasColumnName("instgram")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Linkedin)
                    .IsRequired()
                    .HasColumnName("linkedin")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.PageCategory)
                    .HasColumnName("page_category")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasColumnName("page_description")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnName("page_name")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnName("page_title")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Registered)
                    .IsRequired()
                    .HasColumnName("registered")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0/0000'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Twitter)
                    .IsRequired()
                    .HasColumnName("twitter")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Verified)
                    .IsRequired()
                    .HasColumnName("verified")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vk)
                    .IsRequired()
                    .HasColumnName("vk")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasColumnName("website")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Youtube)
                    .IsRequired()
                    .HasColumnName("youtube")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoPagesCategories>(entity =>
            {
                entity.ToTable("wo_pages_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LangKey)
                    .IsRequired()
                    .HasColumnName("lang_key")
                    .HasColumnType("varchar(160)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoPagesInvites>(entity =>
            {
                entity.ToTable("wo_pages_invites");

                entity.HasIndex(e => new { e.PageId, e.InviterId, e.InvitedId })
                    .HasName("page_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvitedId)
                    .HasColumnName("invited_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InviterId)
                    .HasColumnName("inviter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPagesLikes>(entity =>
            {
                entity.ToTable("wo_pages_likes");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPaymentTransactions>(entity =>
            {
                entity.ToTable("wo_payment_transactions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(11,0) unsigned");

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasColumnName("kind")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionDt)
                    .HasColumnName("transaction_dt")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<WoPayments>(entity =>
            {
                entity.ToTable("wo_payments");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPinnedposts>(entity =>
            {
                entity.ToTable("wo_pinnedposts");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPokes>(entity =>
            {
                entity.ToTable("wo_pokes");

                entity.HasIndex(e => e.ReceivedUserId)
                    .HasName("received_user_id");

                entity.HasIndex(e => e.SendUserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.ReceivedUserId)
                    .HasColumnName("received_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SendUserId)
                    .HasColumnName("send_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPolls>(entity =>
            {
                entity.ToTable("wo_polls");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoPosts>(entity =>
            {
                entity.ToTable("wo_posts");

                entity.HasIndex(e => e.AlbumName)
                    .HasName("album_name");

                entity.HasIndex(e => e.Boosted)
                    .HasName("boosted");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.MultiImage)
                    .HasName("multi_image");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.PollId)
                    .HasName("poll_id");

                entity.HasIndex(e => e.PostDailymotion)
                    .HasName("postDailymotion");

                entity.HasIndex(e => e.PostFacebook)
                    .HasName("postFacebook");

                entity.HasIndex(e => e.PostFile)
                    .HasName("postFile");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.PostShare)
                    .HasName("postShare");

                entity.HasIndex(e => e.PostSoundCloud)
                    .HasName("postSoundCloud");

                entity.HasIndex(e => e.PostType)
                    .HasName("postType");

                entity.HasIndex(e => e.PostVimeo)
                    .HasName("postVimeo");

                entity.HasIndex(e => e.PostYoutube)
                    .HasName("postYoutube_2");

                entity.HasIndex(e => e.ProductId)
                    .HasName("product_id");

                entity.HasIndex(e => e.RecipientId)
                    .HasName("recipient_id");

                entity.HasIndex(e => e.Registered)
                    .HasName("registered");

                entity.HasIndex(e => e.SharedFrom)
                    .HasName("shared_from");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => e.VideoViews)
                    .HasName("videoViews");

                entity.HasIndex(e => new { e.EventId, e.Id })
                    .HasName("order5");

                entity.HasIndex(e => new { e.GroupId, e.Id })
                    .HasName("order3");

                entity.HasIndex(e => new { e.PageId, e.Id })
                    .HasName("order2");

                entity.HasIndex(e => new { e.ParentId, e.Id })
                    .HasName("order6");

                entity.HasIndex(e => new { e.RecipientId, e.Id })
                    .HasName("order4");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("order1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("album_name")
                    .HasColumnType("varchar(52)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blur)
                    .HasColumnName("blur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Boosted)
                    .HasColumnName("boosted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cache)
                    .HasColumnName("cache")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentsStatus)
                    .HasColumnName("comments_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MultiImage)
                    .IsRequired()
                    .HasColumnName("multi_image")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageEventId)
                    .HasColumnName("page_event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(15)");

                entity.Property(e => e.PollId)
                    .HasColumnName("poll_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostDailymotion)
                    .IsRequired()
                    .HasColumnName("postDailymotion")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostFacebook)
                    .IsRequired()
                    .HasColumnName("postFacebook")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostFeeling)
                    .IsRequired()
                    .HasColumnName("postFeeling")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostFile)
                    .IsRequired()
                    .HasColumnName("postFile")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostFileName)
                    .IsRequired()
                    .HasColumnName("postFileName")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostFileThumb)
                    .IsRequired()
                    .HasColumnName("postFileThumb")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostLink)
                    .IsRequired()
                    .HasColumnName("postLink")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostLinkContent)
                    .IsRequired()
                    .HasColumnName("postLinkContent")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostLinkImage)
                    .IsRequired()
                    .HasColumnName("postLinkImage")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostLinkTitle)
                    .HasColumnName("postLinkTitle")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostListening)
                    .IsRequired()
                    .HasColumnName("postListening")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostMap)
                    .IsRequired()
                    .HasColumnName("postMap")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostPhoto)
                    .IsRequired()
                    .HasColumnName("postPhoto")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostPlaying)
                    .IsRequired()
                    .HasColumnName("postPlaying")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostPlaytube)
                    .IsRequired()
                    .HasColumnName("postPlaytube")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostPrivacy)
                    .IsRequired()
                    .HasColumnName("postPrivacy")
                    .HasColumnType("enum('0','1','2','3')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostRecord)
                    .IsRequired()
                    .HasColumnName("postRecord")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostShare)
                    .HasColumnName("postShare")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostSoundCloud)
                    .IsRequired()
                    .HasColumnName("postSoundCloud")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostSticker)
                    .HasColumnName("postSticker")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostText)
                    .HasColumnName("postText")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PostTraveling)
                    .IsRequired()
                    .HasColumnName("postTraveling")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasColumnName("postType")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostUrl)
                    .HasColumnName("post_url")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostVimeo)
                    .IsRequired()
                    .HasColumnName("postVimeo")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostVine)
                    .IsRequired()
                    .HasColumnName("postVine")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostWatching)
                    .IsRequired()
                    .HasColumnName("postWatching")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostYoutube)
                    .IsRequired()
                    .HasColumnName("postYoutube")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecipientId)
                    .HasColumnName("recipient_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Registered)
                    .IsRequired()
                    .HasColumnName("registered")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0/0000'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SharedFrom)
                    .HasColumnName("shared_from")
                    .HasColumnType("int(15)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VideoViews)
                    .HasColumnName("videoViews")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoProducts>(entity =>
            {
                entity.ToTable("wo_products");

                entity.HasIndex(e => e.Category)
                    .HasName("category");

                entity.HasIndex(e => e.Price)
                    .HasName("price");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("'USD'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasColumnName("lng")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0.00'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('0','1')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoProductsCategories>(entity =>
            {
                entity.ToTable("wo_products_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LangKey)
                    .IsRequired()
                    .HasColumnName("lang_key")
                    .HasColumnType("varchar(160)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoProductsMedia>(entity =>
            {
                entity.ToTable("wo_products_media");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoProfilefields>(entity =>
            {
                entity.ToTable("wo_profilefields");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.ProfilePage)
                    .HasName("profile_page");

                entity.HasIndex(e => e.RegistrationPage)
                    .HasName("registration_page");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasColumnName("placement")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'profile'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProfilePage)
                    .HasColumnName("profile_page")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegistrationPage)
                    .HasColumnName("registration_page")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SelectType)
                    .IsRequired()
                    .HasColumnName("select_type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'none'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<WoReactions>(entity =>
            {
                entity.ToTable("wo_reactions");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.Reaction)
                    .HasName("idx_reaction");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reaction)
                    .HasColumnName("reaction")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReplayId)
                    .HasColumnName("replay_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<WoRecentsearches>(entity =>
            {
                entity.ToTable("wo_recentsearches");

                entity.HasIndex(e => e.SearchType)
                    .HasName("search_type");

                entity.HasIndex(e => new { e.UserId, e.SearchId })
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SearchId)
                    .HasColumnName("search_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SearchType)
                    .IsRequired()
                    .HasColumnName("search_type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoRelationship>(entity =>
            {
                entity.ToTable("wo_relationship");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.FromId)
                    .HasName("from_id");

                entity.HasIndex(e => e.Relationship)
                    .HasName("relationship");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromId)
                    .HasColumnName("from_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToId)
                    .HasColumnName("to_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoReports>(entity =>
            {
                entity.ToTable("wo_reports");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("profile_id");

                entity.HasIndex(e => e.Seen)
                    .HasName("seen");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int(15) unsigned");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(15)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(15)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProfileId)
                    .HasColumnName("profile_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoSavedposts>(entity =>
            {
                entity.ToTable("wo_savedposts");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoStickers>(entity =>
            {
                entity.ToTable("wo_stickers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.MediaFile)
                    .IsRequired()
                    .HasColumnName("media_file")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoStorySeen>(entity =>
            {
                entity.ToTable("wo_story_seen");

                entity.HasIndex(e => e.StoryId)
                    .HasName("story_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoTerms>(entity =>
            {
                entity.ToTable("wo_terms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoTokens>(entity =>
            {
                entity.ToTable("wo_tokens");

                entity.HasIndex(e => e.AppId)
                    .HasName("app_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(32)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoUserGifts>(entity =>
            {
                entity.ToTable("wo_user_gifts");

                entity.HasIndex(e => e.From)
                    .HasName("from");

                entity.HasIndex(e => e.GiftId)
                    .HasName("gift_id");

                entity.HasIndex(e => e.To)
                    .HasName("to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GiftId)
                    .HasColumnName("gift_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.To)
                    .HasColumnName("to")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoUserads>(entity =>
            {
                entity.ToTable("wo_userads");

                entity.HasIndex(e => e.Appears)
                    .HasName("appears");

                entity.HasIndex(e => e.Gender)
                    .HasName("gender");

                entity.HasIndex(e => e.Location)
                    .HasName("location");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdMedia)
                    .IsRequired()
                    .HasColumnName("ad_media")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Appears)
                    .IsRequired()
                    .HasColumnName("appears")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'post'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Audience)
                    .HasColumnName("audience")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bidding)
                    .IsRequired()
                    .HasColumnName("bidding")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Clicks)
                    .HasColumnName("clicks")
                    .HasColumnType("int(15)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_danish_ci");

                entity.Property(e => e.Headline)
                    .IsRequired()
                    .HasColumnName("headline")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("'us'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posted)
                    .IsRequired()
                    .HasColumnName("posted")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int(15)");
            });

            modelBuilder.Entity<WoUseradsData>(entity =>
            {
                entity.ToTable("wo_userads_data");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdId)
                    .HasColumnName("ad_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Clicks)
                    .HasColumnName("clicks")
                    .HasColumnType("int(15)");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Spend)
                    .HasColumnName("spend")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int(15)");
            });

            modelBuilder.Entity<WoUserfields>(entity =>
            {
                entity.ToTable("wo_userfields");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("wo_users");

                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.Admin)
                    .HasName("admin");

                entity.HasIndex(e => e.Avatar)
                    .HasName("avatar");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.HasIndex(e => e.FirstName)
                    .HasName("first_name");

                entity.HasIndex(e => e.FriendPrivacy)
                    .HasName("friend_privacy");

                entity.HasIndex(e => e.Gender)
                    .HasName("gender");

                entity.HasIndex(e => e.Joined)
                    .HasName("joined");

                entity.HasIndex(e => e.LastDataUpdate)
                    .HasName("last_data_update");

                entity.HasIndex(e => e.LastName)
                    .HasName("last_name");

                entity.HasIndex(e => e.Lat)
                    .HasName("lat");

                entity.HasIndex(e => e.Lng)
                    .HasName("lng");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("phone_number");

                entity.HasIndex(e => e.Points)
                    .HasName("points");

                entity.HasIndex(e => e.Referrer)
                    .HasName("referrer");

                entity.HasIndex(e => e.Registered)
                    .HasName("registered");

                entity.HasIndex(e => e.Src)
                    .HasName("src");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.HasIndex(e => e.Wallet)
                    .HasName("wallet");

                entity.HasIndex(e => new { e.Active, e.UserId })
                    .HasName("order4");

                entity.HasIndex(e => new { e.Email, e.UserId })
                    .HasName("order2");

                entity.HasIndex(e => new { e.Lastseen, e.UserId })
                    .HasName("order3");

                entity.HasIndex(e => new { e.Username, e.UserId })
                    .HasName("order1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.About)
                    .HasColumnName("about")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasColumnType("enum('0','1','2')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Admin)
                    .IsRequired()
                    .HasColumnName("admin")
                    .HasColumnType("enum('0','1','2')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AndroidMDeviceId)
                    .IsRequired()
                    .HasColumnName("android_m_device_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AndroidNDeviceId)
                    .IsRequired()
                    .HasColumnName("android_n_device_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'upload/photos/d-avatar.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackgroundImage)
                    .IsRequired()
                    .HasColumnName("background_image")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackgroundImageStatus)
                    .IsRequired()
                    .HasColumnName("background_image_status")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasColumnName("balance")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BirthPrivacy)
                    .IsRequired()
                    .HasColumnName("birth_privacy")
                    .HasColumnType("enum('0','1','2')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Birthday)
                    .IsRequired()
                    .HasColumnName("birthday")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0000-00-00'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConfirmFollowers)
                    .IsRequired()
                    .HasColumnName("confirm_followers")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'upload/photos/d-cover.jpg'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CssFile)
                    .IsRequired()
                    .HasColumnName("css_file")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DailyPoints)
                    .HasColumnName("daily_points")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("details")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("'a:6:{s:10:\"post_count\";i:0;s:11:\"album_count\";i:0;s:15:\"following_count\";i:0;s:15:\"followers_count\";i:0;s:12:\"groups_count\";i:0;s:11:\"likes_count\";i:0;}'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EAccepted)
                    .IsRequired()
                    .HasColumnName("e_accepted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ECommented)
                    .IsRequired()
                    .HasColumnName("e_commented")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EFollowed)
                    .IsRequired()
                    .HasColumnName("e_followed")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EJoinedGroup)
                    .IsRequired()
                    .HasColumnName("e_joined_group")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ELastNotif)
                    .IsRequired()
                    .HasColumnName("e_last_notif")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ELiked)
                    .IsRequired()
                    .HasColumnName("e_liked")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ELikedPage)
                    .IsRequired()
                    .HasColumnName("e_liked_page")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EMentioned)
                    .IsRequired()
                    .HasColumnName("e_mentioned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EProfileWallPost)
                    .IsRequired()
                    .HasColumnName("e_profile_wall_post")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ESentmeMsg)
                    .IsRequired()
                    .HasColumnName("e_sentme_msg")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EShared)
                    .IsRequired()
                    .HasColumnName("e_shared")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EVisited)
                    .IsRequired()
                    .HasColumnName("e_visited")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EWondered)
                    .IsRequired()
                    .HasColumnName("e_wondered")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailCode)
                    .IsRequired()
                    .HasColumnName("email_code")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailNotification)
                    .IsRequired()
                    .HasColumnName("emailNotification")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Facebook)
                    .IsRequired()
                    .HasColumnName("facebook")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FollowPrivacy)
                    .IsRequired()
                    .HasColumnName("follow_privacy")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FriendPrivacy)
                    .IsRequired()
                    .HasColumnName("friend_privacy")
                    .HasColumnType("enum('0','1','2','3')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'male'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Google)
                    .IsRequired()
                    .HasColumnName("google")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InfoFile)
                    .IsRequired()
                    .HasColumnName("info_file")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Instagram)
                    .IsRequired()
                    .HasColumnName("instagram")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IosMDeviceId)
                    .IsRequired()
                    .HasColumnName("ios_m_device_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IosNDeviceId)
                    .IsRequired()
                    .HasColumnName("ios_n_device_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsPro)
                    .IsRequired()
                    .HasColumnName("is_pro")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Joined)
                    .HasColumnName("joined")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(31)")
                    .HasDefaultValueSql("'english'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastAvatarMod)
                    .HasColumnName("last_avatar_mod")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastCoverMod)
                    .HasColumnName("last_cover_mod")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastDataUpdate)
                    .HasColumnName("last_data_update")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastEmailSent)
                    .HasColumnName("last_email_sent")
                    .HasColumnType("int(32)");

                entity.Property(e => e.LastFollowId)
                    .HasColumnName("last_follow_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastLocationUpdate)
                    .IsRequired()
                    .HasColumnName("last_location_update")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLoginData)
                    .HasColumnName("last_login_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastseen)
                    .HasColumnName("lastseen")
                    .HasColumnType("int(32)");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Linkedin)
                    .IsRequired()
                    .HasColumnName("linkedin")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasColumnName("lng")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessagePrivacy)
                    .IsRequired()
                    .HasColumnName("message_privacy")
                    .HasColumnType("enum('1','0','2')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NewEmail)
                    .IsRequired()
                    .HasColumnName("new_email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NewPhone)
                    .IsRequired()
                    .HasColumnName("new_phone")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationSettings)
                    .IsRequired()
                    .HasColumnName("notification_settings")
                    .HasColumnType("varchar(400)")
                    .HasDefaultValueSql("'a:11:{s:7:&quot;e_liked&quot;;i:1;s:8:&quot;e_shared&quot;;i:1;s:10:&quot;e_wondered&quot;;i:0;s:11:&quot;e_commented&quot;;i:1;s:10:&quot;e_followed&quot;;i:1;s:10:&quot;e_accepted&quot;;i:1;s:11:&quot;e_mentioned&quot;;i:1;s:14:&quot;e_joined_group&quot;;i:1;s:12:&quot;e_liked_page&quot;;i:1;s:9:&quot;e_visited&quot;;i:1;s:19:&quot;e_profile_wall_post&quot;;i:1;}'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationsSound)
                    .IsRequired()
                    .HasColumnName("notifications_sound")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderPostsBy)
                    .IsRequired()
                    .HasColumnName("order_posts_by")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalEmail)
                    .IsRequired()
                    .HasColumnName("paypal_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PointDayExpire)
                    .IsRequired()
                    .HasColumnName("point_day_expire")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.PostPrivacy)
                    .IsRequired()
                    .HasColumnName("post_privacy")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'ifollow'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProTime)
                    .HasColumnName("pro_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProType)
                    .IsRequired()
                    .HasColumnName("pro_type")
                    .HasColumnType("enum('0','1','2','3','4')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Referrer)
                    .HasColumnName("referrer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Registered)
                    .IsRequired()
                    .HasColumnName("registered")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'0/0000'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RelationshipId)
                    .HasColumnName("relationship_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasColumnName("school")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShareMyData)
                    .HasColumnName("share_my_data")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ShareMyLocation)
                    .HasColumnName("share_my_location")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ShowActivitiesPrivacy)
                    .IsRequired()
                    .HasColumnName("show_activities_privacy")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Showlastseen)
                    .IsRequired()
                    .HasColumnName("showlastseen")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SidebarData)
                    .HasColumnName("sidebar_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsCode)
                    .HasColumnName("sms_code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SocialLogin)
                    .IsRequired()
                    .HasColumnName("social_login")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Src)
                    .IsRequired()
                    .HasColumnName("src")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'Undefined'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartUp)
                    .IsRequired()
                    .HasColumnName("start_up")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartUpInfo)
                    .IsRequired()
                    .HasColumnName("start_up_info")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartupFollow)
                    .IsRequired()
                    .HasColumnName("startup_follow")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartupImage)
                    .IsRequired()
                    .HasColumnName("startup_image")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Twitter)
                    .IsRequired()
                    .HasColumnName("twitter")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TwoFactor)
                    .HasColumnName("two_factor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TwoFactorVerified)
                    .HasColumnName("two_factor_verified")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("'user'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Verified)
                    .IsRequired()
                    .HasColumnName("verified")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VisitPrivacy)
                    .IsRequired()
                    .HasColumnName("visit_privacy")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vk)
                    .IsRequired()
                    .HasColumnName("vk")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Wallet)
                    .IsRequired()
                    .HasColumnName("wallet")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0.00'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WebDeviceId)
                    .IsRequired()
                    .HasColumnName("web_device_id")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasColumnName("website")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Working)
                    .IsRequired()
                    .HasColumnName("working")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkingLink)
                    .IsRequired()
                    .HasColumnName("working_link")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Youtube)
                    .IsRequired()
                    .HasColumnName("youtube")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoUserschat>(entity =>
            {
                entity.ToTable("wo_userschat");

                entity.HasIndex(e => e.ConversationUserId)
                    .HasName("conversation_user_id");

                entity.HasIndex(e => e.Time)
                    .HasName("time");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ConversationUserId, e.Id })
                    .HasName("order4");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("order2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConversationUserId)
                    .HasColumnName("conversation_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoUserstory>(entity =>
            {
                entity.ToTable("wo_userstory");

                entity.HasIndex(e => e.Expire)
                    .HasName("expires");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expire)
                    .HasColumnName("expire")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Posted)
                    .IsRequired()
                    .HasColumnName("posted")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("thumbnail")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(50)");
            });

            modelBuilder.Entity<WoUserstorymedia>(entity =>
            {
                entity.ToTable("wo_userstorymedia");

                entity.HasIndex(e => e.Expire)
                    .HasName("expire");

                entity.HasIndex(e => e.StoryId)
                    .HasName("story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expire)
                    .HasColumnName("expire")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .HasColumnType("int(30)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoVerificationRequests>(entity =>
            {
                entity.ToTable("wo_verification_requests");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasColumnName("passport")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Seen)
                    .HasColumnName("seen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WoVideocalles>(entity =>
            {
                entity.ToTable("wo_videocalles");

                entity.HasIndex(e => e.Called)
                    .HasName("called");

                entity.HasIndex(e => e.Declined)
                    .HasName("declined");

                entity.HasIndex(e => e.FromId)
                    .HasName("from_id");

                entity.HasIndex(e => e.ToId)
                    .HasName("to_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AccessToken2)
                    .HasColumnName("access_token_2")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Called)
                    .HasColumnName("called")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Declined)
                    .HasColumnName("declined")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromId)
                    .HasColumnName("from_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasColumnName("room_name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToId)
                    .HasColumnName("to_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoVotes>(entity =>
            {
                entity.ToTable("wo_votes");

                entity.HasIndex(e => e.OptionId)
                    .HasName("option_id");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WoWonders>(entity =>
            {
                entity.ToTable("wo_wonders");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
