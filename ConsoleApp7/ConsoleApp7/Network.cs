using System;

class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }
}

class Server : Computer, IConnectable
{
    public string ServerName { get; set; }
    public void Connect()
    {
        Console.WriteLine($"Підключено до сервера {ServerName}");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Відключено від сервера {ServerName}");
    }

    public void SendData(string data)
    {
        Console.WriteLine($"Дані відправлено на сервер {ServerName}: {data}");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Дані отримано від сервера {ServerName}: {data}");
    }
}

class Workstation : Computer, IConnectable
{
    public string WorkstationName { get; set; }
    public void Connect()
    {
        Console.WriteLine($"Підключено до робочої станції {WorkstationName}");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Відключено від робочої станції {WorkstationName}");
    }

    public void SendData(string data)
    {
        Console.WriteLine($"Дані відправлено на робочу станцію {WorkstationName}: {data}");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Дані отримано від робочої станції {WorkstationName}: {data}");
    }
}

class Router : Computer, IConnectable
{
    public string RouterName { get; set; }
    public void Connect()
    {
        Console.WriteLine($"Підключено до маршрутизатора {RouterName}");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Відключено від маршрутизатора {RouterName}");
    }

    public void SendData(string data)
    {
        Console.WriteLine($"Дані відправлено на маршрутизатор {RouterName}: {data}");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Дані отримано від маршрутизатора {RouterName}: {data}");
    }
}

interface IConnectable
{
    void Connect();
    void Disconnect();
    void SendData(string data);
    void ReceiveData(string data);
}

class Network
{
    public void SimulateInteraction(IConnectable device1, IConnectable device2)
    {
        device1.Connect();
        device2.Connect();

        device1.SendData("Дані від джерела");
        device2.ReceiveData("Дані від джерела");

        device1.Disconnect();
        device2.Disconnect();
    }
}

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
