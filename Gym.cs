namespace WedExerciseGithub
{
    public class Gym
    {
        //En grundläggande klass med enkel struktur (t.ex. Person, Account, Shape, etc.)
        //ATTRIBUT
        public string Type { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        //METOD
        public void DisplayWorkout()
        {
            Console.WriteLine($"Workout Type: {Type}, Sets: {Sets}, Reps: {Reps}");
        }


    }
}
