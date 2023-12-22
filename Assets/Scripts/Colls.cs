using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colls : MonoBehaviour
{
    public int i = 90;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider coll)
    {
        i--;
        text.text = i.ToString();
        Debug.Log(coll.name);
    }

}
