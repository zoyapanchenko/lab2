namespace Lab2
{
    class Actor
    {
        public string Director = null;
        public string Year = null;
        public string Movie = null;
        public string Name = null;
        public string Screentime = null;
        public string Course = null;
        public int MinScreentime { get; set; } = -1;
        public int MaxScreentime { get; set; } = 201;

        public int MinCourse { get; set; } = -1;
        public int MaxCourse { get; set; } = 7;


        public Actor() { }

        public Actor(string[] data)
        {
            Director = data[0];
            Year = data[1];
            Movie = data[2];
            Name = data[3];
            Screentime = data[4];
        }

        public Actor(IXmlParserStrategy strategy)
        {
            Director = String.Empty;
            Year = String.Empty;
            Movie = String.Empty;
            Name = String.Empty;
            Screentime = String.Empty;
        }

        public bool Compare(Actor actor)
        {
            return Director == actor.Director &&
               Year == actor.Year &&
               Movie == actor.Movie &&
               Name == actor.Name &&
               Screentime == actor.Screentime;
        }

        public IXmlParserStrategy Strategy { get; set; }
        public List<Actor> Analyze(Actor parameters, string path)
        {
            return Strategy.Analyze(parameters, path);
        }
    }

    interface IXmlParserStrategy
    {
        List<Actor> Analyze(Actor p, string path);
    }
}
