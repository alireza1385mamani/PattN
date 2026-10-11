namespace ServiceLib.Models.Dto;

public class ComboItem
{
    public string? ID
    {
        get; set;
    }

    public string? Text
    {
        get; set;
    }

    public override string ToString() => Text ?? string.Empty;
}
