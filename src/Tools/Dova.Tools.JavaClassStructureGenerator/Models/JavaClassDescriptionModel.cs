namespace Dova.Tools.JavaClassStructureGenerator.Models;

internal class JavaClassDescriptionModel
{
    public string Type { get; set; }
    public string ParentClass { get; set; }
    public IEnumerable<string> Interfaces { get; set; }
}