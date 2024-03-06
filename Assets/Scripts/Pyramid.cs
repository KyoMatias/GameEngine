using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Pyramid", menuName ="Pyramid")]
public class Pyramid : ScriptableObject
{
    public float len;
    public float wid;
    public float hei;

    public Vector3 root;

    public Vector3[] front
    {
        get{
            return new Vector3[]
            {
                new Vector3(root.x - (wid/50), root.y + (hei/2f), root.z + (len/0.65f)),
                new Vector3(root.x + (wid/2), root.y - (hei/2), root.z + (len/0.5f)),
                new Vector3(root.x - (wid/2), root.y - (hei/2), root.z + (len/0.5f))

            };
        }
    }

    public Vector3[] back
    {
        get
        {
            return new Vector3[]
            {
                new Vector3(root.x - (wid/50), root.y + (hei/2f), root.z + (len/0.65f)),
                new Vector3(root.x + (wid/2), root.y - (hei/2), root.z + (len/1f)),
                new Vector3(root.x - (wid/2), root.y - (hei/2), root.z + (len/1f))
            };
        }
    }

    public Vector3[] right
    {
        get{
            return new Vector3[]
            {
                new Vector3(root.x + (wid/2), root.y - (hei/2), root.z + (len/1f)),
                new Vector3(root.x + (wid/2), root.y - (hei/2), root.z - (len/-0.5f)),

            };
        }
    }

    public Vector3[] left
    {
        get{
            return new Vector3[]
            {
                new Vector3(root.x - (wid/2), root.y - (hei/2), root.z + (len/1f)),
                new Vector3(root.x - (wid/2), root.y - (hei/2), root.z - (len/-0.5f)),
            };
        }
    }

}
