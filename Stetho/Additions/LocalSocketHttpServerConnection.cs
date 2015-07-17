using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace StethoLibrary.Server
{
    public partial class LocalSocketHttpServerConnection
    {
        public override int SocketTimeout
        {
            [Register("getSocketTimeout", "()I", "GetGetSocketTimeoutHandler")]
            get { return GetSocketTimeout(); }
            [Register("setSocketTimeout", "(I)V", "GetSetSocketTimeout_IHandler")]
            set { SetSocketTimeout(value); }
        }

        static IntPtr id_setSocketTimeout_I;
        private unsafe void SetSocketTimeout(int p0)
        {
            if (id_setSocketTimeout_I == IntPtr.Zero)
                id_setSocketTimeout_I = JNIEnv.GetMethodID(class_ref, "setSocketTimeout", "(I)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                if (GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(Handle, id_setSocketTimeout_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setSocketTimeout", "(I)V"), __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getSocketTimeout;
        private unsafe int GetSocketTimeout()
        {
            if (id_getSocketTimeout == IntPtr.Zero)
                id_getSocketTimeout = JNIEnv.GetMethodID(class_ref, "getSocketTimeout", "()I");
            try
            {

                if (GetType() == ThresholdType)
                    return JNIEnv.CallIntMethod(Handle, id_getSocketTimeout);
                else
                    return JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSocketTimeout", "()I"));
            }
            finally
            {
            }
        }
    }
}