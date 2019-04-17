using UnityEngine;

namespace KnowledgeShareCommon
{
    public static class AssetFactory
    {
        public static void CreateSomeCoolAsset(string name)
        {
            Debug.Log(string.Format("Creating from cool asset called {0}", name));
        }
    }
}