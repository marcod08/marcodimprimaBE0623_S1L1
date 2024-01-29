
namespace BE_S1L1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Atleta UsainBolt = new Atleta();
            UsainBolt.Run();
            Dipendente Giancarlo = new Dipendente();
            Giancarlo.Greet();
            Animal Fuffy = new Animal();
            Fuffy.MakeASound();
            Veicolo Lamborghini = new Veicolo();
            Lamborghini.Accelerate();
        }
    }

    class Atleta
    {
        public string Name = "Usain";
        public int Age = 37;
        public string Sport = "Athletics";
        public void Run()
        {
            Console.WriteLine("VRUMMM i'm really fast, see ya!");
        }
    }

    class Dipendente
    {
        public string Name = "Giancarlo";
        public string Job = "Back-End Developer";
        public int YearOfExperience = 5;
        public void Greet()
        {
            Console.WriteLine("Hey i'm Giancarlo and I work here! where? I said here!");
        }
    }

    class Animal
    {
        public string Name = "Fuffy";
        public string Species = "Cat";
        public void MakeASound()
        {
            Console.WriteLine("MAOOOOOOOOO");
        }
    }

    class Veicolo
    {
        public string Brand = "Lamorghini";
        public int MaxSpeed = 319;
        public void Accelerate()
        {
            Console.WriteLine("VRUMM i'm really fast, way more than Usain");
        }
    }
}