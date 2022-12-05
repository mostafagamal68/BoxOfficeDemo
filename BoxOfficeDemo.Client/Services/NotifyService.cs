namespace BoxOfficeDemo.Client.Services
{
    public class NotifyService
    {
        public List<string> MoviesWatchList = new();

        public int Count { get; set; } = 0;

        public event Action OnChange;

        public bool AddMovieToWatchList(string name)
        {
            if (!MoviesWatchList.Contains(name))
            {
                MoviesWatchList.Add(name);
                Count = MoviesWatchList.Count;
                OnChange?.Invoke();
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            MoviesWatchList.Clear();
            Count = MoviesWatchList.Count;
            OnChange?.Invoke();
        }
    }
}
