using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickDestroy ()

    {

        Destroy(this.gameObject);
    }
}
