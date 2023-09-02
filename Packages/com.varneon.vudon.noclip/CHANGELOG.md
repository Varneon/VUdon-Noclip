## [0.3.0-alpha.1] - 2023-09-02

### Added
- Dependency requirement for [VUdon Editors](https://github.com/Varneon/VUdon-Editors).
- AddComponentMenu item for adding noclip *(`Add Component` > `VUdon` > `Noclip`)*.

### Changed
- Migrated to use [VUdon Editors](https://github.com/Varneon/VUdon-Editors) for custom inspector.
- Updated UdonSharp dependency version definition to `1.1.9`.
- Moved the noclip prefab from root of the package to `Runtime/Prefabs/Noclip.prefab`.
- Disallowed multiple Noclip components on the same object.

### Removed
- Dependency requirement for [V-Inspector](https://github.com/Varneon/V-Inspector).
- Dependency requirement for [Neon Inspector](https://github.com/Varneon/Neon-Inspector).

### Fixed
- Continuous rotation on desktop caused by change in the returned data from [`VRCPlayerApi.GetRotation()`](https://creators.vrchat.com/worlds/udon/players/player-positions/#getrotation) since the latest VRChat update.
