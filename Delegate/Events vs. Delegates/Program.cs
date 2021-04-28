using System;

class TrainSignal
{
    public event Action TrainComming;
    public void HereComesATrain()
    {
        if(TrainComming != null)
           TrainComming.Invoke();
    }
}
class Car
{
    public Car(TrainSignal trainSignal)
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
        trainSignal.TrainComming();
        trainSignal.TrainComming();
        trainSignal.TrainComming = null;
        Console.WriteLine("-");
        trainSignal.HereComesATrain();
        
    }
}

