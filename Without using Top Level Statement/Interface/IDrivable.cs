using System;

namespace part11
{
    interface IDrivable
   {
     int Wheels { get; set; }
     double Speed { get; set;}

     void Move();
     void Stop();


     
   } 
}