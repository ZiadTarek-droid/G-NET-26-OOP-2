using System.ComponentModel;
using System.IO;
using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a) Two problems with this design(Encapsulation issues):

            //Public fields(Owner, Balance)

            //Anyone can directly modify them.

            //Example: account.Balance = -100000; → Invalid state.

            //No validation in Withdraw

            //It allows withdrawing more than the balance.

            //It allows negative values.

            //b) How to fix it(Encapsulation improvement):

            //Make fields private.

            //Use public properties with validation.

            //Add validation inside Withdraw().

            //Example concept:

            //Owner → Property with validation(not null/empty).

            //Balance → Read-only property.

            //Withdraw() → Check:

            //amount > 0

            //amount ≤ Balance

            //c) Why exposing fields directly is bad practice?

            //Because:

            //It breaks encapsulation.

            //No validation control.

            //Internal data can be corrupted.

            //You cannot add logic later without breaking existing code.

            //Encapsulation protects object integrity.
            #endregion
            #region Q2
    //        Difference between Field and Property in C#
    //                    Field                                    Property
    //            Variable inside class               Controlled access to a field
    //                Usually private                         Usually public
    //             No validation logic                     Can contain validation

    //            Can a property contain logic?

    //                     Yes.



    //private double price;

    //    public double PriceAfterTax
    //    {
    //        get
    //        {
    //            return price * 1.14;
    //        }
    //    }

    //    It calculates the value instead of storing it.
            #endregion
        }
    }
}
