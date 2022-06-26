using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTest : MonoBehaviour
{
    public Material mat;
    
    private MeshRenderer _meshRenderer;
    private MeshFilter _meshFilter;
    
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = gameObject.AddComponent<MeshRenderer>();
        _meshFilter = gameObject.AddComponent<MeshFilter>();
        StartDrawQuad();
    }

    private void StartDrawQuad()
    {
        _meshRenderer.material = mat;
        
        List<Vector3> verticesList = new List<Vector3>();
        verticesList.Add(new Vector3(0, 0, 0));
        verticesList.Add(new Vector3(0, 0, 1));
        verticesList.Add(new Vector3(1, 0, 1));
        verticesList.Add(new Vector3(1, 0, 0));

        List<int> triIndexList = new List<int>();
        triIndexList.Add(0);
        triIndexList.Add(1);
        triIndexList.Add(2);
        triIndexList.Add(2);
        triIndexList.Add(3);
        triIndexList.Add(0);

        List<Vector2> uvList = new List<Vector2>();
        uvList.Add(new Vector2(0, 0));
        uvList.Add(new Vector2(0,0.5f));
        uvList.Add(new Vector2(0.5f,0.5f));
        uvList.Add(new Vector2(0.5f,0));

        List<Color> verticesColorList = new List<Color>();
        verticesColorList.Add(Color.red);
        verticesColorList.Add(Color.green);
        verticesColorList.Add(Color.blue);
        verticesColorList.Add(Color.white);



        Mesh mesh = new Mesh();
        mesh.vertices = verticesList.ToArray();
        mesh.triangles = triIndexList.ToArray();
        mesh.uv = uvList.ToArray();
        mesh.colors = verticesColorList.ToArray();

        _meshFilter.mesh = mesh;
    }
}
