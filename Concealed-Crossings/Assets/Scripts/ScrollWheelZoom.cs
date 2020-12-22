using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWheelZoom : MonoBehaviour
{
    private Camera ZoomCamera;
    private float targetZoom;
    [SerializeField] private float zoomFactor = 3f;
    protected float scrollData;
    [SerializeField] private float zoomLerpSpeed = 10f;
    [SerializeField] private float zoomBoundsMin = 4.5f;
    [SerializeField] private float zoomBoundsMax = 8f;

    // Start is called before the first frame update
    void Start()
    {
        ZoomCamera = Camera.main;
        targetZoom = ZoomCamera.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        scrollData = Input.mouseScrollDelta.y;
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, zoomBoundsMin, zoomBoundsMax);
        ZoomCamera.fieldOfView = Mathf.Lerp(ZoomCamera.fieldOfView, targetZoom, Time.deltaTime * zoomLerpSpeed);
        
    }
}
