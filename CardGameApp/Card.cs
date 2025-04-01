using System.Text;

public class Card
{
    private int value;
    private string description;
    private string suit;

    public Card(int inValue, string inSuit)
    {
        value = inValue;
        description = correspondingDescription(inValue);
        suit = inSuit;
    }

    public int getValue()
    {
        return value;
    }

    public string getDescription()
    {
        return suit;
    }

    public string getSuit()
    {
        return suit;
    }

    public void setValue(int inValue)
    {
        value = inValue;
    }

    public void setDescription(int inValue)
    {
        description = correspondingDescription(inValue);
    }

    public void setSuit(string inSuit)
    {
        suit = inSuit;
    }

    public string correspondingDescription(int inValue)
    {
        string cardDescription = "";
        switch (inValue)
        {
            case 1:
                cardDescription = "Ace";
                break;
            case 2:
                cardDescription = value.ToString();
                break;
            case 3:
                cardDescription = value.ToString();
                break;
            case 4:
                cardDescription = value.ToString();
                break;
            case 5:
                cardDescription = value.ToString();
                break;
            case 6:
                cardDescription = value.ToString();
                break;
            case 7:
                cardDescription = value.ToString();
                break;
            case 8:
                cardDescription = value.ToString();
                break;
            case 9:
                cardDescription = value.ToString();
                break;
            case 10:
                cardDescription = value.ToString();
                break;
            case 11:
                cardDescription = "Jack";
                break;
            case 12:
                cardDescription = "Queen";
                break;
            case 13:
                cardDescription = "King";
                break;
        }
        return cardDescription;
    }
}