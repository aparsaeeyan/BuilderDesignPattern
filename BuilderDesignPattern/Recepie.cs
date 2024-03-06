﻿using BuilderDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    // The Concrete Builder(Recepie) classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class Recepie : IRecepie
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public Recepie()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        public void TakeBread()
        {
            this._product.Add("Take Bread");
        }

        public void AddMainFood(string mainFood)
        {
            this._product.Add($"Add {mainFood}");
        }
        public void AddTopping(string topping)
        {
            this._product.Add($"Add {topping}");
        }


        // Concrete Builders(Recepie) are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }

       
    }
}
