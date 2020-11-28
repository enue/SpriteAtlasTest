using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    void Start()
    {
        var bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/hoge");
        var sceneName = System.IO.Path.GetFileNameWithoutExtension(bundle.GetAllScenePaths()[0]);
        SceneManager.LoadScene(sceneName);
    }
}
