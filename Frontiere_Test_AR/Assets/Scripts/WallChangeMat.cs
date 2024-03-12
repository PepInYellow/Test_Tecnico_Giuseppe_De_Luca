using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChangeMat : MonoBehaviour
{

    public Material[] wallMaterials;

    public MeshRenderer mainMeshRend;

    private int pos = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPlane () 
    
    {

        pos = pos + 1;

        if(pos >= wallMaterials.Length) 
        
        {

            pos = 0;

        }

        SetPosTo(pos);

        }

    public void SetPosTo(int newPos)
    
    {

        pos = newPos;
        MeshRenderer[] rend = transform.GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < rend.Length; i++) 
        
        { 
        
            rend[i].material = wallMaterials[pos];
        
        }

        mainMeshRend.material = wallMaterials[pos];

    }


   
}
