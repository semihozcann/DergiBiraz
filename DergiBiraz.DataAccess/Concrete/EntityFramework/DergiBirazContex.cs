using DergiBiraz.DataAccess.Concrete.EntityFramework.Mapping;
using DergiBiraz.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.DataAccess.Concrete.EntityFramework
{
    public class DergiBirazContex : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DergiBirazContex()
        {

        }

        public DergiBirazContex(DbContextOptions<DergiBirazContex> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=DergiBirazDb;Trusted_Connection=true");

            }
            base.OnConfiguring(optionsBuilder);



        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<Writer> Writers { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());


            builder.ApplyConfiguration(new ArticleMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ArticleCommentMap());
            builder.ApplyConfiguration(new WriterMap());


        }
    }
}
