//3
using System;
using System.ComponentModel.Design;

public class Tree<T> where T : IComparable
{
    private T item;
    private Tree<T> left = null;
    private Tree<T> right = null;

    public Tree(T item)
    {
        this.item = item;
    }

    public void Add(T item)
    {
        if (item.CompareTo(this.item) < 0)
        {
            if (left == null)
                left = new Tree<T>(item);
            else
                left.Add(item);
        }
        else if (item.CompareTo(this.item) > 0)
        {
            if (right == null)
                right = new Tree<T>(item);
            else right.Add(item);
        }
    }
    public void AddRange(List<T> items)
    {
        foreach (T item in items)
            Add(item);
    }
    public void InOrderTraversal()
    {
        if (left != null)
            left.InOrderTraversal();

        Console.WriteLine(item);

        if (right != null) right.InOrderTraversal();

    }
}
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(50);
            tree.Add(30);
            tree.Add(20);
            tree.Add(40);

            List<int> items = new List<int> { 10, 90, 100, 5};
            tree.AddRange(items);

            tree.InOrderTraversal();
        }
    }
