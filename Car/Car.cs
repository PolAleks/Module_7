using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car<TEngine>
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart part) { }
    }

    /// <summary>
    /// Электрический двигатель
    /// </summary>
    class ElectricEngine
    {

    }
    /// <summary>
    /// Бензиновый двигатель
    /// </summary>
    class GasEngine
    {
        
    }
    /// <summary>
    /// часть авто - аккумулятор
    /// </summary>
    class Battery
    {

    }
    /// <summary>
    /// часть авто - диференциал
    /// </summary>
    class Differential
    {

    }
    /// <summary>
    /// часть авто - колесо
    /// </summary>
    class Wheel
    {

    }
}
