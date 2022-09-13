namespace WebApplication2.Models
{
    public partial class BuilderForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Option { get; set; }
        public bool? Required { get; set; }
        public string? Label { get; set; }
        public string? HelpText { get; set; }
        public string? Buttion { get; set; }
        public string? Type { get; set; }
        public string? Class { get; set; }
    }

    public class controller 
    {   
        public int Id { get; set; }
        public string type { get; set; }
        public int key { get; set; }
    }

    public class Autocomplete 
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Option { get; set; }
        public string? HelpText { get; set; }
        public string? Label { get; set; }
        public string? PlaceHolder { get; set; }
        public string? Class { get; set; }
        public string? Access { get; set; }
    }
    public class Button 
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }
        public string? Label { get; set; }
        public string? Style { get; set; }
        public string? Class { get; set; }
        public int? Access { get; set; }
    }

    public class Checkbox 
    {
        public string Id { get; set; }
        public bool? Required { get; set; }
        public string? HelpText { get; set; }
        public bool? Toggle { get; set; }
        public bool? Inline { get; set; }
        public string? Class { get; set; }
        public int? Access { get; set; }
        public string? Name { get; set; }
        public bool? Other { get; set; }
    }

}

