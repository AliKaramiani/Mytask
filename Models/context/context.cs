using Microsoft.EntityFrameworkCore;

public class context :DbContext
{
    public DbSet<userinfo>Tbl_userinfo { get; set; }
    public DbSet<Atteched> Tbl_Atteched{ get; set; }
    public DbSet<Messages>Tbl_Message { get; set; }
    public DbSet<Recivers> Tbl_Recivers { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("server=.\\SQL2019;database=IliaDabirkhane1;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
         optionsBuilder.UseSqlServer("server=DEVELOPER1;database=task;user ID=sa;password=12345@Iran;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }
}