namespace WedExerciseGithub
{
    public class Weight
    {
        //Inkapsling - Visa inkapsling med private fält och public metoder
        
        //ATTRIBUT
        private double weightInKg;

        //METOD
        public void Bulking(double weight)
        {
            weightInKg += weight;
            Console.WriteLine($"Gained {weight} kg. Current weight: {weightInKg} kg.");
        }

        public void Cutting(double weight)
        {
            weightInKg -= weight;
            Console.WriteLine($"Lost {weight} kg. Current weight: {weightInKg} kg.");
        }

        public void GetWeight()
        {
            Console.WriteLine($"Current weight gain/loss: {weightInKg} kg.");
        }
    }
}
