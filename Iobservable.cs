namespace observerPattern
{
  interface IObservable
  {
    void notify();
    void register(IObserve observer);
    void unRegister(IObserve observer);
  }
}