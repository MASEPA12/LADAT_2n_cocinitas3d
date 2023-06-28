using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KitchenSelection kitchenSelectionScript;
    public GameManager gameManagerScript;
    public float verticalInput;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        kitchenSelectionScript = FindObjectOfType<KitchenSelection>();
        gameManagerScript = FindObjectOfType<GameManager>();
        
    }
    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("recollectable"))
        {
            Debug.Log("OBJECTE RECOLLIT, FICAT DINS SA BOSSA");
            if(gameManagerScript.inTheBag.Length != 0)
            {
                gameManagerScript.inTheBag[gameManagerScript.inTheBag.Length + 1] = other.gameObject; // afegim s'objecte amb es que hem colisionat a sa'array
            }
            else
            {
                gameManagerScript.inTheBag[0] = other.gameObject; // afegim s'objecte amb es que hem colisionat a sa'array
            }
            
            Destroy(other.gameObject);
        }
    }
}
