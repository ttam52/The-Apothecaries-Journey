using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.PackageManager;
using UnityEngine;

public class deck_script
{
    int front;
    int rear;
    int size;
    int capacity;
    card_parent[] deck;

    public deck_script(int c) 
    {
        deck = new card_parent[c];
        capacity = c;
        front = -1;
        rear = -1;
        size = 0;
    }

    public card_parent get_front()
    {
        if (size == 0)
        {
            return null;
        }
        return deck[front];
    }
    public card_parent get_rear()
    {
        if (size == 0)
        {
            return null;
        }
        return deck[rear];
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

    public void enqueue(card_parent elem)
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
            deck[rear] = elem;
            
        }
    }
    public card_parent dequeue()
    {
        if (is_empty() == true)
        {
            return null;
        }
        size--;
        card_parent elem = deck[front];
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


}
