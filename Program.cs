using System;

namespace observerPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      // Create an observable item. 
      Observable observable = new Observable();

      // Create an observer of that item and inject the observable into the observer.
      Observer observer = new Observer(observable);

      observable.changeData();
    }
  }
}
