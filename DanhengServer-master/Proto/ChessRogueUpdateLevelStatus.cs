// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueUpdateLevelStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueUpdateLevelStatus.proto</summary>
  public static partial class ChessRogueUpdateLevelStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueUpdateLevelStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueUpdateLevelStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGVzc1JvZ3VlVXBkYXRlTGV2ZWxTdGF0dXMucHJvdG8qeQobQ2hlc3NS",
            "b2d1ZVVwZGF0ZUxldmVsU3RhdHVzEisKJ0NIRVNTX1JPR1VFX1VQREFURV9M",
            "RVZFTF9TVEFUVVNfQllfTk9ORRAAEi0KKUNIRVNTX1JPR1VFX1VQREFURV9M",
            "RVZFTF9TVEFUVVNfQllfRElBTE9HEAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.ChessRogueUpdateLevelStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChessRogueUpdateLevelStatus {
    [pbr::OriginalName("CHESS_ROGUE_UPDATE_LEVEL_STATUS_BY_NONE")] ByNone = 0,
    [pbr::OriginalName("CHESS_ROGUE_UPDATE_LEVEL_STATUS_BY_DIALOG")] ByDialog = 1,
  }

  #endregion

}

#endregion Designer generated code
