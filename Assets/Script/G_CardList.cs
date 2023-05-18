using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_CardList : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public int total = 0;
    public List<Card> result = new List<Card>();

    public void ResultSelcet()
    {
        result.Add(GoblinCard());
    }

    public Card GoblinCard()
    {
        int weight = 0;
        int chooseNum = 0;

        chooseNum = Mathf.RoundToInt(total * Random.Range(0.0f, 1.0f));
        for (int i = 0; i < deck.Count; i++)
        {
            weight += deck[i].weight;
            if (chooseNum <= weight)
            {
                Card temp = new Card(deck[i]);
                return temp;
            }
        }
        return null;
    }

    void Start()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            total += deck[i].weight;
            //Debug.Log(deck[i].weight);
        }
    }
}
