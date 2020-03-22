
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    
    public string SceneToLoad;
    public Vector2 PlayerPosition;
    public VectorValue PlayerStorage;
    public GameObject FadeinPanel;
    public GameObject fadeOutPanel;
    public float FadeWait;

    private void Awake()
    {
        if (FadeinPanel != null)
        {
            GameObject panel = Instantiate(FadeinPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            PlayerStorage.InitialValue = PlayerPosition;
            StartCoroutine(FadeCo());
            //SceneManager.LoadScene(SceneToLoad);
        }
    }

    //masks fade in/out as loading screen
        
    public IEnumerator FadeCo()
    {
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(FadeWait);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneToLoad);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
    
}
