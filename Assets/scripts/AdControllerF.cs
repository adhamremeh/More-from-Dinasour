using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdControllerF : MonoBehaviour
{

    private string GoogleID = "3356737";
    public bool testMode;

    public GameObject timees;

    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(GoogleID, testMode);
    }

    public void PlayAD()
    {
        if (!Monetization.IsReady("video")) { return; }

        ShowAdPlacementContent videoAd = null;
        videoAd = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;

        if (videoAd == null) { return; }

        videoAd.Show();
    }
    public void PlayRewardedAD()
    {
        if (!Monetization.IsReady("rewardedVideo")) { return; }

        ShowAdPlacementContent RvideoAd = null;
        RvideoAd = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;

        if (RvideoAd == null) { return; }

        RvideoAd.Show(HandleShowResult);

    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                scoreandhighscore.finalcoins *= 2;
                timees.SetActive(false);
                Debug.Log("doubled");
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Failed:
                break;
        }
    }

}