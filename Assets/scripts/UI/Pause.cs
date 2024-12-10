using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool pause;
    public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetActive();
            
        }
        if (pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void SetActive()
    {
        pause = !pause;

    }
    public void popuspppppppppppppppppppppppppppp()
    {
        popup.SetActive(pause);
    }
}
