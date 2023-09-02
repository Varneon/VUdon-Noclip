# How to use Noclip

## [Unity Editor]

### Add Noclip into your scene using the preferred method

`a)` Add the Noclip prefab from `Runtime/Prefabs/Noclip.prefab` into your scene

`b)` Add the Noclip component by navigating to `Add Component` > `VUdon` > `Noclip`

## [In-Game]

### Enable Noclip

`a)` *(If double jump activation method allowed)* Enable noclip by pressing the jump button twice in rapid succession

`b)` *(If only API activation is allowed)* Enable noclip by invoking `_EnableNoclip()` or `_SetNoclipEnabled(true)` on the Noclip UdonBehaviour

### Disable Noclip

`a)` *(If double jump activation method allowed)* Disable noclip by pressing the jump button twice in rapid succession

`b)` *(If only API activation is allowed)* Disable noclip by invoking `_DisableNoclip()` or `_SetNoclipEnabled(false)` on the Noclip UdonBehaviour

### Movement

Noclip uses standard VRChat movement input for flying

### Vertical Movement

`VR`: Vertical input on non-dominant hand thumbstick / touchpad

`Desktop`: Defined input keys on the Noclip component
