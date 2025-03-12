using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
   public void MoveToScene(int sceneID) 
   {
        Debug.Log("Scene switched." + sceneID);
        SceneManager.LoadScene(sceneID);
   }
}
