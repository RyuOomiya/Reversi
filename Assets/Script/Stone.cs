using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    [SerializeField] GameObject _stone;
    Quaternion _black = new Quaternion(0,0,0,0);
    Quaternion _white = new Quaternion(180,0,0,0);

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PutStone(int x, int z, int color)
    {
        if(color == 1)
        Instantiate(_stone, new Vector3(x * 1.1f, 0, z * 1.1f) , _black);
        if(color == -1)
        Instantiate(_stone, new Vector3(x * 1.1f, 0, z * 1.1f) , _white);
    }
}
