using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class HfoRoomMst
{
    public int Id { get; set; }

    public string? RoomNumb { get; set; }

    public string? RmFloor { get; set; }

    public string? RmType { get; set; }

    public string? RmDesc { get; set; }

    public string? RmSingle { get; set; }

    public int? RmSgRent { get; set; }

    public int? RmDbRent { get; set; }

    public int? RmExRent { get; set; }

    public int? RmMnRent { get; set; }

    public short? RmMinPer { get; set; }

    public string? RmEbxExt { get; set; }

    public string? RmLtaxyn { get; set; }

    public string? RmRemark { get; set; }

    public string? RmBdType { get; set; }

    public DateTime? WefDate { get; set; }

    public string? RmFeature { get; set; }

    public short? NoofGuest { get; set; }

    public string? RmStatus { get; set; }

    public int? RmIfRent { get; set; }

    public string? RoomNotes { get; set; }

    public string? RoomPicture { get; set; }

    public string? Status { get; set; }

    public string? DoorLock { get; set; }

    public string? HotelCode { get; set; }

    public string? AccountId { get; set; }

    public string? RoomMsg { get; set; }

    public short? MaxPax { get; set; }

    public string? SachnsCode { get; set; }
}
