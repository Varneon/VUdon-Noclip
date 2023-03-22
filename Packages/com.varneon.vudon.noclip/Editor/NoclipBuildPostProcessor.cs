using JetBrains.Annotations;
using System.Linq;
using UnityEditor.Callbacks;
using UnityEngine;
using Varneon.VUdon.Noclip.Abstract;

namespace Varneon.VUdon.Noclip.Editor
{
    public static class NoclipBuildPostProcessor
    {
        [UsedImplicitly]
        [PostProcessScene(-1)]
        private static void PostProcessNoclip()
        {
            GameObject[] sceneRoots = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

            NoclipEventCallbackReceiver[] callbackReceivers = sceneRoots.SelectMany(r => r.GetComponentsInChildren<NoclipEventCallbackReceiver>(true)).ToArray();

            Noclip[] noclips = sceneRoots.SelectMany(r => r.GetComponentsInChildren<Noclip>(true)).ToArray();

            foreach(Noclip noclip in noclips)
            {
                noclip.callbackReceivers = callbackReceivers;
            }
        }
    }
}
