using UnityEngine;

public class MaClasseDeux : MonoBehaviour
{
    public MyClass myclass;
    public int i,y,e,r,t; 
    private void Start()
    {
        myclass.RemovePV(5);       
        
    }

    private void Update()
    {
        
    }

    public int Addition(int a, int b)
    {
        return a + b;
    }
}
