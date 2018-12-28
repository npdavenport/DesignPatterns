namespace DesignPatterns.Decorator
{
    public interface IBird
    {
        string Fly();
        int Age { get; set; }
    }

    public class Bird : IBird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return "Soaring in the sky with weight " + Age;
        }
    }

    public interface ILizard
    {
        string Crawl();
        int Age { get; set; }
    }

    public class Lizard : ILizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return "Crawling in the dirt with weight " + Age;
        }
    }

    public class Dragon : IBird, ILizard
    {
        private readonly Bird _bird = new Bird();
        private readonly Lizard _lizard = new Lizard();
        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                _lizard.Age = value;
                _bird.Age = value;
            }
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }

        public string Fly()
        {
            return _bird.Fly();
        }
    }
}