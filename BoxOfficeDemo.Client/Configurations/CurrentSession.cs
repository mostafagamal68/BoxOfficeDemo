using Microsoft.AspNetCore.Components;

namespace BoxOfficeDemo.Client.Configurations
{
    public class CurrentSession
    {
        public readonly Dictionary<string, object> _state = new();

        public void Set(ComponentBase source, string key, object value)
        {
            if (_state.ContainsKey(key))
                _state[key] = value;
            else
                _state.Add(key, value);
            NotifyStateChanged(source, key);
        }

        public void SilentSet(string key, object value)
        {
            if (_state.ContainsKey(key))
                _state[key] = value;
            else
                _state.Add(key, value);
            NotifyStateChanged(null, key);
        }

        public object Get(string key)
        {
            return _state.ContainsKey(key) ? _state[key] : null;
        }

        public T Get<T>(string key)
        {
            return (T)Get(key);
        }

        public event Action<ComponentBase, string> OnStateChange;

        public void NotifyStateChanged(ComponentBase source, string key)
        {
            OnStateChange?.Invoke(source, key);
        }
    }
}
