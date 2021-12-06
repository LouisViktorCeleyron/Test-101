using UnityEngine;
using UnityEngine.UI;
public class MyScript : MonoBehaviour
{
    public Image lifeBar;
    public float maxLife = 100;
    private float currentLife;

    public void Start()
    {
        currentLife = maxLife;
    }

    public void AddLife(float value)
    {
        ChangeLife(value);  
    }
    public void DecreaseLife(float value)
    {
        ChangeLife(-value);
    }

    private void ChangeLife(float value)
    {
        currentLife += value;
        SetLifeBar();
    }

    public void SetLifeBar()
    {
        lifeBar.fillAmount = currentLife / maxLife;
        if(lifeBar.fillAmount<0.5)
        {
            lifeBar.color = Color.yellow;
        }
        if (lifeBar.fillAmount < 0.2)
        {
            lifeBar.color = Color.red;
        }
    }

}
