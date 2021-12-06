using UnityEngine;

public class SetRotation : MonoBehaviour
{
    public Vector3 origin, target;
    
 
    public void RotateLerp(float delta)
    {
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(origin), Quaternion.Euler(target), delta);
    }


}
