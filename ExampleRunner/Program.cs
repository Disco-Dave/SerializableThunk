using System;
using System.Collections;
using System.Collections.Generic;
using SerializableLambda;

namespace ExampleRunner
{
    class ExampleObject
    {
        public List<int> DoSomething(int x, double y, string z)
        {
            return new List<int>() { 1, 2, 3, 4 };
        }

        public string DoSomethingElse()
        {
            return "asjdklasdjalksd";
        }

        public string GenericSomething<T>()
        {
            return typeof(T).ToString();
        }
    }

    class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<Type, Func<IServiceLocator, dynamic>> container = new Dictionary<Type, Func<IServiceLocator, dynamic>>();

        public T Get<T>()
        {
            return this.container[typeof(T)](this);
        }

        public ServiceLocator Register<T>(Func<IServiceLocator, T> service)
        {
            this.container.Add(typeof(T), sl => (dynamic) service(sl));
            
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var locator = new ServiceLocator().Register(_ => new ExampleObject());

            SerializableLambda<IEnumerable> s = SerializableLambdaFactory.Create<ExampleObject, IEnumerable, int, string, double>(
               (eo, x, z, y) => eo.DoSomething(x, y, z))
               .SetParameters(1, "adsadasdsa", 303030.30);
            var sReturn = s.Execute(locator);

            var ss = s.Serialize();
            var ss2 = SerializableLambda<IEnumerable>.Deserialize(ss);
            var ss2Return = ss2.Execute(locator);

            var f = SerializableLambdaFactory.Create<ExampleObject, string>(eo => eo.DoSomethingElse());
            var fReturn  = f.Execute(locator);

            var g = SerializableLambdaFactory.Create<ExampleObject, string>(eo => eo.GenericSomething<double>());
            var gReturn = g.Execute(locator);

            var gs = g.Serialize();
            var gs2 = SerializableLambda<string>.Deserialize(gs);
            var gs2Return = gs2.Execute(locator);
        }
    }
}