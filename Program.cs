
using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {

    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> nimData = new DataGeneric<string>("103022300053");

        nimData.PrintData();
    }
}

