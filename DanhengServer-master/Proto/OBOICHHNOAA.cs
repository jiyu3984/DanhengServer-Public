// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OBOICHHNOAA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OBOICHHNOAA.proto</summary>
  public static partial class OBOICHHNOAAReflection {

    #region Descriptor
    /// <summary>File descriptor for OBOICHHNOAA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OBOICHHNOAAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPQk9JQ0hITk9BQS5wcm90byqdAQoLT0JPSUNISE5PQUESFQoRTUFUQ0gz",
            "X1NUQVRFX0lETEUQABIWChJNQVRDSDNfU1RBVEVfU1RBUlQQARIWChJNQVRD",
            "SDNfU1RBVEVfTUFUQ0gQAhIVChFNQVRDSDNfU1RBVEVfR0FNRRADEhkKFU1B",
            "VENIM19TVEFURV9IQUxGVElNRRAEEhUKEU1BVENIM19TVEFURV9PVkVSEAVC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.OBOICHHNOAA), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum OBOICHHNOAA {
    [pbr::OriginalName("MATCH3_STATE_IDLE")] Match3StateIdle = 0,
    [pbr::OriginalName("MATCH3_STATE_START")] Match3StateStart = 1,
    [pbr::OriginalName("MATCH3_STATE_MATCH")] Match3StateMatch = 2,
    [pbr::OriginalName("MATCH3_STATE_GAME")] Match3StateGame = 3,
    [pbr::OriginalName("MATCH3_STATE_HALFTIME")] Match3StateHalftime = 4,
    [pbr::OriginalName("MATCH3_STATE_OVER")] Match3StateOver = 5,
  }

  #endregion

}

#endregion Designer generated code