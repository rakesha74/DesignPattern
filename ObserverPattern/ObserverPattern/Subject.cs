using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
