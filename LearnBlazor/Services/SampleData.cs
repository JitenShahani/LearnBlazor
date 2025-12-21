namespace LearnBlazor.Services;

public class SampleData : ISampleData
{
    public int Value1 { get; set; }
    public int Value2 { get; set; }

    public SampleData ()
        => (Value1, Value2) = (Random.Shared.Next (1, 1001), Random.Shared.Next (1, 1001));
}