using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.PackageManager;
using UnityEngine;

public class deck
{
    int size;
    int front;
    int rear;
    int capacity;
    card[] arr;

    public deck(int c) 
    {
        arr = new card[c];
        capacity = c;
        front = -1;
        rear = -1;
        size = 0;
    }
    public int get_size()
    {
        return size;
    }
    public card get_front()
    {
        if (size == 0)
        {
            return null;
        }
        return arr[front];
    }
    public card get_rear()
    {
        if (size == 0)
        {
            return null;
        }
        return arr[rear];
    }

    public bool is_empty()
    {
        if (front == -1)
        {
            return true;
        }
        return false;
    }

    public bool is_full()
    {
        if (front == (rear + 1) % capacity)
        {
            return true;
        }
        return false;
    }

    public void enqueue(card elem)
    {

        if (is_full() == true)
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
    public card dequeue()
    {
        if (is_empty() == true)
        {
            return null;
        }
        size--;
        card elem = arr[front];
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

    public void shuffle()
    {
        // fischer yates shuffle
        int rng;
        int array_end;
        int steps = size;
        card temp_value;
        card[] temp_deck = new card[capacity];

        for (int i = 0; i < steps; i++)
        { 
            temp_deck[i] = dequeue();
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
            enqueue(temp_deck[i]);
        }


    }


}
