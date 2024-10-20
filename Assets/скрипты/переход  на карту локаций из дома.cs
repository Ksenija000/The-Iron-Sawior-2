using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class переходнакартулокацийиздома : MonoBehaviour
{
    private Animator anim;
    public int homeToMap;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

public void FadeTohome()
    {
        anim.SetTrigger("fade");
    }

public void OnFadeComplete()
    {
     SceneManager.LoadScene(homeToMap);
    }
}
