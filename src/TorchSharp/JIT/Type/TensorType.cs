﻿using System;
using System.Runtime.InteropServices;

namespace TorchSharp.JIT
{
    public sealed class TensorType : Type
    {
        internal TensorType(IntPtr handle) : base(handle)
        {
            this.handle = new HType(handle, true);
        }

        internal TensorType(Type type) : base()
        {
            handle = type.handle;
            type.handle = new HType(IntPtr.Zero, true);
            type.Dispose();
        }

        [DllImport("LibTorchSharp")]
        private static extern short THSJIT_getScalarFromTensorType(HType handle);

        public Tensor.ATenScalarMapping GetScalarType()
        {
            return (Tensor.ATenScalarMapping)THSJIT_getScalarFromTensorType(handle);
        }

        [DllImport("LibTorchSharp")]
        private static extern int THSJIT_getTensorTypeDimensions(HType handle);

        public int GetDimensions()
        {
            return THSJIT_getTensorTypeDimensions(handle);
        }

        [DllImport("LibTorchSharp")]
        private static extern string THSJIT_getTensorDevice(HType handle);

        public string GetDevice()
        {
            return THSJIT_getTensorDevice(handle);
        }
    }
}
