using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.PackageManager;
using UnityEngine;

public class Deck
{
    int size;
    int front;
    int rear;
    int capacity;
    Card[] arr;

    public Deck(int c) 
    {
        arr = new Card[c];
        capacity = c;
        front = -1;
        rear = -1;
        size = 0;
    }
    public int Get_size()
    {
        return size;
    }
    public Card Get_front()
    {
        if (size == 0)
        {
            return null;
        }
        return arr[front];
    }
    public Card Get_rear()
    {
        if (size == 0)
        {
            return null;
        }
        return arr[rear];
    }

    public bool Is_empty()
    {
        if (front == -1)
        {
            return true;
        }
        return false;
    }

    public bool Is_full()
    {
        if (front == (rear + 1) % capacity)
        {
            return true;
        }
        return false;
    }

    public void Enqueue(Card elem)
    {

        if (Is_full() == true)
        {

        }
        else 
        {
            size++;
            if (front == -1)
            {
                front = 0;
            }

            rear = (rear + 1) % capacity;
            arr[rear] = elem;
            
        }
    }
    public Card Dequeue()
    {
        if (Is_empty() == true)
        {
            return null;
        }
        size--;
        Card elem = arr[front];
        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else 
        {
            front = (front + 1) % capacity;
        }
        return elem;
    }

    public void Shuffle()
    {
        // fischer yates shuffle
        int rng;
        int array_end;
        int steps = size;
        Card temp_value;
        Card[] temp_deck = new Card[capacity];

        for (int i = 0; i < steps; i++)
        { 
            temp_deck[i] = Dequeue();
        }

        for (int i = 0; i < steps; i++)
        {
            array_end = steps - 1;
            rng = Random.Range(0, array_end);

            temp_value = temp_deck[array_end];
            temp_deck[array_end] = temp_deck[rng];
            temp_deck[rng] = temp_value;
        }

        for (int i = 0; i < steps; i++)
        { 
            Enqueue(temp_deck[i]);
        }


    }


}
