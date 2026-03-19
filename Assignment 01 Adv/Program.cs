namespace Assignment_01_Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            //A1: A generic class is a class that can work with any data type using type parameters.
            //why use generics:
            //type safety: Generics provide compile-time type checking, reducing runtime errors.
            //performance: Generics can improve performance by avoiding the need for boxing and unboxing when working with value types.
            //intellisense: Better support in IDEs, providing more accurate code completion and error checking.
            //code reuse: one implementation can work with multiple data types, reducing code duplication and improving maintainability. 
            #endregion

            #region Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //A2:
            //public class Container<T>
            //{
            //    private T item;
            //    public void Add(T newItem)
            //    {
            //        item = newItem;
            //    }
            //    public T Get()
            //    {
            //        return item;
            //    }
            //}
            #endregion

            #region Q3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //A3: Multiple type parameters allow a generic class to work with more than one data type.
            //public class Pair<TKey, TValue>
            //{
            //    private TKey key;
            //    private TValue value;
            //    public void SetPair(TKey newKey, TValue newValue)
            //    {
            //        key = newKey;
            //        value = newValue;
            //    }
            //    public (TKey, TValue) GetPair()
            //    {
            //        return (key, value);
            //} 
            #endregion

            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.
            //A4: A generic method is a method that can operate on any data type using type parameters.
            //public void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion

            #region Q5
            //Q5: Write a generic method FindMax<T> that finds maximum value
            //public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //} 
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.
            //A6: A generic interfaces define contracts with type parameters, allowing for more flexible and reusable code.
            //public interface IRepository<T>
            //{
            //    void Add(T item);
            //    void Remove(T item);
            //    T GetById(int id);
            //} 
            #endregion

            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            //A7: The 'struct' constraint restricts a type parameter to value types (structs).
            //public class ValueContainer<T> where T : struct
            //{
            //    private T value;
            //    public void SetValue(T newValue)
            //    {
            //        value = newValue;
            //    }
            //    public T GetValue()
            //    {
            //        return value;
            //    }
            //}
            #endregion

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            //A8: The 'class' constraint restricts a type parameter to reference types (classes).
            //public class ReferenceContainer<T> where T : class
            //{
            //    private T reference;
            //    public void SetReference(T newReference)
            //    {
            //        reference = newReference;
            //    }
            //    public T GetReference()
            //    {
            //        return reference;
            //    }
            //}
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            //A9: The 'new()' constraint requires that the type parameter has a public parameterless constructor.
            //public class Factory<T> where T : new()
            //{
            //    public T CreateInstance()
            //    {
            //        return new T();
            //    }
            //}
            #endregion

            #region Q10
            //Q10:  What is the interface constraint? Write an example.
            //A10: The interface constraint restricts a type parameter to types that implement a specific interface.
            //public interface IPrintable
            //{
            //    void Print();
            //}
            //public class PrintableContainer<T> where T : IPrintable
            //{
            //    private T item;
            //    public void SetItem(T newItem)
            //    {
            //        item = newItem;
            //    }
            //    public void PrintItem()
            //    {
            //        item.Print();
            //    }
            //}
            #endregion

            #region Q11
            //Q11: What is the base class constraint? Write an example.
            //A11: The base class constraint restricts a type parameter to types that inherit from a specific base class.
            //public class BaseClass
            //{
            //    public void BaseMethod()
            //    {
            //        Console.WriteLine("Base method");
            //    }
            //}
            //public class DerivedContainer<T> where T : BaseClass
            //{
            //    private T item;
            //    public void SetItem(T newItem)
            //    {
            //        item = newItem;
            //    }
            //    public void CallBaseMethod()
            //    {
            //        item.BaseMethod();
            //    }
            //}
            #endregion

            #region Q12
            //Q12: How do you apply multiple constraints? Write an example. 
            //A12: You can apply multiple constraints by separating them with commas in the where clause.
            //public class MultiConstraintContainer<T> where T : class, IPrintable
            //{
            //    private T item;
            //    public void SetItem(T newItem)
            //    {
            //        item = newItem;
            //    }
            //    public void PrintItem()
            //    {
            //        item.Print();
            //    }
            //}
            #endregion

            #region Q13
            //Q13: What does the 'default' keyword do in generics?
            //A13: The 'default' keyword in generics is used to return the default value of a type parameter.
            //For reference types, the default value is null. For value types, it is the zero-initialized value (e.g., 0 for int, false for bool).
            #endregion

            #region Q14
            //Q14: Write a SafeList<T> that returns default when the index is invalid.
            // public class SafeList<T>
            // {
            //    private List<T> _list = new List<T>();
            //    public void Add(T item) => _list.Add(item);
            //    public T Get(int index)
            //    {
            //        if (index < 0 || index >= _list.Count)
            //            return default;

            //        return _list[index];
            //    }
            // }
            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //covariance allows returning more derived type than originally specified.
            //The 'out' keyword is used to declare a type parameter as covariant, meaning it can only be used for return types and not for input parameters.
            //public interface IProducer<out T>
            //{
            //    T Get();
            //}
            #endregion

            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows accepting less derived type than originally specified.
            //The 'in' keyword is used to declare a type parameter as contravariant, meaning it can only be used for input parameters and not for return types.
            //public interface IConsumer<in T>
            //{
            //    void Consume(T item);
            //}
            #endregion

            #region Q17
            //Q17: What is the difference between covariance and contravariance?
            //Covariance allows a method to return a more derived type than specified, while contravariance allows a method to accept a less derived type than specified.
            //Covariance is declared with the 'out' keyword, while contravariance is declared with the 'in' keyword.
            //Covariance is used for return types, while contravariance is used for input parameters.
            //Covariance is typically used in producer scenarios, while contravariance is used in consumer scenarios.
            //Example:
            //public class Animal { }
            //public class Dog : Animal { }
            //public interface IProducer<out T>
            //{
            //    T Get();
            //}
            //public interface IConsumer<in T>
            //{
            //    void Consume(T item);
            //}
            //IProducer<Animal> animalProducer = new Producer<Dog>(); // Covariance allows this assignment
            //IConsumer<Dog> dogConsumer = new Consumer<Animal>(); // Contravariance allows this assignment
            #endregion

            #region Q18
            //Q18: How do static members work in generic types?
            //Each closed constructed type (e.g., Container<int>, Container<string>) has its own set of static members.
            #endregion

            #region Q19
            //Q19: How can you inherit from a generic class?
            //You can inherit from a generic class by specifying the type parameters in the derived class.
            //public class BaseContainer<T>
            //{
            //    public T Item { get; set; }
            //}
            //public class DerivedContainer<T> : BaseContainer<T>
            //{
            //    public void DisplayItem()
            //    {
            //        Console.WriteLine(Item);
            //    }
            //}
            //You can also specify a concrete type for the base class:
            //public class StringContainer : BaseContainer<string>
            //{
            //    public void DisplayItem()
            //    {
            //        Console.WriteLine(Item);
            //    }
            //}
            //In both cases, the derived class can access the members of the generic base class using the specified type parameters.
            #endregion

            #region Q20
            //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
            /*
            public class CacheItem<TValue>
            {
                public TValue Value { get; set; }
                public DateTime Expiration { get; set; }

                public bool IsExpired => DateTime.Now > Expiration;
            }

            public class Cache<TKey, TValue>
            {
                private Dictionary<TKey, CacheItem<TValue>> _cache 
                    = new Dictionary<TKey, CacheItem<TValue>>();

                public void Add(TKey key, TValue value, TimeSpan duration)
                {
                    _cache[key] = new CacheItem<TValue>
                    {
                        Value = value,
                        Expiration = DateTime.Now.Add(duration)
                    };
                }

                public TValue Get(TKey key)
                {
                    if (!_cache.ContainsKey(key))
                        return default;

                    var item = _cache[key];

                    if (item.IsExpired)
                    {
                        _cache.Remove(key);
                        return default;
                    }

                    return item.Value;
                }

                public bool Contains(TKey key)
                {
                    return _cache.ContainsKey(key) && !_cache[key].IsExpired;
                }

                public void Remove(TKey key)
                {
                    _cache.Remove(key);
                }
            }
             */
            #endregion

        }
    }
}
