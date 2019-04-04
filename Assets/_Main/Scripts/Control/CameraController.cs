using UnityEngine;

public class CameraController : MonoBehaviour {

  #region Private Components
  private new Camera camera;
  private new Transform transform;

  [SerializeField] private CamVariables camVariables;
  #endregion

  private void Awake () {
    transform = GetComponent<Transform> ();
    camera = Camera.main;
  }
  private void Start () {

  }
  private void Update () {

  }
  private void LateUpdate () {

  }

  #region Methods
  void MoveWASD () {
    float horizontal = Input.GetAxis ("Horizontal");
    float vertical = Input.GetAxis ("Vertical");
  }
  #endregion
}