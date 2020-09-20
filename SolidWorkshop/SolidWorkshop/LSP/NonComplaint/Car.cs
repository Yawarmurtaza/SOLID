﻿namespace SolidWorkshop.LSP.NonComplaint
{
    using System;
    using System.CodeDom;

    public class Car
    {
        private int currentGearLevel;
        private bool engineRunning;
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

        public void Stop()
        {
            state = CarState.Stopped;
            Console.WriteLine($"Car type = {GetType().Name}, State = Stopped");
        }

        public CarState State
        {
            get { return state; }
        }

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

    public class ElectricCar : Car
    {
        private int batteryLife;

        public ElectricCar()
        {
            batteryLife = 10;
        }

        public override void StartEngine()
        {
            if (batteryLife > 1)
            {
                base.StartEngine();
            }
        }

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
    }

    public enum CarState
    {
        Stopped,
        Forward,
        Reverse
    }
}