using System.Collections.Generic;
using LinkedList;
using NUnit.Framework;

namespace LinkedListTests;

public class CustomLinkedListTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void InitTest()
    {
        var l = new CustomLinkedList<int>();

        Assert.AreEqual(0, l.Count);
        Assert.IsNull(l.GetFirst());
        Assert.IsNull(l.GetLast());
        Assert.IsNull(l.GetOnIndex(1));

        l = new CustomLinkedList<int>() { 5, 9, 7, 1, 3, 4 };
        var lExpected = new List<int>() { 5, 9, 7, 1, 3, 4 };
        var lActual = new List<int>();
        foreach (int item in l)
        {
            lActual.Add(item);
        }

        Assert.AreEqual(lExpected, lActual);
    }

    [Test]
    public void AddFirstTest()
    {
        var l = new CustomLinkedList<int>();

        l.AddFirst(5);
        var expectedFirstNode = new Node<int>() { Value = 5 };
        Assert.AreEqual(expectedFirstNode.Value, l.GetFirst().Value);
        Assert.IsNull(l.GetFirst().Next);
        Assert.IsNull(l.GetFirst().Previous);

        l.AddFirst(9);
        expectedFirstNode = new Node<int>() { Value = 9 };
        Assert.AreEqual(expectedFirstNode.Value, l.GetFirst().Value);
        Assert.IsNotNull(l.GetFirst().Next);
        Assert.IsNotNull(l.GetFirst().Previous);

        l.AddFirst(3);
        l.AddFirst(1);
        l.AddFirst(3);
        l.AddFirst(1);

        var lExpected = new List<int>() { 1, 3, 1, 3, 9, 5 };
        var lActual = new List<int>();
        foreach (int item in l)
        {
            lActual.Add(item);
        }

        Assert.AreEqual(lExpected, lActual);
    }

    [Test]
    public void AddLastTest()
    {
        var l = new CustomLinkedList<int>();

        l.AddLast(5);
        var expectedFirstNode = new Node<int>() { Value = 5 };
        Assert.AreEqual(expectedFirstNode.Value, l.GetFirst().Value);
        Assert.IsNull(l.GetFirst().Next);
        Assert.IsNull(l.GetFirst().Previous);
        Assert.IsNull(l.GetLast());

        l.AddLast(9);
        Assert.AreEqual(expectedFirstNode.Value, l.GetFirst().Value);
        Assert.IsNotNull(l.GetFirst().Next);
        Assert.IsNotNull(l.GetFirst().Previous);
        Assert.IsNotNull(l.GetLast());
        var expectedLastNode = new Node<int>() { Value = 9 };
        Assert.AreEqual(expectedLastNode.Value, l.GetLast().Value);

        l.AddLast(7);
        l.AddLast(1);
        l.AddLast(3);
        l.AddLast(4);

        var lExpected = new List<int>() { 5, 9, 7, 1, 3, 4 };
        var lActual = new List<int>();
        foreach (int item in l)
        {
            lActual.Add(item);
        }

        Assert.AreEqual(lExpected, lActual);
    }

    [Test]
    public void GetOnIndexTest()
    {
        var l = new CustomLinkedList<int>(){ 5, 9, 7, 1,5, 3, 4 };
        Assert.AreEqual(5,l.GetOnIndex(4));
    }
}