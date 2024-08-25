using System.Runtime.InteropServices;

namespace Mliybs.JNI;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct JavaVM
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct JVMFunctions
    {
        public readonly IntPtr Reserved0;

        public readonly IntPtr Reserved1;

        public readonly IntPtr Reserved2;

        // jint (JNICALL *DestroyJavaVM)(JavaVM *vm);
        public readonly delegate* unmanaged[Stdcall]<JavaVM*, Result> DestroyJavaVM;

        // jint (JNICALL *AttachCurrentThread)(JavaVM *vm, void **penv, void *args);
        public readonly delegate* unmanaged[Stdcall]<JavaVM*, out JNIEnv*, IntPtr, Result> AttachCurrentThread;

        // jint (JNICALL *DetachCurrentThread)(JavaVM *vm);
        public readonly delegate* unmanaged[Stdcall]<JavaVM*, Result> DetachCurrentThread;

        // jint (JNICALL *GetEnv)(JavaVM *vm, void **penv, jint version);
        public readonly delegate* unmanaged[Stdcall]<JavaVM*, out IntPtr, int, Result> GetEnv;

        // jint (JNICALL *AttachCurrentThreadAsDaemon)(JavaVM *vm, void **penv, void *args);
        public readonly delegate* unmanaged[Stdcall]<JavaVM*, out IntPtr, IntPtr, Result> AttachCurrentThreadAsDaemon;
    }

    public readonly JVMFunctions* Functions;
}

public enum Result
{
    Ok = 0,
    Unknown = -1,
    Detached = -2,
    Version = -3,
    OutOfMemory = -4,
    AlreadyExists = -5,
    InvalidArguments = -6
}