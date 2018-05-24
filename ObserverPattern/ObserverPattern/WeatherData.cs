using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObserverPattern
{
    public class WeatherData: Subject
    {
        ArrayList observers;
        float temperature;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }
    }
}
