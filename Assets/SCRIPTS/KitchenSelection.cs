using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//in this script will be coded how the elements goes to the center of the table to be used

public class KitchenSelection : MonoBehaviour
{
    //aquí se suposa que se farà una conexió entre scripts per veure quins elements estan guardats dins sa motxilla des player (lo que ha recollit)

    //de moment faré un array per comprovar com funciona :)
    public GameObject[] inTheBag;
    public GameObject[] placesOfTheStants;


    void Start()
    {
        //se instanciaran es elements de sa motxilla als llocs dels estantes (cada lloc de estantes serà representat amb un empty, així, sigui quin siguin es elements, se posaran per ordre)
        //posam que sigui fins sa llargària de es estantes pq només volem instanciar es objectes que hi capiguen. Lo seu és que hi hagui tants de estantes com coses màx a sa moxila
        for(int i = 0; i< inTheBag.Length; i++)
        {
            Instantiate(inTheBag[i], placesOfTheStants[i].transform.position, Quaternion.identity);
            Debug.Log($"the {i} object has been instantiated");
        }
    }

    void Update()
    {
        
    }
    
}
