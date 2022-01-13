
namespace LR19LR18;


class CollectionType<T> : IWork<T> where T : SubjiectGuide
{

    List<T> list;
    int count;

    public SubjiectGuide this[int index]
    {
        get => list[index];
    }

    public int Count
    {
        get => count;
    }

    public CollectionType()
    {
        list = new List<T>();
        int count = 0;
    }

    public void Add(T sub)
    {
        try
        {
            list.Add(sub);
            count++;
        }
        finally
        {
            Console.WriteLine();
        }

    }

    public void RemoveAt(int ind)
    {
        try
        {
            list.RemoveAt(ind);
            count--;
        }
        finally
        {
            Console.WriteLine();
        }
    }

    public void Remove(T sub)
    {
        try
        {
            list.Remove(sub);
            count--;
        }
        finally
        {
            Console.WriteLine();
        }

    }

    public void Print(int id)
    {
        try
        {
            Console.WriteLine(list[id].ToString());
        }
        finally
        {
            Console.WriteLine();
        }

    }


}

