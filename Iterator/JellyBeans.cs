using System.Collections;

namespace Iterator
{
    /// <summary>
    ///     Our collection item.  Mostly because I'm a sucker for jelly beans.
    /// </summary>
    internal class JellyBean
    {
        // Constructor
        public JellyBean(string flavor)
        {
            Flavor = flavor;
        }

        public string Flavor { get; }
    }

    /// <summary>
    ///     The aggregate interface
    /// </summary>
    internal interface ICandyCollection
    {
        JellyBeanIterator CreateIterator();
    }

    /// <summary>
    ///     The concrete aggregate class
    /// </summary>
    internal class JellyBeanCollection : ICandyCollection
    {
        private readonly ArrayList _items = new();

        // Gets jelly bean count
        public int Count => _items.Count;

        // Indexer
        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }
    }

    /// <summary>
    ///     The 'Iterator' interface
    /// </summary>
    internal interface IJellyBeanIterator
    {
        JellyBean CurrentBean { get; }
        bool IsDone { get; }
        JellyBean First();
        JellyBean Next();
    }

    /// <summary>
    ///     The 'ConcreteIterator' class
    /// </summary>
    internal class JellyBeanIterator : IJellyBeanIterator
    {
        private int _current;
        private readonly JellyBeanCollection _jellyBeans;
        private readonly int _step = 1;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            _jellyBeans = beans;
        }

        // Gets first jelly bean
        public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        // Gets next jelly bean
        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current] as JellyBean;
            return null;
        }

        // Gets current iterator candy
        public JellyBean CurrentBean => _jellyBeans[_current] as JellyBean;

        // Gets whether iteration is complete
        public bool IsDone => _current >= _jellyBeans.Count;
    }
}