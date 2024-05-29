# Demo of iOS AOT build issues & workarounds
Run `dotnet publish` for baseline error, which runs publish with the following properties:
- OutputType = Library
- PublishAot = true
- NativeLib = Shared
- PublishAotUsingRuntimePack = true

Run either `dotnet publish -p:DontSetNativeLib=true` or `dotnet publish -p:_IsAppleMobileLibraryMode=false` to work around the first set of errors (OutputType being overridden to Exe by Mono LibraryBuilder SDK). This should move on to a linker error about target conflicts.

Add `-p:SetSysroot=true` to work around the linker error.

See `ios_mvp_aot.csproj` for what the above flags set.
