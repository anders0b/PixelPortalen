namespace PixelPortalen.Domain.Entities;

public class SwishEntity
{
    public string format { get; set; } = "svg";
    public Payee payee { get; set; }
    public Amount amount { get; set; }
    public Message message { get; set; }
    public bool transparent = true;
    public int size { get; set; } = 300;
}

public class Payee
{
    public string value { get; set; } = "0768694290";
    public bool editable { get; set; } = false;
}

public class Amount
{
    public int value { get; set; } = 1;
    public bool editable { get; set; } = false;
}

public class Message
{
    public string value { get; set; } = "(PixelPortalen) - gött häng o spel!";
    public bool editable { get; set; } = false;
}
