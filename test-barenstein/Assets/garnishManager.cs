using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garnishManager : MonoBehaviour
{
    public GameObject[] garnish;
    public bool[] garnishIng;
    // Start is called before the first frame update
    void Start()
    {
        garnishIng = new bool[garnish.Length];
        for (int i = 0; i < garnishIng.Length; i++)
        {
            garnishIng[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
