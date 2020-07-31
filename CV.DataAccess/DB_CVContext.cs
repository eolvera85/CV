using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CV.DataAccess
{
    public partial class DB_CVContext : DbContext
    {
        public DB_CVContext()
        {
        }

        public DB_CVContext(DbContextOptions<DB_CVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<ContactMe> ContactMe { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CourseTypes> CourseTypes { get; set; }
        public virtual DbSet<Curriculums> Curriculums { get; set; }
        public virtual DbSet<DegreeLevels> DegreeLevels { get; set; }
        public virtual DbSet<DegreeStatus> DegreeStatus { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Educations> Educations { get; set; }
        public virtual DbSet<FederalStates> FederalStates { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillTypes> SkillTypes { get; set; }
        public virtual DbSet<WorkExperiences> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=EOLVERA85;Database=DB_CV;User=sa;Password=Mery8783a;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInformation>(entity =>
            {
                entity.ToTable("contact_information");

                entity.Property(e => e.ContactInformationId).HasColumnName("contact_information_id");

                entity.Property(e => e.Address01)
                    .HasColumnName("address_01")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("address_02")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FederalStateId).HasColumnName("federal_state_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.FederalState)
                    .WithMany(p => p.ContactInformation)
                    .HasForeignKey(d => d.FederalStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSONAL_INF_FEDERAL_STATE");
            });

            modelBuilder.Entity<ContactMe>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contact_me");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sended).HasColumnName("sended");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.ContactMe)
                    .HasForeignKey(d => d.CvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTACT_CV");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("countries");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nacionalty)
                    .IsRequired()
                    .HasColumnName("nacionalty")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("courses");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("course_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourseTypeId).HasColumnName("course_type_id");

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSE_TYPE");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_COURSE_LOGO");
            });

            modelBuilder.Entity<CourseTypes>(entity =>
            {
                entity.HasKey(e => e.CourseTypeId);

                entity.ToTable("course_types");

                entity.Property(e => e.CourseTypeId).HasColumnName("course_type_id");

                entity.Property(e => e.CourseTypeDescription)
                    .IsRequired()
                    .HasColumnName("course_type_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Curriculums>(entity =>
            {
                entity.HasKey(e => e.CvId);

                entity.ToTable("curriculums");

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Birthname)
                    .HasColumnName("birthname")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactInformationId).HasColumnName("contact_information_id");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Hobbies)
                    .HasColumnName("hobbies")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname01)
                    .IsRequired()
                    .HasColumnName("lastname_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname02)
                    .HasColumnName("lastname_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");

                entity.Property(e => e.Name01)
                    .IsRequired()
                    .HasColumnName("name_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name02)
                    .HasColumnName("name_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.Strengths)
                    .HasColumnName("strengths")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("summary")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Title01)
                    .IsRequired()
                    .HasColumnName("title_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title02)
                    .HasColumnName("title_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContactInformation)
                    .WithMany(p => p.Curriculums)
                    .HasForeignKey(d => d.ContactInformationId)
                    .HasConstraintName("FK_CV_CONTACT");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.CurriculumsDocument)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_CV_DOCUMENT");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Curriculums)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CV_MARITAL");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Curriculums)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CV_NATIONAL");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.CurriculumsPhoto)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("FK_CV_PHOTO");
            });

            modelBuilder.Entity<DegreeLevels>(entity =>
            {
                entity.HasKey(e => e.DegreeLevelId);

                entity.ToTable("degree_levels");

                entity.Property(e => e.DegreeLevelId).HasColumnName("degree_level_id");

                entity.Property(e => e.DegreeLevelDescription)
                    .IsRequired()
                    .HasColumnName("degree_level_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DegreeStatus>(entity =>
            {
                entity.ToTable("degree_status");

                entity.Property(e => e.DegreeStatusId).HasColumnName("degree_status_id");

                entity.Property(e => e.DegreeStatusDescription)
                    .IsRequired()
                    .HasColumnName("degree_status_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("documents");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.DocumentContentType)
                    .IsRequired()
                    .HasColumnName("document_content_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentContents)
                    .IsRequired()
                    .HasColumnName("document_contents");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasColumnName("document_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Educations>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("educations");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.DegreeLevelId).HasColumnName("degree_level_id");

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasColumnName("degree_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeStatusId).HasColumnName("degree_status_id");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDate)
                    .HasColumnName("final_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialDate)
                    .HasColumnName("initial_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasColumnName("school_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasColumnName("website")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.CvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDUCATION_CV");

                entity.HasOne(d => d.DegreeLevel)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.DegreeLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDUCATION_DEGREE_LEVEL");

                entity.HasOne(d => d.DegreeStatus)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.DegreeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDUCATION_DEGREE_TYPE");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_EDUCATION_LOGO");
            });

            modelBuilder.Entity<FederalStates>(entity =>
            {
                entity.HasKey(e => e.FederalStateId);

                entity.ToTable("federal_states");

                entity.Property(e => e.FederalStateId).HasColumnName("federal_state_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.FederalStateName)
                    .IsRequired()
                    .HasColumnName("federal_state_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FederalStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FED_STATE_COUNTRY");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("marital_status");

                entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");

                entity.Property(e => e.MaritalStatusDescription)
                    .IsRequired()
                    .HasColumnName("marital_status_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("skills");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.Percentage)
                    .HasColumnName("percentage")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnName("skill_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.CvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SKILL_CV");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_SKILLS_LOGO");

                entity.HasOne(d => d.SkillType)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.SkillTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SKILLS_SKILL_TYPE");
            });

            modelBuilder.Entity<SkillTypes>(entity =>
            {
                entity.HasKey(e => e.SkillTypeId);

                entity.ToTable("skill_types");

                entity.Property(e => e.SkillTypeId).HasColumnName("skill_type_id");

                entity.Property(e => e.SkillTypeDescription)
                    .IsRequired()
                    .HasColumnName("skill_type_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkExperiences>(entity =>
            {
                entity.HasKey(e => e.WorkExperienceId);

                entity.ToTable("work_experiences");

                entity.Property(e => e.WorkExperienceId).HasColumnName("work_experience_id");

                entity.Property(e => e.Business)
                    .IsRequired()
                    .HasColumnName("business")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvId).HasColumnName("cv_id");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDate)
                    .HasColumnName("final_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialDate)
                    .HasColumnName("initial_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("job_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.CvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WORK_EXP_CV");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_WORK_EXP_LOGO");
            });
        }
    }
}
