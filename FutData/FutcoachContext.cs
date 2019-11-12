using Microsoft.EntityFrameworkCore;

namespace FutData
{
    public partial class FutcoachContext : DbContext
    {
        public FutcoachContext()
        {
        }

        public FutcoachContext(DbContextOptions<FutcoachContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<Leagues> Leagues { get; set; }
        public virtual DbSet<Nations> Nations { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DQ68JJL;Initial Catalog=FutCoach;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Cards>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("cards");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardVersion)
                    .IsRequired()
                    .HasColumnName("card_version")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cards_players");
            });

            modelBuilder.Entity<Leagues>(entity =>
            {
                entity.HasKey(e => e.LeagueId);

                entity.ToTable("leagues");

                entity.Property(e => e.LeagueId)
                    .HasColumnName("league_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeagueName)
                    .IsRequired()
                    .HasColumnName("league_name")
                    .HasMaxLength(10);

                entity.Property(e => e.LeagueNation)
                    .IsRequired()
                    .HasColumnName("league_nation")
                    .HasMaxLength(10);

                entity.Property(e => e.NationId).HasColumnName("nation_id");

                entity.HasOne(d => d.Nation)
                    .WithMany(p => p.Leagues)
                    .HasForeignKey(d => d.NationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_leagues_nations");
            });

            modelBuilder.Entity<Nations>(entity =>
            {
                entity.HasKey(e => e.NationId);

                entity.ToTable("nations");

                entity.Property(e => e.NationId)
                    .HasColumnName("nation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NationName)
                    .IsRequired()
                    .HasColumnName("nation_name")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK_spelers");

                entity.ToTable("players");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.PlayerDefending)
                    .IsRequired()
                    .HasColumnName("player_defending")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerDribbling)
                    .IsRequired()
                    .HasColumnName("player_dribbling")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerFirstname)
                    .IsRequired()
                    .HasColumnName("player_firstname")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerLastname)
                    .IsRequired()
                    .HasColumnName("player_lastname")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerNation)
                    .IsRequired()
                    .HasColumnName("player_nation")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerPace)
                    .IsRequired()
                    .HasColumnName("player_pace")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerPassing)
                    .IsRequired()
                    .HasColumnName("player_passing")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerPhysicality)
                    .IsRequired()
                    .HasColumnName("player_physicality")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerPosition)
                    .IsRequired()
                    .HasColumnName("player_position")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerShooting)
                    .IsRequired()
                    .HasColumnName("player_shooting")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerTeam)
                    .IsRequired()
                    .HasColumnName("player_team")
                    .HasMaxLength(10);

                entity.Property(e => e.PlyaerLeague)
                    .IsRequired()
                    .HasColumnName("plyaer_league")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_players_teams");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("teams");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.LeagueId).HasColumnName("league_id");

                entity.Property(e => e.TeamLeague)
                    .IsRequired()
                    .HasColumnName("team_league")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasColumnName("team_name")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamNation)
                    .IsRequired()
                    .HasColumnName("team_nation")
                    .HasMaxLength(10);

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeagueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teams_leagues");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}