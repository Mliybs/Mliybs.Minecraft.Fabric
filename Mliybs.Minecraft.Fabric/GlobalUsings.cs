global using System.Runtime.InteropServices;

global using Net.FabricMC.Loader.Api;

global using Mliybs.JNI;
global using Mliybs.Minecraft.Fabric;
global using Mliybs.Minecraft.Fabric.Internals;
global using Java.Lang;

global using static Mliybs.Minecraft.Fabric.Loader;
global using Names = (string OriginName, string OriginSignature, string MapName, string MapSignature);
global using unsafe MethodVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, void>;
global using unsafe MethodPtrVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, void>;
global using unsafe Method2PtrVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, void>;
global using unsafe Method3PtrVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, void>;
global using unsafe Method4PtrVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint, void>;
global using unsafe Method5PtrVoid = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint, nint, void>;
global using unsafe Method = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint>;
global using unsafe MethodPtr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint>;
global using unsafe Method2Ptr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint>;
global using unsafe Method3Ptr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint>;
global using unsafe Method4Ptr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint, nint>;
global using unsafe Method5Ptr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint, nint, nint>;
global using unsafe Method6Ptr = delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, nint, nint, nint, nint, nint>;