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
            // drive
            car.Drive();

            car.ShiftUp();

            car.ShiftDown();
            
            // reverse
            car.Reverse();
        }
    }
}