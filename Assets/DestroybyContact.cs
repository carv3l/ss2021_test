using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyContact : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroide_explosion;
    public GameObject player_explosion;
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
            return;

        if (other.tag == "Player"){
            //Game over
            Instantiate(player_explosion, other.transform.position, other.transform.rotation);

        }
        //Collision shot/asteroide --> addScore
        Instantiate(asteroide_explosion, transform.position, transform.rotation);
        Destroy(other.gameObject);//shot
        Destroy(gameObject); //asteroide
        Debug.Log(other.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
