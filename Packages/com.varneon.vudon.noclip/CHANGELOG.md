## [0.3.0-alpha.1] - 2023-09-02

### Added
- Dependency requirement for [VUdon Editors](https://github.com/Varneon/VUdon-Editors) (#16).
- AddComponentMenu item for adding noclip

### Changed
- Migrated to use [VUdon Editors](https://github.com/Varneon/VUdon-Editors) for custom inspector (#16).
- Updated UdonSharp dependency version definition from `1.0.1` to `1.1.9`
- Moved the noclip prefab from root of the package to `Runtime/Prefabs/Noclip.prefab`

### Removed
- Dependency requirement for [V-Inspector](https://github.com/Varneon/V-Inspector) (#16).
- Dependency requirement for [Neon Inspector](https://github.com/Varneon/Neon-Inspector) (#16).

### Fixed
- Continuous rotation on desktop caused by change in the returned data from `VRCPlayerApi.GetRotation()` since the latest VRChat update (#17).
