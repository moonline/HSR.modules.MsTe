using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRCounter {
    public delegate void CounterEventHandler(Counter c, CounterEventArguments a);

    public class Counter {
        private int count;
        
        public event CounterEventHandler CounterValueChanged;

        public Counter(int value = 0) {
            this.Count = value;
        }

        public int Increment() {
            return ++this.Count;
        }

        public int Decrement() {
            return --this.Count;
        }

        public void Reset(int value = 0) {
            this.Count = value;
        }

        public int Count { 
            get { return this.count; }
            private set {
                this.count = value;
                if (this.CounterValueChanged != null) {
                    CounterValueChanged(this, new CounterEventArguments() { count = this.Count });
                }
            }
        }
    }
}

public class CounterEventArguments : System.EventArgs {
    public int count;
}

namespace HSRCounter {
    public delegate void CounterEventHandler(Counter c, CounterEventArguments a);

    public class Counter {
        private int count;
        
        public event CounterEventHandler CounterValueChanged;

        public Counter(int value = 0) {
            this.Count = value;
        }

        public int Increment() {
            return ++this.Count;
        }

        public int Decrement() {
            return --this.Count;
        }

        public void Reset(int value = 0) {
            this.Count = value;
        }

        public int Count { 
            get { return this.count; }
            private set {
                this.count = value;
                if (this.CounterValueChanged != null) {
                    CounterValueChanged(this, new CounterEventArguments() { count = this.Count });
                }
            }
        }
    }
}

public class CounterEventArguments : System.EventArgs {
    public int count;
}
