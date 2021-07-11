using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Collections.LowLevel;

public class InActiveAwakeCaller : MonoBehaviour
{
    private void Awake()
    {
        /* Awake is called on this MonoBehaviour so Scene of this MonoBehaviour is being loaded now, we can call inactive objects in this scene */
        var interfaces = Utils.GetMonobehavioursImplements<IInActiveAwake>(gameObject.scene);

        for (int i = 0; i < interfaces.Count; ++i)
        {
            var _interface = interfaces[i];

            /* we know GetComponentsInChildren only returns Monobehaviours so we can cast it */
            var monoBehaviour = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<IInActiveAwake, MonoBehaviour>(ref _interface);

            if (monoBehaviour == null)
            {
                Debug.LogError("[InActiveAwakeCaller] Unsafe.As return null!");
                continue;
            }

            /* make sure object is not active because active objects's Awake function will be called by Unity already 
             if GameObject is enabled but MonoBehaviour is disabled, unity will still call Awake, so do not call in this situation
             */
            if (monoBehaviour.gameObject.activeInHierarchy == false)
            {
                _interface.InActiveAwake();
            }
        }
    }
}
