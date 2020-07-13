# ericsebesta/unity-unitytemplate-urp
A application framework for Unity Universal Render Pipeline-based projects, based off of Unity 2019.4.1f1.

Features:
- Derived from the default "Universal Render Pipeline" Unity starting project template.
- All assets removed except for the default skybox.
- Uses "main" as default branch.
- Up-to-date .gitignore and .gitattributes.
- Not-critical packages removed.
- Core packages updated (timeline, rider, etc.).
  - Note this does mean that this template uses non-verified packages.
- All standard directories initialized (using a placeholder file).
- Trival sample scene with very basic industry standard gameobject organization (cameras holder object, lights holder object, etc).
- Unit testing frameworks setup with sample trivial tests, included assembly definitions to support testing.
- 0 Rider inspection errors/warnings/suggestions/etc.
- Reasonable default player settings (windowed, no splash screen, etc).
- Supports code coverage using the new Code Coverage package
  - 100% coverage of sample runtime and editor code as an example
  - Note: this version of code coverage will inject absolute paths into its package settings on open, so you'll see a file change
