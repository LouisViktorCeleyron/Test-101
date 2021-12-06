using UnityEngine;

public class MyClass : MonoBehaviour
{
    private int pv;
    public KeyCode spaceKey;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(spaceKey))
        {
            print("J'ai appuyé sur la space");
        }
    }

    public void RemovePV(int damage)
    {
        pv = pv - damage;
    }

    
}
