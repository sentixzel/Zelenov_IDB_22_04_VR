using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    public GameObject cube;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cube =  GameObject.Find("SpecialCube");
            inst();
        }
    }

    void inst()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 nv = new Vector3(i, 0, 0);
            Instantiate(cube, nv, cube.transform.rotation);
        }
    }
}
