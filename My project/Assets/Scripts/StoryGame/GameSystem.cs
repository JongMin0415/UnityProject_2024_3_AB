using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

namespace STORYGAME
{

#if UNITY_EDITOR
    [CustomEditor(typeof(GameSystem))]
    public class GameSystemEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GameSystem gameSystem = (GameSystem)target;

            if(GUILayout.Button("Reste Story Modes"))
            {
                gameSystem.ResetStoryModels();
            }
        }
    }

#endif

    public class GameSystem : MonoBehaviour
    {
        public static GameSystem instance;

        private void Awake()
        {
            instance = this;
        }

        public enum GAMESTATE
        {
            STORYSHOW,
            WALTSELECT,
            STORYEND,
            BATTLEMODE,
            BATTLEDONE,
            SHOPMODE,
            ENDMODE,
        }

        public GAMESTATE currentState;
        public StoryTableObject[] storyModels;
        public int currentStoryIndex = 1;

#if UNITY_EDITOR
        [ContextMenu("Rest Story Models")]
        public void ResetStoryModels()
        {
            storyModels = Resources.LoadAll<StoryTableObject>("");
        }
#endif
    }

}