// See https://aka.ms/new-console-template for more information

using Assignment_4;

// 1. Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
MyStack<int> myStack = new MyStack<int>();
for (int i = 0; i < 4; i++)
{
    myStack.Push(i);
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"MyStack length: {myStack.Count()}");
    Console.WriteLine($"Popup val: {myStack.Pop()}");
}
/*
 * MyStack length: 4
   Popup val: 3
   MyStack length: 3
   Popup val: 2
   MyStack length: 2
   Popup val: 1
 */

// 2. Create a Generic List data structure MyList<T> that can store any data type. Implement the following methods.
MyList<int> myList = new MyList<int>();
for (int i = 0; i < 7; i++)
{
    myList.Add(i);
}
Console.WriteLine($"MyList Count: {myList.Count()}");
myList.InsertAt(13, 1);
myList.InsertAt(22, 0);
Console.WriteLine($"Remove at index 1: {myList.Remove(1)}");
myList.DeleteAt(0);
Console.WriteLine($"Find index 1: {myList.Find(1)}");
Console.WriteLine(myList.Contains(0));
myList.Clear();
Console.WriteLine($"Count: {myList.Count()}");
/*
 * MyList Count: 7
   Remove at index 1: 0
   Find index 1: 1
   False
   Count: 0
 */
 
// 3. Implement a GenericRepository<T> class that implements IRepository<T> interface that will have common /CRUD/ operations so that it can work with any data source such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint on T were it should be of reference type and can be of type Entity which has one property called Id. IRepository<T> should have following methods
Entity[] entities = new Entity[10];
for (int i = 0; i < entities.Length; i++)
{
    entities[i] = new Entity(i, "Tom" + i);
}
GenericRepository<Entity> genericRepository = new GenericRepository<Entity>();
foreach (var entity in entities)
{
    genericRepository.Add(entity);
}
foreach (var gEntity in genericRepository.GetAll())
{
    Console.WriteLine($"Id: {gEntity.Id}, Name: {gEntity.Name}");
}
/*
 * Id: 0, Name: Tom0
   Id: 1, Name: Tom1
   Id: 2, Name: Tom2
   Id: 3, Name: Tom3
   Id: 4, Name: Tom4
   Id: 5, Name: Tom5
   Id: 6, Name: Tom6
   Id: 7, Name: Tom7
   Id: 8, Name: Tom8
   Id: 9, Name: Tom9
 */