// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Applies a 3D adaptive average pooling over an input signal composed of several input planes.<br></br>
            ///	
            ///	The output is of size D x H x W, for any input size.<br></br>
            ///	
            ///	The number of output features is equal to the number of input planes.
            /// </summary>
            public partial class AdaptiveAvgPool3d : Module
            {
                // auto-generated class
                
                public AdaptiveAvgPool3d(PyObject pyobj) : base(pyobj) { }
                
                public AdaptiveAvgPool3d(Module other) : base(other.PyObject as PyObject) { }
                
                public AdaptiveAvgPool3d(int output_size)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        output_size,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("AdaptiveAvgPool3d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
