using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Cube", menuName ="Cube")]
public class Cube : ScriptableObject
{
    public float Length;
    public float Width;
    public float Height;

    public Vector3 TransformRoot;
    public Vector3[] Frontside
    {
        get{
            return new Vector3[]
            {
                new Vector3(TransformRoot.x +(Width/2), TransformRoot.y +(Height/2), TransformRoot.z + (Length/2)),
                new Vector3(TransformRoot.x +(Width/2), TransformRoot.y -(Height/2), TransformRoot.z + (Length/2)),
                new Vector3(TransformRoot.x -(Width/2), TransformRoot.y -(Height/2), TransformRoot.z + (Length/2)),
                new Vector3(TransformRoot.x -(Width/2), TransformRoot.y +(Height/2), TransformRoot.z + (Length/2))
            };
        }
    }

    public Vector3[] Backside
    {
        get
        {
            return new Vector3[]
            {
                new Vector3(TransformRoot.x +(Width/2), TransformRoot.y +(Height/2), TransformRoot.z - (Length/2)),
                new Vector3(TransformRoot.x +(Width/2), TransformRoot.y -(Height/2), TransformRoot.z - (Length/2)),
                new Vector3(TransformRoot.x -(Width/2), TransformRoot.y -(Height/2), TransformRoot.z - (Length/2)),
                new Vector3(TransformRoot.x -(Width/2), TransformRoot.y +(Height/2), TransformRoot.z - (Length/2))

            };
        }
    }

    public Vector3[] Leftside
    {
        get{
            return new Vector3[]
            {
                Frontside[0], Frontside[1], Backside[1], Backside[0]
            };
        }
    }

       public Vector3[] rightSide
    {
        get
        {
            return new Vector3[]
            {
                Frontside[2], Frontside[3], Backside[3], Backside[2]
            };
        }
    }


}