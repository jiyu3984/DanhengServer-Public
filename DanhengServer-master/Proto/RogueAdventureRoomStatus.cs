// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueAdventureRoomStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueAdventureRoomStatus.proto</summary>
  public static partial class RogueAdventureRoomStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueAdventureRoomStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueAdventureRoomStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Sb2d1ZUFkdmVudHVyZVJvb21TdGF0dXMucHJvdG8quwEKGFJvZ3VlQWR2",
            "ZW50dXJlUm9vbVN0YXR1cxIkCiBST0dVRV9BRFZFTlRVUkVfUk9PTV9TVEFU",
            "VVNfTk9ORRAAEicKI1JPR1VFX0FEVkVOVFVSRV9ST09NX1NUQVRVU19QUkVQ",
            "QVJFEAESJwojUk9HVUVfQURWRU5UVVJFX1JPT01fU1RBVFVTX1NUQVJURUQQ",
            "AhInCiNST0dVRV9BRFZFTlRVUkVfUk9PTV9TVEFUVVNfU1RPUFBFRBADQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueAdventureRoomStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueAdventureRoomStatus {
    [pbr::OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_NONE")] None = 0,
    [pbr::OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_PREPARE")] Prepare = 1,
    [pbr::OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_STARTED")] Started = 2,
    [pbr::OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_STOPPED")] Stopped = 3,
  }

  #endregion

}

#endregion Designer generated code
