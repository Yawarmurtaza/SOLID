namespace SolidWorkshop.LSP.Complaint
{
    using System;

    public abstract class BaseCar
    {
        protected bool engineRunning;
        private int currentSpeed;
        private CarState state;

        public virtual void StartEngine()
        {
            engineRunning = true;
            Console.WriteLine($"Car type = {GetType().Name}, Engine Started!");
        }

        public virtual void StopEngine()
        {
            engineRunning = false;
            Console.WriteLine($"Car type = {GetType().Name}, Engine Stopped!");
        }

        public int Speed
        {
            get
            {
                if (engineRunning) { return currentSpeed; }
                else { return 0; }
            }
            set
            {
                if (engineRunning)
                {
                    currentSpeed = value;
                }
            }
        }

        public virtual void Drive()
        {
            if (!engineRunning)
            {
                StartEngine();
            }

            state = CarState.Forward;
            Console.WriteLine($"Car type = {GetType().Name}, State = Drive");
        }

        public virtual void Reverse()
        {
            if (!engineRunning)
            {
                StartEngine();
            }

            state = CarState.Reverse;
            Console.WriteLine($"Car type = {GetType().Name}, State = Reverse");
        }

        public virtual void Stop()
        {
            state = CarState.Stopped;
            Console.WriteLine($"Car type = {GetType().Name}, State = Stopped");
        }

        public CarState State
        {
            get { return state; }
        }
    }

    public class ManualCar : BaseCar
    {
        private int currentGearLevel;


        public virtual void ShiftUp()
        {
            if (engineRunning)
            {
                currentGearLevel++;
                Console.WriteLine($"Car type = {GetType().Name}, Shift Up - {GearLevel}");
            }
        }

        public virtual void ShiftDown()
        {
            if (engineRunning)
            {
                currentGearLevel--;
                Console.WriteLine($"Car type = {GetType().Name}, Shift Down - {GearLevel}");
            }
        }
        public virtual int GearLevel
        {
            get { return currentGearLevel; }
        }
    }

    public class ElectricCar : BaseCar
    {
        private int batteryLife;

        public int BatteryLife
        {
            get { return batteryLife; }
        }

        public override void StartEngine()
        {
            if (batteryLife > 1)
            {
                base.StartEngine();
            }
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
    }


    public enum CarState
    {
        Stopped,
        Forward,
        Reverse
    }
}