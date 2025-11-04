namespace PersonalRegister;
internal class Personal
{
    private readonly string id = Guid.NewGuid().ToString();
    private string förNamn;
    private string efterNamn;
    private int lön;

    public string Id { get { return id; } }
    public string FörNamn { get { return förNamn; } set { förNamn = value; } }
    public string EfterNamn { get { return efterNamn; } set { efterNamn = value; } }
    public int Lön { get { return lön; } }

    public Personal(string förNamn, string efterNamn, int lön)
    {
        this.förNamn = förNamn;
        this.efterNamn = efterNamn;
        this.lön = lön;
    }

    public void SkrivPersonalInfo()
    {
        Console.WriteLine($"\nInfo för anställd {id}" +
            $"\nNamn: {förNamn} {efterNamn}" +
            $"\nLön: {lön} kr"
        );
    }

    public void SättLön(int lön)
    {
        // plats för extra logik som kan behövas i framtiden, t.ex.
        // kolla att den som ändrar har tillåtelse
        this.lön = lön;
    }
}