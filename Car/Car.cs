using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart part) where TPart : CarPart { }
    }
    abstract class Engine { }
    abstract class CarPart { }

    /// <summary>
    /// Электрический двигатель
    /// </summary>
    class ElectricEngine : Engine { }
    /// <summary>
    /// Бензиновый двигатель
    /// </summary>
    class GasEngine : Engine { }
    /// <summary>
    /// часть авто - аккумулятор
    /// </summary>
    class Battery : CarPart { }
    /// <summary>
    /// часть авто - диференциал
    /// </summary>
    class Differential : CarPart { }
    /// <summary>
    /// часть авто - колесо
    /// </summary>
    class Wheel : CarPart { }
}
