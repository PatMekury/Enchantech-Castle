using UnityEngine;
using SpatialSys.UnitySDK;

public class PrizeSpawner : MonoBehaviour
{
    // Asset type and asset ID for the prize prefab (from your Spatial setup)
    //public AssetType assetType; // Example: "networkPrefab"
    //public string assetID;     // Example: GUID for your prefab
    public SpatialNetworkObject networkPrefab;

    // Preferred x, y, z position for spawning the prize
    public float xPosition;
    public float yPosition;
    public float zPosition;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Set the position using the provided x, y, z coordinates
        Vector3 spawnPosition = new Vector3(xPosition, yPosition, zPosition);

        // Set rotation to (0, 0, 0)
        Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);

        // Use the Spatial bridge to spawn the prefab object by its asset type and asset ID
       // SpatialBridge.spaceContentService.SpawnPrefabObject(assetType, assetID, spawnPosition, spawnRotation);
        SpatialBridge.spaceContentService.SpawnNetworkObject(networkPrefab, spawnPosition, spawnRotation);
    }
}