namespace TestProject1;

public class MumblingUsings
{
    public static string Mumbling(string input)
    {
        var charArray = input.ToLower()
            .Replace(" ", "")
            .Where(x => !char.IsNumber(x)).Select(x => x)
            .ToArray();
        var result = new List<string>();
        for (var index = 0; index < charArray.Length; index++)
        {
            var t = charArray[index];
            var duplicates = new string(t, index);
            result.Add(t.ToString().ToUpper() + duplicates);
        }

        return string.Join("-", result);
    }

    #region Person

    public record Person(string name, int age);

    public static List<Person> FilterAge(List<Person> employees)
    {
        return employees
            .Where(person => person.age >= 18)
            .OrderByDescending(person => person.name)
            .Select(person => person with {name = person.name.ToUpperInvariant()})
            .ToList();
    }

    #endregion
}