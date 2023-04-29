using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    [SerializeField] GameObject _stone;
    void Start()
    {
        for(int i  = 3; i <= 4; i++)
        {
            for(int j = 3; j <= 4; j++)
            {
                Instantiate(_stone, new Vector3(i * 1.1f, 0, j * 1.1f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
