using UnityEngine;
using SpatialSys.UnitySDK;

public class PrizeObject : MonoBehaviour
{
    public SpatialNetworkObject prizePrefab;

    // To track if the object has been clicked
    private bool isClaimed = false;

    // Function to be called when a player clicks on the object
    public void OnClick()
    {
        if (!isClaimed)
        {
            // Mark the object as claimed
            isClaimed = true;

            // Call a function to hide or destroy the object for all players
            ClaimPrize();
        }
    }

    // Function to handle claiming the prize
    private void ClaimPrize()
    {
        // Award prize logic goes here (e.g., send data to the player)
        Debug.Log("Prize claimed!");

        // Disable the object for all players
        //SpatialBridge.spaceContentService.DespawnNetworkObject(prizePrefab);
        SpatialBridge.spaceContentService.TakeOwnership(2);
    }

    // Example function to detect clicks
    private void OnMouseDown()
    {
        OnClick();
    }
}