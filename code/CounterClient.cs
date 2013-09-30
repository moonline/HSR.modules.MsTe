using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSRCounter;

namespace Client {
    class CounterClient {
        static void HandleCounterChange(Counter c, CounterEventArguments a) {
            Console.WriteLine("Obs1: Counter changed: Value = " + a.count);
        }

        static void Main(string[] args) {
            Counter counter = new Counter(10);
            counter.CounterValueChanged += CounterClient.counter_CounterValueChanged;
            counter.CounterValueChanged += CounterClient.HandleCounterChange;
            counter.Increment();
            counter.Increment();
            counter.Reset(5);
            counter.Decrement();
            Console.ReadLine();
        }

        static void counter_CounterValueChanged(Counter c, CounterEventArguments a) {
            Console.WriteLine("Obs2: Counter changed: Value = " + a.count);
        }
    }
}
