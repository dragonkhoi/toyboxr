using UnityEngine;
using UnityEngine.UI;
//using PolyToolkit;

public class PolyInterface : MonoBehaviour
{
    //[SerializeField] Image[] previewTiles;
    //[SerializeField] string searchQuery;

    //bool requestInflight;

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        RequestAssets();
    //    }
    //}

    //void RequestAssets()
    //{
    //    if (requestInflight)
    //    {
    //        Debug.LogWarning("Request denied - existing request still inflight!");
    //        return;
    //    }
    //    Debug.Log("Requesting assets...");

    //    PolyListAssetsRequest req = new PolyListAssetsRequest
    //    {
    //        // Search by keyword:
    //        keywords = searchQuery,
    //        // Only curated assets:
    //        curated = true,
    //        // Limit complexity to medium.
    //        maxComplexity = PolyMaxComplexityFilter.SIMPLE,
    //        // Only Blocks objects.
    //        formatFilter = PolyFormatFilter.BLOCKS,
    //        // Order from best to worst.
    //        orderBy = PolyOrderBy.BEST,
    //        // Up to 20 results per page.
    //        pageSize = 5
    //    };

    //    // Send the request.
    //    requestInflight = true;
    //    PolyApi.ListAssets(req, ListAssetsCallback);
    //}

    //void ListAssetsCallback(PolyStatusOr<PolyListAssetsResult> result)
    //{
    //    if (!result.Ok)
    //    {
    //        Debug.LogError("Failed to list assets. Reason: " + result.Status);
    //        return;
    //    }
    //    Debug.Log("Successfully listing asset!s");

    //    for (int i = 0; i < previewTiles.Length; ++i)
    //    {
    //        Debug.Log("ASSET: " + result.Value.assets[i].displayName);
    //        PolyApi.FetchThumbnail(result.Value.assets[i], FetchThumbnailCallback);
    //    }

    //    requestInflight = false;
    //}

    //void FetchThumbnailCallback(PolyAsset asset, PolyStatus status)
    //{
    //    if (!status.ok)
    //    {
    //        Debug.LogError("Failed to get thumbnail for: " + asset.displayName);
    //        return;
    //    }

    //    var texture = asset.thumbnailTexture;
    //    previewTiles[0].sprite = Sprite.Create(
    //        texture,
    //        new Rect(0, 0, texture.width, texture.height),
    //        new Vector2(0.5f, 0.5f));
    //}



    //// Callback invoked when the featured assets results are returned.
    //void GetAssetCallback(PolyStatusOr<PolyAsset> result)
    //{
    //    if (!result.Ok)
    //    {
    //        Debug.LogError("Failed to get assets. Reason: " + result.Status);
    //        return;
    //    }
    //    Debug.Log("Successfully got asset!");

    //    // Set the import options.
    //    PolyImportOptions options = PolyImportOptions.Default();
    //    // We want to rescale the imported mesh to a specific size.
    //    options.rescalingMode = PolyImportOptions.RescalingMode.FIT;
    //    // The specific size we want assets rescaled to (fit in a 5x5x5 box):
    //    options.desiredSize = 5.0f;
    //    // We want the imported assets to be recentered such that their centroid coincides with the origin:
    //    options.recenter = true;

    //    PolyApi.Import(result.Value, options, ImportAssetCallback);
    //}

    //// Callback invoked when the featured assets results are returned.
    //void GetAssetCallback(PolyStatusOr<PolyAsset> result)
    //{
    //    if (!result.Ok)
    //    {
    //        Debug.LogError("Failed to get assets. Reason: " + result.Status);
    //        return;
    //    }
    //    Debug.Log("Successfully got asset!");

    //    // Set the import options.
    //    PolyImportOptions options = PolyImportOptions.Default();
    //    // We want to rescale the imported mesh to a specific size.
    //    options.rescalingMode = PolyImportOptions.RescalingMode.FIT;
    //    // The specific size we want assets rescaled to (fit in a 5x5x5 box):
    //    options.desiredSize = 5.0f;
    //    // We want the imported assets to be recentered such that their centroid coincides with the origin:
    //    options.recenter = true;

    //    PolyApi.Import(result.Value, options, ImportAssetCallback);
    //}

    //// Callback invoked when an asset has just been imported.
    //void ImportAssetCallback(PolyAsset asset, PolyStatusOr<PolyImportResult> result)
    //{
    //    if (!result.Ok)
    //    {
    //        Debug.LogError("Failed to import asset. :( Reason: " + result.Status);
    //        return;
    //    }
    //    Debug.Log("Successfully imported asset!");

    //    // Here, you would place your object where you want it in your scene, and add any
    //    // behaviors to it as needed by your app. As an example, let's just make it
    //    // slowly rotate:
    //    result.Value.gameObject.AddComponent<Rotate>();
    //}
}
