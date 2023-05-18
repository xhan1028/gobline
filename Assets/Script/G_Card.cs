using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardGrade { One, Two, Three, Four, Five, Six, Devil }

[System.Serializable]
public class Card
{
    public string cardName;
    public Sprite cardImage;
    public CardGrade cardGrade;
    public int weight;

    public Card(Card card)
    {
        this.cardName = card.cardName;
        this.cardImage = card.cardImage;
        this.cardGrade = card.cardGrade;
        this.weight = card.weight;
    }
}
