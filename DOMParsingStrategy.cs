using System.Xml;

namespace Lab2
{
    class DOMParsingStrategy : IXmlParserStrategy
        {
            XmlDocument doc = new XmlDocument();
            public List<Actor> Analyze(Actor actor, string path)
            {
                doc.Load(path);

                List<List<Actor>> info = new List<List<Actor>>();
                try
                {
                    if (actor.Director != null) info.Add(SearchByParam("director", "name", actor.Director, doc, 0));
                    if (actor.Year != null) info.Add(SearchByParam("year", "name", actor.Year, doc, 1));
                    if (actor.Movie != null) info.Add(SearchByParam("movie", "name", actor.Movie, doc, 2));
                    if (actor.Name != null) info.Add(SearchByParam("actor", "name", actor.Name, doc, 3));
                    if (actor.Screentime != null) info.Add(SearchByParam("actor", "screentime", actor.Screentime, doc, 3));

                    if (actor.Director == null &&
                        actor.Year == null &&
                        actor.Movie == null &&
                        actor.Name == null &&
                        actor.Screentime == null)
                    {
                        return ApplyScreentimeFilter(AllActors(doc), actor);
                    }
                }
                catch { }

                return ApplyScreentimeFilter(Cross(info, actor), actor);
            }

            private List<Actor> ApplyScreentimeFilter(List<Actor> actors, Actor actor)
            {
                if (actor.MinScreentime != -1 || actor.MaxScreentime != 201)
                {
                    return actors.Where(a =>
                    {
                        int screentime = int.Parse(a.Screentime);
                        return (actor.MinScreentime == -1 || screentime >= actor.MinScreentime) &&
                               (actor.MaxScreentime == 201 || screentime <= actor.MaxScreentime);
                    }).ToList();
                }

                return actors;
            }

            public static Actor Info(XmlNode node)
            {
                Actor nw = new Actor();
                nw.Director = node.ParentNode.ParentNode.ParentNode.Attributes.GetNamedItem("name").Value;
                nw.Year = node.ParentNode.ParentNode.Attributes.GetNamedItem("name").Value;
                nw.Movie = node.ParentNode.Attributes.GetNamedItem("name").Value;
                nw.Name = node.Attributes.GetNamedItem("name").Value;
                nw.Screentime = node.Attributes.GetNamedItem("screentime").Value;
                return nw;
            }

            public static List<Actor> AllActors(XmlNode doc)
            {
                List<Actor> data2 = new List<Actor>();
                XmlNodeList elem = doc.SelectNodes("//actor");
                try
                {
                    foreach (XmlNode el in elem)
                    {
                        data2.Add(Info(el));
                    }
                }
                catch { }
                return data2;
            }

            public static List<Actor> SearchByParam(string nodename, string val, string param, XmlDocument doc, int n)
            {
                List<Actor> actors = new List<Actor>();

                if (param != String.Empty && param != null)
                {
                    switch (n)
                    {
                        case 0:
                            {
                                XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                                try
                                {
                                    foreach (XmlNode e in elem)
                                    {
                                        XmlNodeList list1 = e.ChildNodes;
                                        foreach (XmlNode el1 in list1)
                                        {
                                            XmlNodeList list2 = el1.ChildNodes;
                                            foreach (XmlNode el2 in list2)
                                            {
                                                XmlNodeList list3 = el2.ChildNodes;
                                                foreach (XmlNode el3 in list3)
                                                {
                                                    actors.Add(Info(el3));
                                                }
                                            }
                                        }
                                    }
                                }
                                catch { }
                                return actors;
                            }

                        case 1:
                            {
                                XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                                try
                                {
                                    foreach (XmlNode e in elem)
                                    {
                                        XmlNodeList list1 = e.ChildNodes;
                                        foreach (XmlNode el1 in list1)
                                        {
                                            XmlNodeList list2 = el1.ChildNodes;
                                            foreach (XmlNode el2 in list2)
                                            {
                                                actors.Add(Info(el2));
                                            }
                                        }
                                    }
                                }
                                catch { }
                                return actors;
                            }

                        case 2:
                            {
                                XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                                try
                                {
                                    foreach (XmlNode e in elem)
                                    {
                                        XmlNodeList list1 = e.ChildNodes;
                                        foreach (XmlNode el1 in list1)
                                        {
                                            actors.Add(Info(el1));
                                        }
                                    }
                                }
                                catch { }
                                return actors;
                            }

                        case 3:
                            {
                                XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                                try
                                {
                                    foreach (XmlNode e in elem)
                                    {
                                        actors.Add(Info(e));
                                    }
                                }
                                catch { }
                                return actors;
                            }
                        default:
                            break;
                    }
                }
                return AllActors(doc);
            }

            private static List<Actor> Cross(List<List<Actor>> list, Actor actor)
            {
                List<Actor> result = new List<Actor>();
                try
                {
                    if (list != null)
                    {
                        Actor[] act = list[0].ToArray();
                        if (act != null)
                        {
                            foreach (Actor elem in act)
                            {
                                bool IsIn = false;
                                foreach (List<Actor> t in list)
                                {
                                    if (t.Count <= 0) return new List<Actor>();

                                    foreach (Actor a in t)
                                    {
                                        IsIn = false;
                                        if (elem.Compare(a))
                                        {
                                            IsIn = true;
                                            break;
                                        }
                                    }
                                    if (!IsIn) break;
                                }

                                int screentime = int.Parse(elem.Screentime);
                                if ((actor.MinScreentime == -1 || screentime >= actor.MinScreentime) &&
                                    (actor.MaxScreentime == 201 || screentime <= actor.MaxScreentime))
                                {
                                    if (IsIn) result.Add(elem);
                                }
                            }
                        }
                    }
                }
                catch { }
                return result;
            }
        }
    }
