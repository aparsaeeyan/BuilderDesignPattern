using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Interfaces
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IRecepie
    {
        void TakeBread();

        void AddMainFood(string mainFood);

        void AddTopping(string topping);

    }
}
