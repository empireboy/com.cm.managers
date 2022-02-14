using System.Text.RegularExpressions;
using UnityEngine;

namespace CM.Managers
{
    public class AssetManager : MonoBehaviour
    {
        public static AssetManager Instance { get; private set; }

        [SerializeField]
        private AssetContainerSO _assetContainerSO;

        public T GetAsset<T>(string name) where T : Object
        {
            foreach (Object asset in _assetContainerSO.assets)
            {
                // Evaluate both names with all spaces removed
                if (string.Equals(Regex.Replace(name, @"s", ""), Regex.Replace(asset.name, @"s", "")))
                {
                    return asset as T;
                }
            }

            return null;
        }

        private void Awake()
        {
            if (!Instance)
                Instance = this;
            else
                Destroy(this);
        }
    }
}