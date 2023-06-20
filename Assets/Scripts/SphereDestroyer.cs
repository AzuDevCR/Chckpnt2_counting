using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroyer : MonoBehaviour
{
    [SerializeField] int timeToDestroy = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroySpheres());
    }

    IEnumerator DestroySpheres() {
        yield return new WaitForSeconds(timeToDestroy);
        if(gameObject.tag == "ended") {
            Destroy(gameObject);
        }
        
    }
}
