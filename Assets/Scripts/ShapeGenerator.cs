using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    [SerializeField] private Material _lineMaterial;
    [SerializeField] private float _focalLength;
    [SerializeField] private Shape[] _shapesToDraw;

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
            var ActualPerspective = _focalLength / shapeZ + _focalLength;

            for(int i = 0; i < shape.actualPoints.Length; i++)
            {
                var nextShape =(i +1)% shape.actualPoints.Length;

                var point1 = new Vector3 (shape.actualPoints[i].x, shape.actualPoints[i].y, 0) * ActualPerspective;
                GL.Vertex3(point1.x, point1.y, 0);

                var point2 = new Vector3(shape.actualPoints[nextShape].x, shape.actualPoints[nextShape].y,0) * ActualPerspective;
                GL.Vertex3(point2.x, point2.y,0);
            }
        }
    }
}
