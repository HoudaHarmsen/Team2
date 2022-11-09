using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.SceneManagement.SceneManager;

  public class Scene_Manager : MonoBehaviour
  {
      public void LoadScenes(int scene) => LoadScene(scene);
      public void Addon_Scene(int scene) => LoadScene(scene, LoadSceneMode.Additive);
  }

