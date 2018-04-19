using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class HealthDown : MonoBehaviour
{
    public Button healthdown;
    private float Size = 3.9f;
    public Text Health;
    public GameObject healthSlider;
    public Sprite Empty;
    public Sprite Half;
    public Sprite Full;
    public GameObject locatie;
    Image lives;
    

    void Start()
    {
        Button btn = healthdown.GetComponent<Button>();
        btn.onClick.AddListener(Damage);
        lives = locatie.GetComponent<Image>();
        lives.sprite = Full;
        Health.text = "Health: 100";
    }
    
    void Update()
    {
        if (Size <= 0)
        {
            Health.text = "Health: 0";
            Size = 0;
            lives.sprite = Empty;
            newScale(healthSlider, Size);
            SceneManager.LoadScene("Death Screen");
        }
        if (Size == 3.8f || Size == 4.8f)
        {
            lives.sprite = Full;
        }
        if (Size > 3.8f)
        {
            Size = 3.8f;
            newScale(healthSlider,Size);
        }
        if(Size == 2.8f)
        {
            Health.text = "Health: 70";
        }
        if(Size == 1.8f)
        {
            Health.text = "Health: 40";
            lives.sprite = Half;
        }
        if (Size == 0.8f)
        {
            Health.text = "Health: 15";
            
        }
        
    }

    private void Damage()
    {
        
        Size--;
        newScale(healthSlider,Size);
        Debug.Log(Size);

    }
    public void Heal()
    {
        Size++;
        newScale(healthSlider, Size);
        Debug.Log(Size);
    }

    public void newScale(GameObject Slider,float newSize)
    {

        float size = Slider.GetComponent<Renderer>().bounds.size.x;

        Vector3 rescale = Slider.transform.localScale;

        rescale.x = newSize * rescale.x / size;

        Slider.transform.localScale = rescale;

    }
}