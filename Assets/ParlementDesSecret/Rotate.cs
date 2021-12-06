using UnityEngine;

public class Rotate : MonoBehaviour
{

    private float temp, value;
    private bool lauched;
    private Quaternion originRotation;

    public void RotateDegree(float value)
    {
        temp = 0;
        this.value = value;
        originRotation = transform.rotation;
        lauched = true;
    }

    public void Update()
    {
        if(lauched)
        {
            transform.rotation = Quaternion.Lerp(originRotation, Quaternion.Euler(transform.rotation.x, transform.rotation.y + value, transform.rotation.z),temp);
            temp += Time.deltaTime;
            if(temp>=1)
            {
                lauched = false;
            }
        }

    }
}
