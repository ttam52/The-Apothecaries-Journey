using System.ComponentModel;
using System.Linq;
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

    public void shuffle()
    {
        // fischer yates shuffle
        int rng;
        int steps = size;
        int array_end;
        card_parent temp_value;
        card_parent[] temp_deck = new card_parent[capacity];

        for (int i = 0; i < steps; i++)
        { 
            temp_deck[i] = dequeue();
        }

        for (int i = 0; i < temp_deck.Count(); i++)
        {
            array_end = temp_deck.Count() - 1;
            rng = Random.Range(0, array_end);

            temp_value = temp_deck[array_end];
            temp_deck[array_end] = temp_deck[rng];
            temp_deck[rng] = temp_value;
        }

        for (int i = 0; i < temp_deck.Count(); i++)
        { 
            enqueue(temp_deck[i]);
        }


    }


}
