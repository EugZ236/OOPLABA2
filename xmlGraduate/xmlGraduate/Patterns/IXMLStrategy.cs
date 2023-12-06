using xmlGraduate.Models;

namespace xmlGraduate.Patterns
{
    public interface IXMLStrategy
    {
        List<Graduate> Analyze(string filePath);
    }
}
