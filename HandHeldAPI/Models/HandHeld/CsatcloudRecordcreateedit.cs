using System;
using System.Collections.Generic;

namespace HandHeldAPI.Models.HandHeld;

public partial class CsatcloudRecordcreateedit
{
    public string? ModCode { get; set; }

    public string? RecordType { get; set; }

    public string? RecordCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUid { get; set; }

    public string? CreatedIpadd { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedUid { get; set; }

    public string? UpdatedIpadd { get; set; }

    public string? Unqrec { get; set; }
}
