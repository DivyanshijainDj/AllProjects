// See https://aka.ms/new-console-template for more information
public class stack {

        private List<object> _items = new List<object>();

        public void Push(object obj)
        {
        if(obj == null)
        {
            throw new("InvalidOperationException");
        }
        else
            _items.Add(obj);
        }

        public object Pop()
        {

            var LastPass = _items.Last();
        
            _items.Remove(LastPass);
            return LastPass;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }

