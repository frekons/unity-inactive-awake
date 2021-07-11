# Unity InActiveAwake
Unity does not call Awake on inactive GameObjects, a work-around for this.

## Usage

- Add IInActiveAwake interface to your MonoBehaviour, implement your void InActiveAwake()
- Drag and drop "Inactive Awake Caller" prefab to your scene (the scene that has the inactive GameObjects)
- That's it, your InActiveAwake() function will be called if the GameObject is inactive while scene loading

There is a test scene and script for this, you can check [go](TestScript.cs){:target="_blank" rel="noopener"} for a example

Note: You do NOT need a preLoadScene for that, I added it to test the result.
