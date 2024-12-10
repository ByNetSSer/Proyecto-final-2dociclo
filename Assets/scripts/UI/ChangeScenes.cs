using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScenes : MonoBehaviour
{
    public Image Transicion;
    public string layoutwin;
    public string layoutlose;
    public bool ready;
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (dead)
        {
            Color color = Transicion.color;
            color.a = color.a + 5.0f * Time.deltaTime;
            Transicion.color = color;
        }
        if (ready )
        {
            Color color = Transicion.color;
            color.a = color.a + 5.0f * Time.deltaTime;
            Transicion.color = color;
        }
        if (ready && Transicion.color.a >= 1)
        {
            SceneManager.LoadScene(layoutwin);
        }
        if(Transicion.color.a >= 1.0f && dead && layoutlose != null)
        {
            SceneManager.LoadScene(layoutlose);
        }
        
    }

    public void LoadScene()
    {
        
        ready = true;
        
    }
    public void loadScenendead()
    {
        dead = true;
    }
    public void loasceneskip()
    {
        SceneManager.LoadScene(layoutwin);
    }
    public void loasceneskiplose()
    {
        SceneManager.LoadScene(layoutlose);
    }

}
