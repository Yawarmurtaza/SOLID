namespace SolidWorkshop.LSP.NonComplaint
{
    using System;

    public class Car
    {
        private int currentGearLevel;
        private bool engineRunning;
        private int currentSpeed;

        public void StartEngine()
        {
            engineRunning = true;
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

        public void SetSpeed(int speed)
        {

        }

        public virtual void ShiftUp()
        {
            if (engineRunning)
            {
                currentGearLevel++;
            }
        }

        public virtual void ShiftDown()
        {
            if (engineRunning)
            {
                currentGearLevel--;
            }
        }
        public virtual int GearLevel
        {
            get { return currentGearLevel; }
        }
    }

    public class AutometicCar : Car
    {
        public override void ShiftDown()
        {
            throw new NotImplementedException();
        }

        public override void ShiftUp()
        {
            throw new NotImplementedException();
        }

        public override int GearLevel
        {
            get { throw new NotImplementedException(); }
        }
    }

}