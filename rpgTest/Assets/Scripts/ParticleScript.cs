using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{

    public string SortingLayerName;
    public int SortingOrder = 2;

    // Use this for initialization
    void Start()
    {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = SortingLayerName;
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingOrder = 2;
    }
}
