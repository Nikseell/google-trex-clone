using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float _x, _y;
    public float x;
    public float multiplier;

    [SerializeField] private Score _score;

    private void Update()
    {
        x = multiplier * _score.gameSpeed;
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x, _y) * Time.deltaTime, _img.uvRect.size);
    }
}
