using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine
{
    public class Context
    {
        private Dictionary<string, object> _map;

        public Context()
        {
            _map = new Dictionary<string, object>();
        }

        public object Get(string key)
        {
            return _map[key];
        }

        public bool Add(string key, object value)
        {
            return _map.TryAdd(key, value);
        }

    }
}
