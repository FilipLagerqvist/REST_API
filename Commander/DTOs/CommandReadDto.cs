namespace Commander.DTOs;

public class CommandReadDto
{
    public int Id { get; set; }
    public string HowTo { get; set; } = string.Empty;
    public string Line { get; set; } = string.Empty;
}