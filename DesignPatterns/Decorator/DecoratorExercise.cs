using System.Runtime.CompilerServices;

namespace DesignPatterns.Decorator
{
    public class ExerciseBird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class ExerciseLizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class ExerciseDragon // no need for interfaces
    {
        private readonly ExerciseBird _bird = new ExerciseBird();
        private readonly ExerciseLizard _lizard = new ExerciseLizard();
        private int _age;

        public int Age
        {
            get => _age;
            set => _age = _bird.Age = _lizard.Age = value;
        }

        public string Fly()
        {
            return _bird.Fly();
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }
    }
}