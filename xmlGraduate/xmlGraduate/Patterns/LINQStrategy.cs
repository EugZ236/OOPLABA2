using System.Xml.Linq;
using xmlGraduate.Models;

namespace xmlGraduate.Patterns
{
    public class LINQStrategy : IXMLStrategy
    {
        public List<Graduate> Analyze(string filePath)
        {
            var xmlDoc = XDocument.Load(filePath);

            var graduates = xmlDoc.Root.Elements("Graduate")
                .Select(GraduateElement => new Graduate
                {
                    Id = int.Parse(GraduateElement.Element("Id").Value),
                    Name = GraduateElement.Element("Name").Value,
                    FaculcyName = GraduateElement.Element("FaculcyName").Value,
                    Departament = GraduateElement.Element("Departament").Value,
                    Occupation = GraduateElement.Element("Occupation").Value,
                    EnterDate = DateTime.Parse(GraduateElement.Element("EnterDate").Value),
                    EndDate = DateTime.Parse(GraduateElement.Element("EndDate").Value)
                })
                .ToList();

            return graduates;
        }
    }
}
