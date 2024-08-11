namespace HomeWorkFinal
{
    public class BrowserHistory
    {

        private Stack<HistoryItem> _history;

        private int _currentIndex;

        public BrowserHistory()
        {
            _history = new Stack<HistoryItem>();

            _currentIndex = 0;
        }

        public string Visit(string url)
        {
            _history.Push(new HistoryItem(TimeOnly.FromDateTime(DateTime.Now), url));

            var item = _history.Peek();

            _currentIndex = 0;

            return $"Visit: URL: {item.URL} | Time {item.Time} \n";
        }

        public string Forward()
        {
            if (_currentIndex - 1 < 0) return $"Actual site!";

            _currentIndex--;

            var item = _history.Peek(_currentIndex);

            return $"Visit: URL: {item.URL} | Time {item.Time} \n";
        }

        public string Back()
        {
            if (_currentIndex + 1 >= _history.Count) return $"Last site!";

            _currentIndex++;

            var item = _history.Peek(_currentIndex);

            return $"Visit: URL: {item.URL} | Time {item.Time} \n";
        }

        public string All()
        {
            var result = string.Empty;

            for (int i = _history.Count - 1; i >= 0; i--)
            {
                var item = _history.Peek(i);

            }

            return result;
        }

        public void Clear()
        {
            _history = new Stack<HistoryItem>();

            _currentIndex = 0;
        }

        private class HistoryItem(TimeOnly time, string url)
        {
            public TimeOnly Time { get; private set; } = time;
        
            public string URL { get; private set; } = url;
        }
    }
}
