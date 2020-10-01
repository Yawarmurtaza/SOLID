namespace SolidWorkshop.LSP.NonComplaint
{
    using System;

    public class Car
    {
        private int currentGearLevel;

        public virtual void Drive()
        {
            Console.WriteLine($"Car type = {GetType().Name}, State = Drive");
        }

        public virtual void Reverse()
        {
            Console.WriteLine($"Car type = {GetType().Name}, State = Reverse");
        }

        public virtual void ShiftUp()
        {
            currentGearLevel++;
            Console.WriteLine($"Car type = {GetType().Name}, Shift Up.");
        }

        public virtual void ShiftDown()
        {

            currentGearLevel--;
            Console.WriteLine($"Car type = {GetType().Name}, Shift Down.");

        }
    }


    public class ElectricCar : Car
    {
        private int batteryLife;

        public ElectricCar()
        {
            batteryLife = 10;
        }

        public int BatteryLife
        {
            get { return batteryLife; }
        }

        public void ChargeBattery()
        {
            batteryLife++;
        }

        public override void Drive()
        {
            batteryLife--;
            base.Drive();
        }

        public override void Reverse()
        {
            batteryLife--;
            base.Reverse();
        }

        public override void ShiftDown()
        {
            throw new NotImplementedException();
        }

        public override void ShiftUp()
        {
            throw new NotImplementedException();
        }
    }
}