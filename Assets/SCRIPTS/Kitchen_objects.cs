using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_objects : MonoBehaviour
{
    public Vector3 centerOfTheTable;
    public int arrayPosition;
    public Vector3 posInTheStants;
    public bool isSomethingOnTheTable;

    void Start()
    {
        //com puc identificar a quina posició de s'array està s'objecte aquest, per saber sa seva posició
        //necessit saber a quin puesto estava per guardar s'empty on estava, sinos puc fer lo seguent;
        posInTheStants = transform.position; // guardam posició inicial

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (!isSomethingOnTheTable)
        {
            transform.position = centerOfTheTable;
        }
        else //si hi ha algo damunt sa taula
        {
            //com se si a un altre objecte li han clickat damunt? necessit saber: 
        }
    }

    /*
    existeix una funció que se diu OnMouseDrag, per fer lo de ses cocinillas per tallar aniria be alomillor. HAn de tenir es raycast activat
    osigui, que no han de tenir lo de "evitar raycast" i han de tenir collider. Funciona 2 i 3 d
     */


    /* OnClik()
     * {
     *      if(no hi ha res damunt sa taula)
     *      {
     *          vaig ENMIG
     *      }
     *      
     *      if(hi ha algo damunt sa taula) [i me clicken a jo]
     *      {
     *          lo que està enmig --> transform.position = initialPos (que li he dit "posInTheStants")
     *          i jo vaig enmig --> transform.position = ENMIG
     *      }
     */
}
