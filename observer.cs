using System;

namespace observerPattern
{
  class Observer : IObserve
  {
    Observable observable;
    public Observer(Observable _observable)
    {
      this.observable = _observable;
      observable.register(this);
    }
    public void update()
    {
      String list = "";
      for (int i = 0; i < observable.data.Count; i++)
      {
        list += observable.data[i];
      }
      Console.WriteLine("notified of data update. " + list);
    }
  }
}