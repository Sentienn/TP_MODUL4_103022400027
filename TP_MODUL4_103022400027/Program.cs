using System;

class Program
{
    static void Main(string[] args)
    {
        string kelurahan = "Batununggal";

        string kodePos = KodePos.getKodePos(kelurahan);

        Console.WriteLine("Kelurahan : " + kelurahan);
        Console.WriteLine("Kode Pos  : " + kodePos);

        DoorMachine pintu = new DoorMachine();
        pintu.Toggle();
        pintu.Toggle();
        pintu.Toggle();
    }
}