using BuilderDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    // The Director(SandwichMaker) is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class SandwichMaker
    {
        private IRecepie _builder;

        public IRecepie Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void MakeFalafel()
        {
            this._builder.TakeBread();
            this._builder.AddMainFood("Falafel");
            this._builder.AddTopping("Tomato");
            this._builder.AddTopping("Pickle");
            this._builder.AddTopping("Lettuce");
        }
        public void MakeFalafelWithSalad()
        {
            this._builder.TakeBread();
            this._builder.AddMainFood("Falafel");
            this._builder.AddTopping("Salad");
        }
        public void MakeHamburger()
        {
            this._builder.TakeBread();
            this._builder.AddMainFood("Hamburger");
            this._builder.AddTopping("Tomato");
            this._builder.AddTopping("Pickle");
            this._builder.AddTopping("Lettuce");
            this._builder.AddTopping("Cheese");
        }

    }
}
