class Program
{
    static void Main(string[] args)
    {
        Network network = new Network();

        Server server = new Server { IPAddress = "192.168.1.1", Power = 500, OperatingSystem = "Windows", ServerName = "Сервер 1" };
        Workstation workstation = new Workstation { IPAddress = "192.168.1.2", Power = 200, OperatingSystem = "Linux", WorkstationName = "ПК 1" };
        Router router = new Router { IPAddress = "192.168.1.3", Power = 100, OperatingSystem = "RouterOS", RouterName = "Маршрутизатор 1" };

        network.SimulateInteraction(server, workstation);
        network.SimulateInteraction(workstation, router);
    }
}