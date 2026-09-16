namespace WedExerciseGithub
{
    public class Pull_ups : Gym
    {
        //Arv - Skapa en subklass som ärver från huvudklassen
        public int AddedWeight { get; set; }

        public void DisplayPullUps()
        {
            Console.WriteLine($"{Type} with Added Weight: {AddedWeight} kg, Sets: {Sets}, Reps: {Reps}");
        }
    }
}
