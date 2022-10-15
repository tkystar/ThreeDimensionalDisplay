using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WhoelTranformController : MonoBehaviour
{
   [SerializeField]
    VideoPlayer videoPlayer;

    [SerializeField]
    private Animator anim;

    void Start()
    {
        videoPlayer.loopPointReached += LoopPointReached;
    }
    public void LoopPointReached(VideoPlayer vp)
    {
        // 動画再生完了時の処理
        anim.SetBool("bool", true);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            videoPlayer.Play();
            anim.SetBool("bool", false);
        }
    }
}
