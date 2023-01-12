using Microsoft.AspNetCore.Components;

namespace BoxOfficeDemo.Client.Configurations
{
    public class CurrentSession
    {
        private readonly Dictionary<string, object> Session = new();
        public event Action OnChange;

        public void Set(string key, object value)
        {
            if (Session.ContainsKey(key))
                Session[key] = value;
            else
                Session.Add(key, value);
            OnChange?.Invoke();
        }

        public object? Get(string key)
        {
            return Session.ContainsKey(key) ? Session[key] : null;
        }

        public void Clear()
        {
            Session.Clear();
        }
        //public void Set(ComponentBase source, string key, object value)
        //{
        //    if (Session.ContainsKey(key))
        //        Session[key] = value;
        //    else
        //        Session.Add(key, value);
        //    //NotifyStateChanged(source, key);
        //    OnChange?.Invoke();
        //}

        //public T Get<T>(string key)
        //{
        //    return (T)Get(key);
        //}

        //public event Action<ComponentBase, string> OnStateChange;

        //public void NotifyStateChanged(ComponentBase source, string key)
        //{
        //    OnStateChange?.Invoke(source, key);
        //}
    }
}
