using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_objects : MonoBehaviour
{
    public Vector3 centerOfTheTable;
    public int arrayPosition;
    public KitchenSelection kitchenSelectionScript;
    void Start()
    {
        kitchenSelectionScript = FindObjectOfType<KitchenSelection>();
        //com puc identificar a quina posició de s'array està s'objecte aquest, per saber sa seva posició
        //necessit saber a quin puesto estava per guardar s'empty on estava, sinos puc fer lo seguent;

    }

    private void OnMouseDown()
    {
        if (!kitchenSelectionScript.isSomethingOnTheTable) //==false
        {
            Debug.Log("PRIMERA BOLLA");

            kitchenSelectionScript.initialPos = transform.position; //guardam posició inicial de s'objecte --> NO HO NECESSIT PA GUARD SA POSICÌÓ DE S'ANTERIOR QUANT PITJ SA SEGONA
            transform.position = centerOfTheTable; //movem s'objecte enmig
            kitchenSelectionScript.isInTheCenterOfTheTable.Add(gameObject); //afegim s'objecte a sa llista 
            kitchenSelectionScript.isSomethingOnTheTable = true; //ara si que hi ha algo damunt sa taula
        }
        else //==true
        {
            Debug.Log("HAS ENTRAT A SA PART DE QUANT JA HI HA ALGO");

            kitchenSelectionScript.isInTheCenterOfTheTable[0].transform.position = kitchenSelectionScript.initialPos; //movem s'objecte A que hi ha a sa llista al seu lloc inicial
            kitchenSelectionScript.isInTheCenterOfTheTable.Remove(kitchenSelectionScript.isInTheCenterOfTheTable[0]); //eliminam s'objecte A de sa llista

            kitchenSelectionScript.initialPos = transform.position; //guardam posició inicial de s'objecte B
            transform.position = centerOfTheTable; //movem s'objecte B enmig
            kitchenSelectionScript.isInTheCenterOfTheTable.Add(gameObject); //afegim s'objecte B a sa llista 
            
            
        }
    }

    /*
    existeix una funció que se diu OnMouseDrag, per fer lo de ses cocinillas per tallar aniria be alomillor. Han de tenir es raycast activat
    osigui, que no han de tenir lo de "evitar raycast" i han de tenir collider. Funciona 2 i 3 d
     */

}
