using System.IO.Ports;

SerialPort serialPort = new SerialPort("COM6", 9600);
serialPort.Open();
Console.WriteLine("Enter first numbers:");
var number1 = Console.ReadLine();
Console.WriteLine("Enter second numbers:");
var number2 = Console.ReadLine();

await Task.Delay(1000);


serialPort.DataReceived += (sender, e) =>
{
    if (sender is SerialPort sender1)
    {
        Console.WriteLine($"Sum: {sender1.ReadExisting()}");
    }
};

serialPort.Write(number1);
await Task.Delay(1000);
serialPort.Write(number2);
await Task.Delay(1000);


await Task.Delay(20000);

serialPort.Close();