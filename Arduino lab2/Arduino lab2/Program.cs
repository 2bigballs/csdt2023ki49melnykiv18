using System.IO.Ports;

SerialPort serialPort = new SerialPort("COM5", 9600);
serialPort.Open();
var number1 = Console.ReadLine();
var number2 = Console.ReadLine();

await Task.Delay(1000);


serialPort.DataReceived += (sender, e) =>
{
    if (sender is SerialPort sender1)
    {
        Console.WriteLine($"sender: {sender1.ReadExisting()}");
    }
};

serialPort.Write(number1);
await Task.Delay(1000);
serialPort.Write(number2);
await Task.Delay(1000);

await Task.Delay(60000);