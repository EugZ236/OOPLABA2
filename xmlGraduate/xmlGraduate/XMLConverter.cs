using System.Xml.Xsl;
using System.Xml;

namespace xmlGraduate
{
    public class XMLConverter
    {
        public void SaveInHTML(string xmlFilePaath, string xsltFilePath, string outputFilePath)
        {
            var xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            using (var writer = XmlWriter.Create(outputFilePath))
            {
                xslt.Transform(xmlFilePaath, writer);
            }
        }
    }
}
