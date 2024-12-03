using System.Runtime.InteropServices;

namespace Mliybs.JNI;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct JNIEnv
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JNIFunctions
    {
        public readonly nint Reserved0;

        public readonly nint Reserved1;

        public readonly nint Reserved2;

        public readonly nint Reserved3;

        // jint (JNICALL *GetVersion)(JNIEnv *env);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int> GetVersion;

        // jclass (JNICALL *DefineClass) (JNIEnv* env, const char* name, jobject loader, const jbyte* buf, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, int, nint> DefineClass;

        // jclass (JNICALL *FindClass) (JNIEnv* env, const char* name);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, string, nint> FindClass;

        // jmethodID (JNICALL *FromReflectedMethod) (JNIEnv* env, jobject method);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> FromReflectedMethod;

        // jfieldID (JNICALL *FromReflectedField) (JNIEnv* env, jobject field);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> FromReflectedField;

        // jobject (JNICALL *ToReflectedMethod) (JNIEnv* env, jclass cls, jmethodID methodID, jboolean isStatic);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool, nint> ToReflectedMethod;

        // jclass (JNICALL *GetSuperclass) (JNIEnv* env, jclass sub);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> GetSuperClass;

        // jboolean (JNICALL *IsAssignableFrom) (JNIEnv* env, jclass sub, jclass sup);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool> IsAssignableFrom;

        // jobject (JNICALL *ToReflectedField) (JNIEnv* env, jclass cls, jfieldID fieldID, jboolean isStatic);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool, nint> ToReflectedField;

        // jint (JNICALL *Throw) (JNIEnv* env, jthrowable obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> Throw;

        // jint (JNICALL *ThrowNew) (JNIEnv* env, jclass clazz, const char* msg);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int> ThrowNew;

        // jthrowable (JNICALL *ExceptionOccurred) (JNIEnv* env);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint> ExceptionOccurred;

        // void (JNICALL *ExceptionDescribe) (JNIEnv* env);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, void> ExceptionDescribe;

        // void (JNICALL *ExceptionClear) (JNIEnv* env);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, void> ExceptionClear;

        // void (JNICALL *FatalError) (JNIEnv* env, const char* msg);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, void> FatalError;

        // jint (JNICALL *PushLocalFrame) (JNIEnv* env, jint capacity);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, int> PushLocalFrame;

        // jobject (JNICALL *PopLocalFrame) (JNIEnv* env, jobject result);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> PopLocalFrame;

        // jobject (JNICALL *NewGlobalRef) (JNIEnv* env, jobject lobj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> NewGlobalRef;

        // void (JNICALL *DeleteGlobalRef) (JNIEnv* env, jobject gref);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, void> DeleteGlobalRef;

        // void (JNICALL *DeleteLocalRef) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, void> DeleteLocalRef;

        // jboolean (JNICALL *IsSameObject) (JNIEnv* env, jobject obj1, jobject obj2);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool> IsSameObject;

        // jobject (JNICALL *NewLocalRef) (JNIEnv* env, jobject ref);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> NewLocalRef;

        // jint (JNICALL *EnsureLocalCapacity) (JNIEnv* env, jint capacity);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, int> EnsureLocalCapacity;

        // jobject (JNICALL *AllocObject) (JNIEnv* env, jclass clazz);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> AllocObject;

        // jobject (JNICALL *NewObject) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint NewObject;

        // jobject (JNICALL *NewObjectV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint NewObjectV;

        // jobject (JNICALL *NewObjectA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, nint> NewObjectA;

        // jclass (JNICALL *GetObjectClass) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> GetObjectClass;

        // jboolean (JNICALL *IsInstanceOf) (JNIEnv* env, jobject obj, jclass clazz);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool> IsInstanceOf;

        // jmethodID (JNICALL *GetMethodID) (JNIEnv* env, jclass clazz, const char* name, const char* sig);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, string, string, nint> GetMethodID; // 只出现ASCII字符所以使用自动封送

        // jobject (JNICALL *CallObjectMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallObjectMethod;

        // jobject (JNICALL *CallObjectMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallObjectMethodV;

        // jobject (JNICALL *CallObjectMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, nint> CallObjectMethodA;

        // jboolean (JNICALL *CallBooleanMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallBooleanMethod;

        // jboolean (JNICALL *CallBooleanMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallBooleanMethodV;

        // jboolean (JNICALL *CallBooleanMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, bool> CallBooleanMethodA;

        // jbyte (JNICALL *CallByteMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallByteMethod;

        // jbyte (JNICALL *CallByteMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallByteMethodV;

        // jbyte (JNICALL *CallByteMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, sbyte> CallByteMethodA;

        // jchar (JNICALL *CallCharMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallCharMethod;

        // jchar (JNICALL *CallCharMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallCharMethodV;

        // jchar (JNICALL *CallCharMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, char> CallCharMethodA;

        // jshort (JNICALL *CallShortMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallShortMethod;

        // jshort (JNICALL *CallShortMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallShortMethodV;

        // jshort (JNICALL *CallShortMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, short> CallShortMethodA;

        // jint (JNICALL *CallIntMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallIntMethod;

        // jshort (JNICALL *CallShortMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallIntMethodV;

        // jint (JNICALL *CallIntMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, int> CallIntMethodA;

        // jlong (JNICALL *CallLongMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallLongMethod;

        // jlong (JNICALL *CallLongMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallLongMethodV;

        // jlong (JNICALL *CallLongMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, long> CallLongMethodA;

        // jfloat (JNICALL *CallFloatMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallFloatMethod;

        // jfloat (JNICALL *CallFloatMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallFloatMethodV;

        // jfloat (JNICALL *CallFloatMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, float> CallFloatMethodA;

        // jdouble (JNICALL *CallDoubleMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallDoubleMethod;

        // jdouble (JNICALL *CallDoubleMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallDoubleMethodV;

        // jdouble (JNICALL *CallDoubleMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, double> CallDoubleMethodA;

        // void (JNICALL *CallVoidMethod) (JNIEnv* env, jobject obj, jmethodID methodID, ...);
        public readonly nint CallVoidMethod;

        // void (JNICALL *CallVoidMethodV) (JNIEnv* env, jobject obj, jmethodID methodID, va_list args);
        public readonly nint CallVoidMethodV;

        // void (JNICALL *CallVoidMethodA) (JNIEnv* env, jobject obj, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, void> CallVoidMethodA;

        // jobject (JNICALL *CallNonvirtualObjectMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualObjectMethod;

        // jobject (JNICALL *CallNonvirtualObjectMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualObjectMethodV;

        // jobject (JNICALL *CallNonvirtualObjectMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, nint> CallNonvirtualObjectMethodA;

        // jboolean (JNICALL *CallNonvirtualBooleanMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualBooleanMethod;

        // jboolean (JNICALL *CallNonvirtualBooleanMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualBooleanMethodV;

        // jboolean (JNICALL *CallNonvirtualBooleanMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, bool> CallNonvirtualBooleanMethodA;

        // jbyte (JNICALL *CallNonvirtualByteMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualByteMethod;

        // jbyte (JNICALL *CallNonvirtualByteMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualByteMethodV;

        // jbyte (JNICALL *CallNonvirtualByteMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, sbyte> CallNonvirtualByteMethodA;

        // jchar (JNICALL *CallNonvirtualCharMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualCharMethod;

        // jchar (JNICALL *CallNonvirtualCharMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualCharMethodV;

        // jchar (JNICALL *CallNonvirtualCharMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, char> CallNonvirtualCharMethodA;

        // jshort (JNICALL *CallNonvirtualShortMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualShortMethod;

        // jshort (JNICALL *CallNonvirtualShortMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualShortMethodV;

        // jshort (JNICALL *CallNonvirtualShortMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, short> CallNonvirtualShortMethodA;

        // jint (JNICALL *CallNonvirtualIntMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualIntMethod;

        // jint (JNICALL *CallNonvirtualIntMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualIntMethodV;

        // jint (JNICALL *CallNonvirtualIntMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, int> CallNonvirtualIntMethodA;

        // jlong (JNICALL *CallNonvirtualLongMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualLongMethod;

        // jlong (JNICALL *CallNonvirtualLongMethodV)(JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualLongMethodV;

        // jlong (JNICALL *CallNonvirtualLongMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, long> CallNonvirtualLongMethodA;

        // jfloat (JNICALL *CallNonvirtualFloatMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualFloatMethod;

        // jfloat (JNICALL *CallNonvirtualFloatMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualFloatMethodV;

        // jfloat (JNICALL *CallNonvirtualFloatMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, float> CallNonvirtualFloatMethodA;

        // jdouble (JNICALL *CallNonvirtualDoubleMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualDoubleMethod;

        // jdouble (JNICALL *CallNonvirtualDoubleMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualDoubleMethodV;

        // jdouble (JNICALL *CallNonvirtualDoubleMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, double> CallNonvirtualDoubleMethodA;

        // void (JNICALL *CallNonvirtualVoidMethod) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallNonvirtualVoidMethod;

        // void (JNICALL *CallNonvirtualVoidMethodV) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallNonvirtualVoidMethodV;

        // void (JNICALL *CallNonvirtualVoidMethodA) (JNIEnv* env, jobject obj, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, JValue*, void> CallNonvirtualVoidMethodA;

        // jfieldID (JNICALL *GetFieldID) (JNIEnv* env, jclass clazz, const char* name, const char* sig);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, nint> GetFieldID;

        // jobject (JNICALL *GetObjectField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint> GetObjectField;

        // jboolean (JNICALL *GetBooleanField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool> GetBooleanField;

        // jbyte (JNICALL *GetByteField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, sbyte> GetByteField;

        // jchar (JNICALL *GetCharField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, char> GetCharField;

        // jshort (JNICALL *GetShortField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, short> GetShortField;

        // jint (JNICALL *GetIntField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int> GetIntField;

        // jlong (JNICALL *GetLongField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, long> GetLongField;

        // jfloat (JNICALL *GetFloatField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, float> GetFloatField;

        // jdouble (JNICALL *GetDoubleField) (JNIEnv* env, jobject obj, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, double> GetDoubleField;

        // void (JNICALL *SetObjectField) (JNIEnv* env, jobject obj, jfieldID fieldID, jobject val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, void> SetObjectField;

        // void (JNICALL *SetBooleanField) (JNIEnv* env, jobject obj, jfieldID fieldID, jboolean val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool, void> SetBooleanField;

        // void (JNICALL *SetByteField) (JNIEnv* env, jobject obj, jfieldID fieldID, jbyte val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, sbyte, void> SetByteField;

        // void (JNICALL *SetCharField) (JNIEnv* env, jobject obj, jfieldID fieldID, jchar val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, char, void> SetCharField;

        // void (JNICALL *SetShortField) (JNIEnv* env, jobject obj, jfieldID fieldID, jshort val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, short, void> SetShortField;

        // void (JNICALL *SetIntField) (JNIEnv* env, jobject obj, jfieldID fieldID, jint val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int, void> SetIntField;

        // void (JNICALL *SetLongField) (JNIEnv* env, jobject obj, jfieldID fieldID, jlong val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, long, void> SetLongField;

        // void (JNICALL *SetFloatField) (JNIEnv* env, jobject obj, jfieldID fieldID, jfloat val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, float, void> SetFloatField;

        // void (JNICALL *SetDoubleField) (JNIEnv* env, jobject obj, jfieldID fieldID, jdouble val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, double, void> SetDoubleField;

        // jmethodID (JNICALL *GetStaticMethodID) (JNIEnv* env, jclass clazz, const char* name, const char* sig);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, string, string, nint> GetStaticMethodID; // 只出现ASCII字符所以使用自动封送

        // jobject (JNICALL *CallStaticObjectMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticObjectMethod;

        // jobject (JNICALL *CallStaticObjectMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticObjectMethodV;

        // jobject (JNICALL *CallStaticObjectMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, nint> CallStaticObjectMethodA;

        // jboolean (JNICALL *CallStaticBooleanMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticBooleanMethod;

        // jboolean (JNICALL *CallStaticBooleanMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticBooleanMethodV;

        // jboolean (JNICALL *CallStaticBooleanMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, bool> CallStaticBooleanMethodA;

        // jbyte (JNICALL *CallStaticByteMethod)(JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticByteMethod;

        // jbyte (JNICALL *CallStaticByteMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticByteMethodV;

        // jbyte (JNICALL *CallStaticByteMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, sbyte> CallStaticByteMethodA;

        // jchar (JNICALL *CallStaticCharMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticCharMethod;

        // jchar (JNICALL *CallStaticCharMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticCharMethodV;

        // jchar (JNICALL *CallStaticCharMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, char> CallStaticCharMethodA;

        // jshort (JNICALL *CallStaticShortMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticShortMethod;

        // jshort (JNICALL *CallStaticShortMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticShortMethodV;

        // jshort (JNICALL *CallStaticShortMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, short> CallStaticShortMethodA;

        // jint (JNICALL *CallStaticIntMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticIntMethod;

        // jint (JNICALL *CallStaticIntMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticIntMethodV;

        // jint (JNICALL *CallStaticIntMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, int> CallStaticIntMethodA;

        // jlong (JNICALL *CallStaticLongMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticLongMethod;

        // jlong (JNICALL *CallStaticLongMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticLongMethodV;

        // jlong (JNICALL *CallStaticLongMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, long> CallStaticLongMethodA;

        // jfloat (JNICALL *CallStaticFloatMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticFloatMethod;

        // jfloat (JNICALL *CallStaticFloatMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticFloatMethodV;

        // jfloat (JNICALL *CallStaticFloatMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, float> CallStaticFloatMethodA;

        // jdouble (JNICALL *CallStaticDoubleMethod) (JNIEnv* env, jclass clazz, jmethodID methodID, ...);
        public readonly nint CallStaticDoubleMethod;

        // jdouble (JNICALL *CallStaticDoubleMethodV) (JNIEnv* env, jclass clazz, jmethodID methodID, va_list args);
        public readonly nint CallStaticDoubleMethodV;

        // jdouble (JNICALL *CallStaticDoubleMethodA) (JNIEnv* env, jclass clazz, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, double> CallStaticDoubleMethodA;

        // void (JNICALL *CallStaticVoidMethod) (JNIEnv* env, jclass cls, jmethodID methodID, ...);
        public readonly nint CallStaticVoidMethod;

        // void (JNICALL *CallStaticVoidMethodV) (JNIEnv* env, jclass cls, jmethodID methodID, va_list args);
        public readonly nint CallStaticVoidMethodV;

        // void (JNICALL *CallStaticVoidMethodA) (JNIEnv* env, jclass cls, jmethodID methodID, const jvalue* args);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, JValue*, void> CallStaticVoidMethodA;

        // jfieldID (JNICALL *GetStaticFieldID) (JNIEnv* env, jclass clazz, const char* name, const char* sig);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, string, string, nint> GetStaticFieldID; // 只出现ASCII字符所以使用自动封送

        // jobject (JNICALL *GetStaticObjectField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint> GetStaticObjectField;

        // jboolean (JNICALL *GetStaticBooleanField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool> GetStaticBooleanField;

        // jbyte (JNICALL *GetStaticByteField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, sbyte> GetStaticByteField;

        // jchar (JNICALL *GetStaticCharField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, char> GetStaticCharField;

        // jshort (JNICALL *GetStaticShortField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, short> GetStaticShortField;

        // jint (JNICALL *GetStaticIntField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int> GetStaticIntField;

        // jlong (JNICALL *GetStaticLongField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, long> GetStaticLongField;

        // jfloat (JNICALL *GetStaticFloatField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, float> GetStaticFloatField;

        // jdouble (JNICALL *GetStaticDoubleField) (JNIEnv* env, jclass clazz, jfieldID fieldID);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, double> GetStaticDoubleField;

        // void (JNICALL *SetStaticObjectField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jobject value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, void> SetStaticObjectField;

        // void (JNICALL *SetStaticBooleanField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jboolean value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, bool, void> SetStaticBooleanField;

        // void (JNICALL *SetStaticByteField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jbyte value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, sbyte, void> SetStaticByteField;

        // void (JNICALL *SetStaticCharField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jchar value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, char, void> SetStaticCharField;

        // void (JNICALL *SetStaticShortField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jshort value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, short, void> SetStaticShortField;

        // void (JNICALL *SetStaticIntField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jint value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int, void> SetStaticIntField;

        // void (JNICALL *SetStaticLongField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jlong value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, long, void> SetStaticLongField;

        // void (JNICALL *SetStaticFloatField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jfloat value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, float, void> SetStaticFloatField;

        // void (JNICALL *SetStaticDoubleField) (JNIEnv* env, jclass clazz, jfieldID fieldID, jdouble value);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, double, void> SetStaticDoubleField;

        // jstring (JNICALL *NewString) (JNIEnv* env, const jchar* unicode, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, char*, int, nint> NewString;

        // jsize (JNICALL *GetStringLength) (JNIEnv* env, jstring str);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> GetStringLength;

        // const jchar *(JNICALL *GetStringChars) (JNIEnv* env, jstring str, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, char*> GetStringChars;

        // void (JNICALL *ReleaseStringChars) (JNIEnv* env, jstring str, const jchar* chars);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, char*, void> ReleaseStringChars;

        // jstring (JNICALL *NewStringUTF) (JNIEnv* env, const char* utf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, byte*, nint> NewStringUTF;

        // jsize (JNICALL *GetStringUTFLength) (JNIEnv* env, jstring str);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> GetStringUTFLength;

        // const char* (JNICALL *GetStringUTFChars) (JNIEnv* env, jstring str, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, nint> GetStringUTFChars;

        // void (JNICALL *ReleaseStringUTFChars) (JNIEnv* env, jstring str, const char* chars);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, void> ReleaseStringUTFChars;

        // jsize (JNICALL *GetArrayLength) (JNIEnv* env, jarray array);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> GetArrayLength;

        // jobjectArray (JNICALL *NewObjectArray) (JNIEnv* env, jsize len, jclass clazz, jobject init);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint, nint, nint> NewObjectArray;

        // jobject (JNICALL *GetObjectArrayElement) (JNIEnv* env, jobjectArray array, jsize index);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, nint> GetObjectArrayElement;

        // void (JNICALL *SetObjectArrayElement) (JNIEnv* env, jobjectArray array, jsize index, jobject val);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, nint, void> SetObjectArrayElement;

        // jbooleanArray (JNICALL *NewBooleanArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewBooleanArray;

        // jbyteArray (JNICALL *NewByteArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewByteArray;

        // jcharArray (JNICALL *NewCharArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewCharArray;

        // jshortArray (JNICALL *NewShortArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewShortArray;

        // jintArray (JNICALL *NewIntArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewIntArray;

        // jlongArray (JNICALL *NewLongArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewLongArray;

        // jfloatArray (JNICALL *NewFloatArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewFloatArray;

        // jdoubleArray (JNICALL *NewDoubleArray) (JNIEnv* env, jsize len);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, int, nint> NewDoubleArray;

        // jboolean * (JNICALL *GetBooleanArrayElements) (JNIEnv* env, jbooleanArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, bool*> GetBooleanArrayElements;

        // jbyte * (JNICALL *GetByteArrayElements) (JNIEnv* env, jbyteArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, sbyte*> GetByteArrayElements;

        // jchar * (JNICALL *GetCharArrayElements) (JNIEnv* env, jcharArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, char*> GetCharArrayElements;

        // jshort * (JNICALL *GetShortArrayElements) (JNIEnv* env, jshortArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, short*> GetShortArrayElements;

        // jint * (JNICALL *GetIntArrayElements) (JNIEnv* env, jintArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, int*> GetIntArrayElements;

        // jlong * (JNICALL *GetLongArrayElements) (JNIEnv* env, jlongArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, long*> GetLongArrayElements;

        // jfloat * (JNICALL *GetFloatArrayElements) (JNIEnv* env, jfloatArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, float*> GetFloatArrayElements;

        // jdouble * (JNICALL *GetDoubleArrayElements) (JNIEnv* env, jdoubleArray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, double*> GetDoubleArrayElements;

        // void (JNICALL *ReleaseBooleanArrayElements) (JNIEnv* env, jbooleanArray array, jboolean* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, bool*, int, void> ReleaseBooleanArrayElements;

        // void (JNICALL *ReleaseByteArrayElements) (JNIEnv* env, jbyteArray array, jbyte* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, sbyte*, int, void> ReleaseByteArrayElements;

        // void (JNICALL *ReleaseCharArrayElements) (JNIEnv* env, jcharArray array, jchar* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, char*, int, void> ReleaseCharArrayElements;

        // void (JNICALL *ReleaseShortArrayElements) (JNIEnv* env, jshortArray array, jshort* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, short*, int, void> ReleaseShortArrayElements;

        // void (JNICALL *ReleaseIntArrayElements) (JNIEnv* env, jintArray array, jint* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int*, int, void> ReleaseIntArrayElements;

        // void (JNICALL *ReleaseLongArrayElements) (JNIEnv* env, jlongArray array, jlong* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, long*, int, void> ReleaseLongArrayElements;

        // void (JNICALL *ReleaseFloatArrayElements) (JNIEnv* env, jfloatArray array, jfloat* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, float*, int, void> ReleaseFloatArrayElements;

        // void (JNICALL *ReleaseDoubleArrayElements) (JNIEnv* env, jdoubleArray array, jdouble* elems, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, double*, int, void> ReleaseDoubleArrayElements;

        // void (JNICALL *GetBooleanArrayRegion) (JNIEnv* env, jbooleanArray array, jsize start, jsize l, jboolean* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, bool*, void> GetBooleanArrayRegion;

        // void (JNICALL *GetByteArrayRegion) (JNIEnv* env, jbyteArray array, jsize start, jsize len, jbyte* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, sbyte*, void> GetByteArrayRegion;

        // void (JNICALL *GetCharArrayRegion) (JNIEnv* env, jcharArray array, jsize start, jsize len, jchar* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, char*, void> GetCharArrayRegion;

        // void (JNICALL *GetShortArrayRegion) (JNIEnv* env, jshortArray array, jsize start, jsize len, jshort* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, short*, void> GetShortArrayRegion;

        // void (JNICALL *GetIntArrayRegion) (JNIEnv* env, jintArray array, jsize start, jsize len, jint* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, int*, void> GetIntArrayRegion;

        // void (JNICALL *GetLongArrayRegion) (JNIEnv* env, jlongArray array, jsize start, jsize len, jlong* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, long*, void> GetLongArrayRegion;

        // void (JNICALL *GetFloatArrayRegion) (JNIEnv* env, jfloatArray array, jsize start, jsize len, jfloat* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, float*, void> GetFloatArrayRegion;

        // void (JNICALL *GetDoubleArrayRegion) (JNIEnv* env, jdoubleArray array, jsize start, jsize len, jdouble* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, double*, void> GetDoubleArrayRegion;

        // void (JNICALL *SetBooleanArrayRegion) (JNIEnv* env, jbooleanArray array, jsize start, jsize l, const jboolean* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, bool*, void> SetBooleanArrayRegion;

        // void (JNICALL *SetByteArrayRegion) (JNIEnv* env, jbyteArray array, jsize start, jsize len, const jbyte* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, sbyte*, void> SetByteArrayRegion;

        // void (JNICALL *SetCharArrayRegion) (JNIEnv* env, jcharArray array, jsize start, jsize len, const jchar* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, char*, void> SetCharArrayRegion;

        // void (JNICALL *SetShortArrayRegion) (JNIEnv* env, jshortArray array, jsize start, jsize len, const jshort* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, short*, void> SetShortArrayRegion;

        // void (JNICALL *SetIntArrayRegion) (JNIEnv* env, jintArray array, jsize start, jsize len, const jint* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, int*, void> SetIntArrayRegion;

        // void (JNICALL *SetLongArrayRegion) (JNIEnv* env, jlongArray array, jsize start, jsize len, const jlong* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, long*, void> SetLongArrayRegion;

        // void (JNICALL *SetFloatArrayRegion) (JNIEnv* env, jfloatArray array, jsize start, jsize len, const jfloat* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, float*, void> SetFloatArrayRegion;

        // void (JNICALL *SetDoubleArrayRegion) (JNIEnv* env, jdoubleArray array, jsize start, jsize len, const jdouble* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, double*, void> SetDoubleArrayRegion;

        // jint (JNICALL *RegisterNatives) (JNIEnv* env, jclass clazz, const JNINativeMethod* methods, jint nMethods);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int> RegisterNatives;

        // jint (JNICALL *UnregisterNatives) (JNIEnv* env, jclass clazz);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> UnregisterNatives;

        // jint (JNICALL *MonitorEnter) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> MonitorEnter;

        // jint (JNICALL *MonitorExit) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int> MonitorExit;

        // jint (JNICALL *GetJavaVM) (JNIEnv* env, JavaVM** vm);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, out JavaVM*, Result> GetJavaVM;

        // void (JNICALL *GetStringRegion) (JNIEnv* env, jstring str, jsize start, jsize len, jchar* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, char*, void> GetStringRegion;

        // void (JNICALL *GetStringUTFRegion) (JNIEnv* env, jstring str, jsize start, jsize len, char* buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, int, int, byte*, void> GetStringUTFRegion;

        // void * (JNICALL *GetPrimitiveArrayCritical) (JNIEnv* env, jarray array, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, nint> GetPrimitiveArrayCritical;

        // void (JNICALL *ReleasePrimitiveArrayCritical) (JNIEnv* env, jarray array, void* carray, jint mode);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, int, void> ReleasePrimitiveArrayCritical;

        // const jchar * (JNICALL *GetStringCritical) (JNIEnv* env, jstring string, jboolean* isCopy);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, out bool, char*> GetStringCritical;

        // void (JNICALL *ReleaseStringCritical) (JNIEnv* env, jstring string, const jchar* cstring);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, char*, void> ReleaseStringCritical;

        // jweak (JNICALL *NewWeakGlobalRef) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> NewWeakGlobalRef;

        // void (JNICALL *DeleteWeakGlobalRef) (JNIEnv* env, jweak ref);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, void> DeleteWeakGlobalRef;

        // jboolean (JNICALL *ExceptionCheck) (JNIEnv* env);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, bool> ExceptionCheck;

        // jobject (JNICALL *NewDirectByteBuffer) (JNIEnv* env, void* address, jlong capacity);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, long, nint> NewDirectByteBuffer;

        // void* (JNICALL *GetDirectBufferAddress) (JNIEnv* env, jobject buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint> GetDirectBufferAddress;

        // jlong (JNICALL *GetDirectBufferCapacity) (JNIEnv* env, jobject buf);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, long> GetDirectBufferCapacity;

        // jobjectRefType (JNICALL *GetObjectRefType) (JNIEnv* env, jobject obj);
        public readonly delegate* unmanaged[Cdecl]<JNIEnv*, nint, JObjectRefType> GetObjectRefType;
    }

    public readonly JNIFunctions* Functions;
}
    
[StructLayout(LayoutKind.Explicit, Size = 8)]
public struct JValue
{
    [FieldOffset(0)]
    public bool z;

    [FieldOffset(0)]
    public sbyte b;
    
    [FieldOffset(0)]
    public char c;
    
    [FieldOffset(0)]
    public short s;
    
    [FieldOffset(0)]
    public int i;
    
    [FieldOffset(0)]
    public long j;
    
    [FieldOffset(0)]
    public float f;
    
    [FieldOffset(0)]
    public double d;
    
    [FieldOffset(0)]
    public IntPtr l;
}

public enum JObjectRefType
{
    JNIInvalidRefType,

    JNILocalRefType,

    JNIGlobalRefType,

    JNIWeakGlobalRefType
}