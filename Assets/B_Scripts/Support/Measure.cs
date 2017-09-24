using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    #region Unity Events
    void Awake()
    {
        var x = GetComponent<MeshRenderer>().bounds.extents.x;
        var z = GetComponent<MeshRenderer>().bounds.extents.z;

        Debug.Log(string.Format("Bounding box: {0} x {1}", x, z));
    }
    #endregion
}
