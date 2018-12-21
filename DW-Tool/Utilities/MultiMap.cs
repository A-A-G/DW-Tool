namespace DW.Utilities
{
    public class MultiMap<KeyTyp, ValueTyp>
    {
        private System.Collections.Generic.Dictionary<KeyTyp, System.Collections.Generic.List<ValueTyp>> _map = new System.Collections.Generic.Dictionary<KeyTyp, System.Collections.Generic.List<ValueTyp>>();

        public System.Collections.Generic.Dictionary<KeyTyp, System.Collections.Generic.List<ValueTyp>> Data
        {
            get
            {
                return _map;
            }
        }

        public int KeyCount
        {
            get
            {
                return _map.Keys.Count;
            }
        }

        public int ValueCount
        {
            get
            {
                int number = 0;
                foreach (System.Collections.Generic.List<ValueTyp> list in _map.Values)
                    number = number + list.Count;
                return number;
            }
        }

        public bool TryGetValue(KeyTyp key, out System.Collections.Generic.List<ValueTyp> Values)
        {
            return _map.TryGetValue(key, out Values);
        }

        public System.Collections.Generic.Dictionary<KeyTyp, System.Collections.Generic.List<ValueTyp>>.KeyCollection Keys
        {
            get
            {
                return _map.Keys;
            }
        }

        public System.Collections.Generic.Dictionary<KeyTyp, System.Collections.Generic.List<ValueTyp>>.ValueCollection Values
        {
            get
            {
                return _map.Values;
            }
        }

        public void Add(KeyTyp key, ValueTyp value)
        {
            if (_map.ContainsKey(key))
            {
                System.Collections.Generic.List<ValueTyp> list = new System.Collections.Generic.List<ValueTyp>();
                _map.TryGetValue(key, out list);
                list.Add(value);
                _map.Remove(key);
                _map.Add(key, list);
            }
            else
            {
                System.Collections.Generic.List<ValueTyp> list = new System.Collections.Generic.List<ValueTyp>();
                list.Add(value);
                _map.Add(key, list);
            }
        }

        public void clear()
        {
            _map.Clear();
        }

        public bool ContainsKey(KeyTyp key)
        {
            return _map.ContainsKey(key);
        }

        public bool ContainsValue(ValueTyp value)
        {
            foreach (System.Collections.Generic.List<ValueTyp> list in _map.Values)
            {
                if (list.Contains(value))
                    return true;
            }
            return false;
        }

        public void Remove(ValueTyp value)
        {
            foreach (System.Collections.Generic.List<ValueTyp> list in _map.Values)
            {
                if (list.Contains(value))
                {
                    list.Remove(value);
                    return;
                }
            }
        }

        public void RemoveAll(ValueTyp value)
        {
            foreach (System.Collections.Generic.List<ValueTyp> list in _map.Values)
            {
                while (list.Contains(value))
                    list.Remove(value);
            }
        }

    }
}
