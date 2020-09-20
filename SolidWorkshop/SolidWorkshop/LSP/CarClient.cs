namespace SolidWorkshop.LSP
{
    using NonComplaint;

    public class CarClient
    {
        public void Run()
        {
            Car myCar = new Car();
            TestDrive(myCar);

            ElectricCar autoCar = new ElectricCar();
            TestDrive(autoCar);
        }

        private void TestDrive(Car car)
        {

            // start the car
            car.StartEngine();

            // drive
            car.Drive();

            // speed up
            car.Speed = 20;
            car.ShiftUp();

            // stop
            car.Stop();

            // reverse
            car.Reverse();
            car.Speed = 5;
            
            // stop
            car.Stop();
        }
    }
}