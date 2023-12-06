using System.Xml;
using xmlGraduate.Models;

namespace xmlGraduate.Patterns
{
    public class DOMStrategy : IXMLStrategy
    {
        public List<Graduate> Analyze(string filePath)
        {
            var graduates = new List<Graduate>();

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            foreach (XmlNode GraduateNode in xmlDoc.SelectNodes("//Graduate"))
            {
                var graduate = new Graduate();

                foreach (XmlNode propertyNode in GraduateNode.ChildNodes)
                {
                    switch (propertyNode.Name)
                    {
                        case "Id":
                            graduate.Id = int.Parse(propertyNode.InnerText);
                            break;
                        case "Name":
                            graduate.Name = propertyNode.InnerText;
                            break;
                        case "FaculcyName":
                            graduate.FaculcyName = propertyNode.InnerText;
                            break;
                        case "Departament":
                            graduate.Departament = propertyNode.InnerText;
                            break;
                        case "Occupation":
                            graduate.Occupation = propertyNode.InnerText;
                            break;
                            break;
                        case "EnterDate":
                            graduate.EnterDate = DateTime.Parse(propertyNode.InnerText);
                            break;
                        case "EndDate":
                            graduate.EndDate = DateTime.Parse(propertyNode.InnerText);
                            break;
                    }
                }

                graduates.Add(graduate);
            }

            return graduates;
        }
    }
}
