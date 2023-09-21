using Microsoft.EntityFrameworkCore;

namespace WorkoutApi.Models;

public class ExerciseContext : DbContext
{
    public ExerciseContext(DbContextOptions<ExerciseContext> options) : base(options) { }

    public DbSet<Exercise> Exercises { get; set; } = null!;
}
