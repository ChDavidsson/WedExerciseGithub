namespace WedExerciseGithub
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OBJECT
            Gym workout1 = new Gym();
            workout1.Type = "Push-ups";
            workout1.Sets = 3;
            workout1.Reps = 10;
            workout1.DisplayWorkout();

            Weight person1 = new Weight();
            person1.Bulking(1.0);
            person1.Cutting(2.0);
            person1.GetWeight();


            Pull_ups workout2 = new Pull_ups();
            workout2.Type = "Pull-ups";
            workout2.Sets = 2;
            workout2.Reps = 10;
            workout2.AddedWeight = 10;
            workout2.DisplayPullUps();
        }
    }
}
