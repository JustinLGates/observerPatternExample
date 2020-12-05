using System.Collections.Generic;

namespace observerPattern
{
  class Observable : IObservable
  {

    public List<int> data;
    private List<IObserve> observers;

    public Observable()
    {
      this.data = new List<int>() { 1, 2, 3 };
      this.observers = new List<IObserve>();
    }

    public void changeData()
    {
      data.Add(1);
      notify();
    }

    public List<int> getData()
    {
      return this.data;
    }

    public void register(IObserve observer)
    {
      this.observers.Add(observer);
    }

    public void unRegister(IObserve observer)
    {
      this.observers.Remove(observer);
    }

    public void notify()
    {
      observers.ForEach(observer => observer.update());
    }
  }
}