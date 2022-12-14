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

    private float _time;
    private Vector3 _currentPosition;
    private Vector3 _nextPosition;


    [SerializeField] private float _threshold = 0.5f;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _time += Time.deltaTime;
        Move();
    }


    private void Move()
    {
        transform.LookAt(_displayObject.transform);
        if (_time > _threshold)
        {
            _time = 0;
            _currentPosition = transform.position;
            _nextPosition = new Vector3(-_faceDetect.faceX / 640, 0, 0);
        }

        Vector3 cameraPosition = Vector3.Lerp(_currentPosition, _nextPosition, _time);
        transform.position = cameraPosition;
    }
}
