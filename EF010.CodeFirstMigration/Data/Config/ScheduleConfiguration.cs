using EF010.CodeFirstMigration.Entities;
using EF010.CodeFirstMigration.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF010.CodeFirstMigration.Data.Config
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .ValueGeneratedNever();

            // builder.Property(x => x.CourseName).HasMaxLength(255); // nvarchar(255)

            //builder
            //    .Property(x => x.Title)
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(50)
            //    .IsRequired();

            builder
                .Property(x => x.Title)
                .HasConversion(x => x.ToString(), x => (ScheduleOptions)Enum.Parse(typeof(ScheduleOptions), x));

            builder
                .ToTable("Schedules");


            builder
                .HasData(LoadSchedules());
        }

        private static List<Schedule> LoadSchedules()
        {
            return new List<Schedule>
            {
                new Schedule { Id = 1, Title = ScheduleOptions.Daily       , SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false },
                new Schedule { Id = 2, Title = ScheduleOptions.DayAfterDay , SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = false },
                new Schedule { Id = 3, Title = ScheduleOptions.TwiceAWeek  , SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false },
                new Schedule { Id = 4, Title = ScheduleOptions.Weekend     , SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true },
                new Schedule { Id = 5, Title = ScheduleOptions.Compact     , SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true }
            };
        }
    }
}
