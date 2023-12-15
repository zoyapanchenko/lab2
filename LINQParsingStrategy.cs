using System.Xml.Linq;

namespace Lab2
{
    class LINQParsingStrategy : IXmlParserStrategy
    {
        List<Actor> info = new List<Actor>();
        XDocument doc = new XDocument();

        public List<Actor> Analyze(Actor actor, string path)
        {
            doc = XDocument.Load(path);
            List<XElement> match = (from val in doc.Descendants("actor")
                                    let screentime = int.Parse(val.Attribute("screentime").Value)
                                    where
                                    (
                                        (actor.Director == null || actor.Director == val.Parent.Parent.Parent.Attribute("name").Value) &&
                                        (actor.Year == null || actor.Year == val.Parent.Parent.Attribute("name").Value) &&
                                        (actor.Movie == null || actor.Movie == val.Parent.Attribute("name").Value) &&
                                        (actor.Name == null || actor.Name == val.Attribute("name").Value) &&
                                        (actor.Screentime == null || actor.Screentime == val.Attribute("screentime").Value) &&
                                        (actor.MinScreentime == -1 || screentime >= actor.MinScreentime) &&
                                        (actor.MaxScreentime == 201 || screentime <= actor.MaxScreentime)
                                    )
                                    select val).ToList();

            foreach (XElement obj in match)
            {
                Actor act = new Actor();
                act.Director = obj.Parent.Parent.Parent.Attribute("name").Value;
                act.Year = obj.Parent.Parent.Attribute("name").Value;
                act.Movie = obj.Parent.Attribute("name").Value;
                act.Name = obj.Attribute("name").Value;
                act.Screentime = obj.Attribute("screentime").Value;
                info.Add(act);
            }

            return info;
        }
    }
}
