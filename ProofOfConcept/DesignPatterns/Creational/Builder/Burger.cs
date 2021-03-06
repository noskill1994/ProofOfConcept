﻿namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    abstract public class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}