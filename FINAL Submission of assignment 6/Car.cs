using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_Submission_of_assignment_6
{ /// <summary>
  /// car extends the Vehicle class
  /// </summary>
    internal class Car : Vehicle
    {
        /****** constructors section *****/
        // by default, a class has a default constructor that does not take any parameters
        // therefore, you do not have to explicitly create one

        /***** methods section *******/
        /// <summary> Overrides the base Vehicles definition for GetInfo ()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I dont want to disclose my information.");

        }
    }
}
