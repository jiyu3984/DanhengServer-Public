// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RebattleType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RebattleType.proto</summary>
  public static partial class RebattleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for RebattleType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RebattleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSZWJhdHRsZVR5cGUucHJvdG8q+AEKDFJlYmF0dGxlVHlwZRIWChJSRUJB",
            "VFRMRV9UWVBFX05PTkUQABIhCh1SRUJBVFRMRV9UWVBFX1JFQkFUVExFX01J",
            "RFdBWRABEh8KG1JFQkFUVExFX1RZUEVfUkVCQVRUTEVfTE9TRRACEigKJFJF",
            "QkFUVExFX1RZUEVfUkVCQVRUTEVfTUlEV0FZX0xJTkVVUBADEiYKIlJFQkFU",
            "VExFX1RZUEVfUkVCQVRUTEVfTE9TRV9MSU5FVVAQBBIdChlSRUJBVFRMRV9U",
            "WVBFX1FVSVRfTUlEV0FZEAUSGwoXUkVCQVRUTEVfVFlQRV9RVUlUX0xPU0UQ",
            "BkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RebattleType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RebattleType {
    [pbr::OriginalName("REBATTLE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY")] RebattleMidway = 1,
    [pbr::OriginalName("REBATTLE_TYPE_REBATTLE_LOSE")] RebattleLose = 2,
    [pbr::OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY_LINEUP")] RebattleMidwayLineup = 3,
    [pbr::OriginalName("REBATTLE_TYPE_REBATTLE_LOSE_LINEUP")] RebattleLoseLineup = 4,
    [pbr::OriginalName("REBATTLE_TYPE_QUIT_MIDWAY")] QuitMidway = 5,
    [pbr::OriginalName("REBATTLE_TYPE_QUIT_LOSE")] QuitLose = 6,
  }

  #endregion

}

#endregion Designer generated code