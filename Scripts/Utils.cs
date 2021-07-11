using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utils
{
    /// <summary>
    /// iterates through currently loaded scenes and gets all types including inactives
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>list of T</returns>
    public static List<T> GetMonobehavioursImplements<T>()
    {
        List<T> resultList = new List<T>();

        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            Scene scene = SceneManager.GetSceneAt(i);

            foreach (var rootGameObject in scene.GetRootGameObjects())
            {
                foreach (var type in rootGameObject.GetComponentsInChildren<T>(true))
                {
                    resultList.Add(type);
                }
            }
        }

        return resultList;
    }

    /// <summary>
    /// gets all types including inactives
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="scene"></param>
    /// <returns>list of T</returns>
    public static List<T> GetMonobehavioursImplements<T>(Scene scene)
    {
        List<T> resultList = new List<T>();

        foreach (var rootGameObject in scene.GetRootGameObjects())
        {
            foreach (var type in rootGameObject.GetComponentsInChildren<T>(true))
            {
                resultList.Add(type);
            }
        }

        return resultList;
    }
}
