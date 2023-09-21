namespace WorkoutApi.Models;

public class Exercise
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public float WeightKg { get; set; }

    public int Reps { get; set; }
}
