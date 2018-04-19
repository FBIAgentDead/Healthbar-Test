using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public Button Loadgame;
    public float Size = 3.8f;

    void Start()
    {
        Button btn = Loadgame.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("version1.0");
    }
}