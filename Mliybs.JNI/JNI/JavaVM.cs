using System.Runtime.InteropServices;

namespace Mliybs.JNI;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct JavaVM
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct JVMFunctions
    {
        public readonly nint Reserved0;

        public readonly nint Reserved1;

        public readonly nint Reserved2;

        // jint (JNICALL *DestroyJavaVM)(JavaVM *vm);
        public readonly delegate* unmanaged<JavaVM*, Result> DestroyJavaVM;

        // jint (JNICALL *AttachCurrentThread)(JavaVM *vm, void **penv, void *args);
        public readonly delegate* unmanaged<JavaVM*, out JNIEnv*, nint, Result> AttachCurrentThread;

        // jint (JNICALL *DetachCurrentThread)(JavaVM *vm);
        public readonly delegate* unmanaged<JavaVM*, Result> DetachCurrentThread;

        // jint (JNICALL *GetEnv)(JavaVM *vm, void **penv, jint version);
        public readonly delegate* unmanaged<JavaVM*, out nint, int, Result> GetEnv;

        // jint (JNICALL *AttachCurrentThreadAsDaemon)(JavaVM *vm, void **penv, void *args);
        public readonly delegate* unmanaged<JavaVM*, out nint, nint, Result> AttachCurrentThreadAsDaemon;
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