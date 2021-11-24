namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            var informator = new Informator();

            informator.InformsAboutObjects();

            while (true)
            {
                menu.StartMenu();
            }
        }
    }
}
