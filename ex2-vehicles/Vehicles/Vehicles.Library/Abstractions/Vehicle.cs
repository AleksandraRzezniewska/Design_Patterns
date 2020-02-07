using System;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Abstractions
{
    public abstract class Vehicle : IDecorator
    {
        public int ProductionYear { get; set; }
        public string Brand { get; set; }
        public int KerbWeight { get; set; }
        public Guid Id { get; set; }
        public int MaxVelocity { get; set; }
        public Color Color { get; set; }

        public virtual int Weapon()
        {
            return 0;
        }
        public virtual int Shield()
        {
            return 0;
        }
            
        private IMoveStrategy _move;

        public T ChangeMoveStrategy<T>(T strategy) where T : IMoveStrategy
        {
            _move = strategy;
            return (T) _move;
        }

        private IPaintStrategy _paint;

        public void SetPaint<T>(T paint) where T : IPaintStrategy
        {
            _paint = paint;
        }
    }
}
