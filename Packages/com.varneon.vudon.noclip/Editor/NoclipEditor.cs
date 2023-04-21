using System.Collections.Generic;
using UdonSharp;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Varneon.VInspector;

namespace Varneon.VUdon.Noclip.Editor
{
    /// <summary>
    /// Custom inspector for Noclip prefab
    /// </summary>
    [CustomEditor(typeof(Noclip))]
    [IgnoreFieldsOfType(typeof(UdonSharpBehaviour))]
    public class NoclipEditor : InspectorBase
    {
        [SerializeField]
        private Texture2D banner;

        private const string FOLDOUT_PERSISTENCE_KEY = "Varneon/VUdon/Noclip/Editor/Foldouts";

        private List<Foldout> foldouts;

        protected override void OnInspectorVisualTreeAssetCloned(VisualElement root)
        {
            base.OnInspectorVisualTreeAssetCloned(root);

            root.Q("Banner").style.backgroundImage = banner;

            VisualElement inspectorPanel = root.Q("InspectorPanel");

            inspectorPanel.Add(new Foldout() { name = "Foldout_Settings", text = "Settings" });
            inspectorPanel.Add(new Foldout() { name = "Foldout_VR", text = "VR" });
            inspectorPanel.Add(new Foldout() { name = "Foldout_Desktop", text = "Desktop" });
            inspectorPanel.Add(new Foldout() { name = "Foldout_API", text = "API" });

            foldouts = root.Query<Foldout>().Build().ToList();

            if (EditorPrefs.HasKey(FOLDOUT_PERSISTENCE_KEY))
            {
                int states = EditorPrefs.GetInt(FOLDOUT_PERSISTENCE_KEY);

                for (int i = 0; i < foldouts.Count; i++)
                {
                    foldouts[i].value = (states & (1 << i)) != 0;
                }
            }

            APIDocumentationBuilder.BuildAPIDocumentation(root.Q<Foldout>("Foldout_API"), typeof(Noclip));
        }

        private void OnDestroy()
        {
            // If foldouts is null, then OnDestroy was most likely called by prefab override preview
            if(foldouts == null) { return; }

            int states = 0;

            for (int i = 0; i < foldouts.Count; i++)
            {
                if (foldouts[i].value)
                {
                    states |= 1 << i;
                }
            }

            EditorPrefs.SetInt(FOLDOUT_PERSISTENCE_KEY, states);
        }
    }
}
