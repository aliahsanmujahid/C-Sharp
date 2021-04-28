using System;

class TrainSignal
{
    public Action TrainComming;
    public void HereComesATrain()
    {
        TrainComming();
    }
}
class Car
{
    public  Car(TrainSignal trainSignal)
    {
        trainSignal.TrainComming += StopTheCar;
    }
    void StopTheCar()
    {
        Console.WriteLine("Screeth");
    }
}
class Program
    {
        static void Main()
        {
        TrainSignal trainSignal = new TrainSignal();
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        trainSignal.HereComesATrain();
    }
    }

