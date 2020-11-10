using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    
    public bool buttonClicked = false;

    void Update(){
        if (buttonClicked == true)
        {
           LoadNextLevel();
           buttonClicked = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadNextLevel(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }

    public void ButtonClicked(PointerEventData pointerEventData){
        if(pointerEventData.button == PointerEventData.InputButton.Right){
            buttonClicked = true;
        }
    }
}
