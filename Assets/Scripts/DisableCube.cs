using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCube : MonoBehaviour
{
    public GameObject testObject;

    public void Deactive()
    {
        testObject.SetActive(!testObject.activeInHierarchy);
    }
}
