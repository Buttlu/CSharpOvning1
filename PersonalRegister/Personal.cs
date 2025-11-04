namespace PersonalRegister
{
    internal class Personal
    {
        private readonly string id = Guid.NewGuid().ToString();
        private string förNamn;
        private string efterNamn;
        private int lön;

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
    }
}
