using UnityEngine;

public class Parallax : MonoBehaviour
{

    private MeshRenderer _meshRenderer;
    [SerializeField] private float _parallaxSpeed = 1.0f; 
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        _meshRenderer.material.mainTextureOffset += new Vector2(_parallaxSpeed * Time.deltaTime, 0);
    }
}
