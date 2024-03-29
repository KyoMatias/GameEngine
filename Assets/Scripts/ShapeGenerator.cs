using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    [SerializeField] private Material _lineMaterial;
    [SerializeField] private float _focalLength;
    [SerializeField] private Shape[] _shapesToDraw;
    [SerializeField] private Cube drawcube;
    [SerializeField] private Pyramid drawpyr;

    private void OnPostRender()
    {

        GL.PushMatrix();
        GL.Begin(GL.LINES);
        _lineMaterial.SetPass(0);

        GL.Color(_lineMaterial.color);
        DrawShapes();



        GL.End();
        GL.PopMatrix();
    }
    private void DrawShapes()
    {
        foreach(Shape shape in _shapesToDraw)
        {
            var shapeZ = shape.transformPosition.z;
            var actualPerspective = _focalLength / (shapeZ + _focalLength);
        DrawCube();
        drawPyramid();
        }

    }

    void DrawCube()
    {
        DrawLine(drawcube.Frontside);
        DrawLine(drawcube.Backside);
        DrawLine(drawcube.Leftside);
        DrawLine(drawcube.rightSide);
    }

    void drawPyramid()
    {
        DrawLine(drawpyr.front);
        DrawLine(drawpyr.back);
        DrawLine(drawpyr.right);
        DrawLine(drawpyr.left);
    }



    private void DrawLine(Vector3[] vector3s)
    {
        var points = vector3s;
        for (int i = 0; i < points.Length; i++)
        {
            var nextShape = (i + 1) % points.Length;
            var point1 = new Vector3(points[i].x,
            points[i].y, 0) * (_focalLength / (points[i].z + _focalLength));
        

        GL.Vertex3(point1.x, point1.y, 0);

        var point2 = new Vector3(points[nextShape].x
        , points[nextShape].y , 0) * (_focalLength / (points[nextShape].z + _focalLength));

        GL.Vertex3(point2.x, point2.y,0);
        
        }
    }
}
