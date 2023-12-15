using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2
{
    class Transformator
    {
        public void Transform(List<Actor> filteredActors, string xmlPath, string xslPath, string htmlPath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xslPath);

            XDocument inputDataXml;

            if (filteredActors != null && filteredActors.Count > 0)
            {
                var groupedActors = filteredActors.GroupBy(a => new { a.Director, a.Year, a.Movie });

                inputDataXml = new XDocument(
                    new XElement("cinema",
                        from directorGroup in groupedActors.GroupBy(g => g.Key.Director)
                        select new XElement("director",
                            new XAttribute("name", directorGroup.Key),
                            from yearGroup in directorGroup.GroupBy(g => g.Key.Year)
                            select new XElement("year",
                                new XAttribute("name", yearGroup.Key),
                                from movieGroup in yearGroup.GroupBy(g => g.Key.Movie)
                                select new XElement("movie",
                                    new XAttribute("name", movieGroup.Key),
                                    from actor in movieGroup.SelectMany(ag => ag)
                                    select new XElement("actor",
                                        new XAttribute("name", actor.Name),
                                        new XAttribute("screentime", actor.Screentime)
                                    )
                                )
                            )
                        )
                    )
                );
            }
            else
            {
                using (FileStream fileStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    inputDataXml = XDocument.Load(fileStream);
                }
            }

            using (XmlWriter writer = XmlWriter.Create(htmlPath))
            {
                xslt.Transform(inputDataXml.CreateReader(), null, writer);
            }

            MessageBox.Show("Трансформація успішно виконана!", "Успіх!");
        }
    }
}

