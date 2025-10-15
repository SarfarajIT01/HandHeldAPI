namespace HandHeldAPI.Models.DTOs
{
    public class AllTableExplorer
    {
        public List<VacantTableExplorer>? Vacant { get; set; }
        public List<OccupiedTableExplorer>? Occupied { get; set; }
    }

    public class VacantTableExplorer
    {
        public string? Table { get; set; }
        public string? Status { get; set; }
        public string? RMSC_STD { get; set; }
        public string? RMSC_COD { get; set; }      
        public string? RMSC_TBLSTS { get; set; }
    }

    public class OccupiedTableExplorer
    {
        public string? RkotPop { get; set; }
        public string? RsumTim { get; set; }
        public string? RkotNo { get; set; }
        public string? RsumTbl { get; set; }
        public string? RsumStw { get; set; }
        public string? RsumCvr { get; set; }
        public string? RsumAmt { get; set; }
        public string? RkotQty { get; set; }
        public string? RkotRat { get; set; }
        public string? ItemName { get; set; }
        public string? RkotRem { get; set; }
        public string? Amount { get; set; }
    }
}
