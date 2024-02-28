using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_Submission_of_assignment_6
{
    /// <summary>
    /// Interfaces are contracts that the inheriting classs has to implement.
    /// Read
    /// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    internal interface IVehicle
    {
        /// <summary>
        /// this method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();
    }
}
