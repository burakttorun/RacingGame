using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Resharper disable all
namespace RacingGame.Vehicle
{
    public interface IVehicle
    {
       public void Move();
       public void Turn();
       public void WheelAnimation();
    }
}
