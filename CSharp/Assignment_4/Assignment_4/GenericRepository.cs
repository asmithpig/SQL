namespace Assignment_4;

public class GenericRepository<T> : IRepository<T> where T: IEntity
{
    private List<T> _list = new List<T>();

    public void Add(T item)
    {
        _list.Add(item);
    }

    public void Remove(T item)
    {
        _list.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Saving ...");
    }

    public IEnumerable<T> GetAll()
    {
        return _list.ToList();
    }

    public T GetById(int id)
    {
        return _list.FirstOrDefault(item => item.Id == id);
    }
}