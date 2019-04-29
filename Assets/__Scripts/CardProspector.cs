using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An enum defines a variable type with a few prenamed values

 public enum eCardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardProspector : Card {

    [Header("Set Dynamically:CardProspector")]
    public eCardState state = eCardState.drawpile;
    //The hiddenBy list stores which other cards will keep this one face down

    public List<CardProspector> hiddenBy = new List<CardProspector>();
    // The layoutID matches this card to the tableau XML if it's a tableau card
    public int layoutID;

    //The SlotDef class stores info pulled in from the LayoutXML <slot>
    public SlotDef slotDef;

    override public void OnMouseUpAsButton() //Allows card to react to being clicked
    {
        //Call the CardClicked method on Prospector singleton
        Prospector.S.CardClicked(this);
        //Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
