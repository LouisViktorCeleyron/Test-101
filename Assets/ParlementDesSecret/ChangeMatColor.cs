using UnityEngine;

public class ChangeMatColor : MonoBehaviour
{
    public MeshRenderer mr;
    public Color[] color;

    public void ChangeColor(int index)
    {
        mr.material.color = color[index];
    }

}
