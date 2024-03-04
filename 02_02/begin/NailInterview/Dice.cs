public class Dice
{
    static int sidesOfDice = 6;
    int faceValue = 0;

    public static void changeNumSidesOfDice(int newNumberOfSides)
    {
        Dice.sidesOfDice = newNumberOfSides;
    }
      
    public int getFaceValue()
    {
        return this.faceValue;
    }
      
    public int roll()
    {
        Random rand = new Random();
        this.faceValue = rand.Next(sidesOfDice) + 1;
        return this.faceValue;
    }

    public static void Main(string[] args)
    {
        // Creating some dice:
        // -------------------
        Console.WriteLine(Dice.sidesOfDice);
        
        Dice myFirstDice = new Dice();
        Dice myOtherDice = new Dice();

       // Rolling two 6-sided dice:
       // -------------------
        Console.WriteLine();
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("First Die: " + myFirstDice.roll());
            Console.WriteLine("Second Die: " + myOtherDice.roll());
        }
        
       // Retrieving face value:
       // -------------------
        Console.WriteLine();
        Console.WriteLine("Face Value: " + myFirstDice.getFaceValue());
        Console.WriteLine("Face Value: " + myOtherDice.getFaceValue());

    }
}
