namespace 研招网系统.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class YZWModels : DbContext
    {
        public YZWModels()
            : base("name=YZWModels")
        {
            Database.SetInitializer<YZWModels>(null);
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Information> Information { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Admin>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Admin>()
            //    .Property(e => e.Password)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Answer>()
            //    .Property(e => e.Content)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Answer>()
            //    .Property(e => e.Way)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Category>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Information>()
            //    .Property(e => e.Title)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Information>()
            //    .Property(e => e.Content)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Policy>()
            //    .Property(e => e.Title)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Policy>()
            //    .Property(e => e.Content)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Question>()
            //    .Property(e => e.Title)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Question>()
            //    .Property(e => e.Content)
            //    .IsUnicode(false);

            //modelBuilder.Entity<School>()
            //    .HasMany(e => e.Student)
            //    .WithRequired(e => e.School)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<User>()
            //    .Property(e => e.Major)
            //    .IsUnicode(false);

            //modelBuilder.Entity<User>()
            //    .Property(e => e.Colleges)
            //    .IsUnicode(false);

            //modelBuilder.Entity<User>()
            //    .Property(e => e.Area)
            //    .IsUnicode(false);

            //modelBuilder.Entity<User>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<User>()
            //    .Property(e => e.Password)
            //    .IsUnicode(false);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.Answer)
            //    .WithRequired(e => e.User)
            //    .HasForeignKey(e => e.UserId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.Answer1)
            //    .WithRequired(e => e.User1)
            //    .HasForeignKey(e => e.UserId)
            //    .WillCascadeOnDelete(false);

        }
    }
}
