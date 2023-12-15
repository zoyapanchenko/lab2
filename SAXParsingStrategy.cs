using System.Xml;

namespace Lab2
{
    class SAXParsingStrategy : IXmlParserStrategy
    {
        private List<Actor> lastResult = null;

        public List<Actor> Analyze(Actor actor, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Actor> result = new List<Actor>();
            Actor act = null;

            string _director = null;
            string _year = null;
            string _movie = null;

            while (reader.Read())
            {
                if (reader.Name == "director")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "name")
                        {
                            _director = reader.Value;
                        }
                    }
                }
                if (reader.Name == "year")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "name")
                        {
                            _year = reader.Value;
                        }
                    }
                }
                if (reader.Name == "movie")
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "name")
                        {
                            _movie = reader.Value;
                        }
                    }
                }
                if (reader.Name == "actor")
                {
                    if (act == null)
                    {
                        act = new Actor();
                        act.Director = _director;
                        act.Year = _year;
                        act.Movie = _movie;
                    }
                    else
                    {
                        act = new Actor();
                        act.Director = _director;
                        act.Year = _year;
                        act.Movie = _movie;
                    }

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "name")
                            {
                                act.Name = reader.Value;
                            }
                            if (reader.Name == "screentime")
                            {
                                act.Screentime = reader.Value;
                            }
                        }
                    }
                    result.Add(act);
                }
            }

            lastResult = Filter(result, actor);
            return lastResult;
        }

        public List<Actor> Filter(List<Actor> allActors, Actor param)
        {
            List<Actor> result = new List<Actor>();

            if (allActors != null)
            {
                foreach (Actor e in allActors)
                {
                    try
                    {
                        int screentime = int.Parse(e.Screentime);

                        if (
                            (e.Director == param.Director || param.Director == null) &&
                            (e.Year == param.Year || param.Year == null) &&
                            (e.Movie == param.Movie || param.Movie == null) &&
                            (e.Name == param.Name || param.Name == null) &&
                            (e.Screentime == param.Screentime || param.Screentime == null) &&
                            (param.MinScreentime == -1 || screentime >= param.MinScreentime) &&
                            (param.MaxScreentime == 201 || screentime <= param.MaxScreentime)
                            )
                        {
                            result.Add(e);
                        }
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}
