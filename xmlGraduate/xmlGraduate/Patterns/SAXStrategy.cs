using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using xmlGraduate.Models;

namespace xmlGraduate.Patterns
{
    public class SAXStrategy : IXMLStrategy
    {
        public List<Graduate> Analyze(string filePath)
        {
            var graduates = new List<Graduate>();

            using (var reader = XmlReader.Create(filePath))
            {
                Graduate currentGraduate = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "Graduate":
                                currentGraduate = new Graduate();
                                break;
                            case "Id":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.Id = int.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            case "Name":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.Name = reader.ReadElementContentAsString();
                                }
                                break;
                            case "FaculcyName":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.FaculcyName = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Departament":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.Departament = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Occupation":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.Occupation = reader.ReadElementContentAsString();
                                }
                                break;
                            case "EnterDate":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.EnterDate = DateTime.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            case "EndDate":
                                if (currentGraduate != null)
                                {
                                    currentGraduate.EndDate = DateTime.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Graduate")
                    {
                        graduates.Add(currentGraduate);
                        currentGraduate = null;
                    }
                }
            }

            return graduates;
        }
    }
}
