using System.Collections;
using System.Collections.Generic;
using OpenCVForUnityExample;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMovementController : MonoBehaviour
{
    // カメラが向く対象（バーチャルディスプレイの画面）
    [SerializeField] private GameObject _displayObject;
    [SerializeField] private FaceDetect _faceDetect;
    
    
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }


    private void Move()
    {
        transform.LookAt(_displayObject.transform);
        transform.position = new Vector3(_faceDetect.faceX / 640, 0, 0);
    }
}
