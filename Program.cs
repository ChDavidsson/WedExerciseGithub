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

            Weight person1 = new Weight();
            person1.Bulking(1.0);
            person1.Cutting(2.0);
            person1.GetWeight();
        }
    }
}
