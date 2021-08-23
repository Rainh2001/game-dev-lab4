using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int rand;

    public Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        rand = (int)Random.Range(200, 251);
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if(gameObject.tag == "Red" && i == 100){
            gameObject.SetActive(false);
        }

        if(gameObject.tag == "Blue" && i == rand){
            rend.enabled = false;
        }

    }
}
