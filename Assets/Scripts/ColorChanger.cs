using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public Material[] materials;
    public Renderer rend;
    bool is_hovered = false;
    int temp = 0;
    private int index=1;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_hovered == true)
        {
            if (materials.Length == 0)
            {
                return;
            }

            ++index;
            if (index == materials.Length + 1)
            {
                index = 1;
            }
            temp++;
            if (temp % 5 == 0)
            {
                rend.sharedMaterial = materials[index - 1];
                temp = 0;
            }

        }
    }
    public void Changing()
    {
        is_hovered = true;
        
    }
    public void ChangingExit()
    {
        is_hovered = false;
    }
}
