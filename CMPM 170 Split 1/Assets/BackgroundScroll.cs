using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;

    void Start(){
        mat = GetComponent<Renderer>().material;
    }

    void Update(){
        offset += (Time.deltaTime * scrollSpeed) / 10f;

        //EDIT so only scrolls as player is moving
        
        mat.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}