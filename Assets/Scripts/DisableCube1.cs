using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCube1 : MonoBehaviour
{
    public GameObject targetObject;

    public void Deactive()
    {
        targetObject.SetActive(!targetObject.activeInHierarchy);
    }
}
