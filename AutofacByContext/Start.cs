using System;

namespace AutofacByContext
{
    //      BAD SOLUTION
    //  interface IVehicle
    //  {
    //      /// <summary>
    //      /// Start Method which start the vehicle.
    //      /// </summary>
    //      /// <param name="keyType">key - card - so on</param>
    //      void Start(string keyType);

    //      /// <summary>
    //      /// Start Method which stop the vehicle.
    //      /// </summary>
    //      /// <param name="keyType">key - card - so on</param>
    //      void Stop(string keyType);
    //  }

    //  class FourWheel : IVehicle 
    //  {
    //      void Start(string keyType) { ... }
    //      void Stop(string keyType) { ... }
    //  }
    //  class TwoWheel : IVehicle
    //  {
    //      void Start(string keyType) { ... }
    //      void Stop(string keyType) { ... }
    //  }
    //      END BAD SOLUTION

    /// <summary>
    /// Vehicle Interface
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Start Method which start the vehicle.
        /// </summary>
        /// <param name="keyType">key - card - so on</param>
        public void Start(string keyType);

        /// <summary>
        /// Start Method which stop the vehicle.
        /// </summary>
        /// <param name="keyType">key - card - so on</param>
        public void Stop(string keyType);
    }

    /// <summary>
    /// IFourWheel interface which "implements" IVehicle interface
    /// </summary>
    public interface IFourWheel : IVehicle {    }

    /// <summary>
    /// ITwoWheel interface which "implements" IVehicle interface
    /// </summary>
    public interface ITwoWheel : IVehicle {    }

    /// <summary>
    /// Car Class
    /// </summary>
    public class Car : IFourWheel
    {
        public Car() { }

        public void Start(string keyType) { }

        public void Stop(string keyType) { }
    }

    /// <summary>
    /// MotorByke Class
    /// </summary>
    class MotorByke : ITwoWheel
    {
        public MotorByke() { }

        public void Start(string keyType) { }

        public void Stop(string keyType) { }
    }

    /// <summary>
    /// Class which only repair four wheels vehicles
    /// </summary>
    public class BigRepairShop
    {
        IFourWheel car;
        public BigRepairShop(IFourWheel _car)
        {
            this.car = _car;

            Console.WriteLine("Repairing cars ...");
        }
    }

    /// <summary>
    /// Class which only repair two wheels vehicles
    /// </summary>
    public class SmallRepairShop
    {
        ITwoWheel motorByke;

        public SmallRepairShop(ITwoWheel _motorByke)
        {
            this.motorByke = _motorByke;

            Console.WriteLine("Repairing motorBykes ...");
        }
    }

    /// <summary>
    /// Principal Program
    /// </summary>
    class Start
    {
        static void Main(string[] args)
        {
            SmallRepairShop smallShop = new SmallRepairShop(new MotorByke());

            BigRepairShop bigShop = new BigRepairShop(new Car());
        }
    }
}
