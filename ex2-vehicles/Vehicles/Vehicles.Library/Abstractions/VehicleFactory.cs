namespace Vehicles.Library.Abstractions
{
    public abstract class VehicleFactory<T> 
        where T : new()
    {
        private static T _vehicle;
        private static readonly object _padlock = new object();

        static VehicleFactory()
        {
        }

        public static T Instance
        {
            get
            {
                if (_vehicle == null)
                {
                    lock (_padlock)
                    {
                        if (_vehicle == null)
                        {
                            _vehicle = new T();
                        }
                    }
                }

                return _vehicle;
            }
        }
    }
}
