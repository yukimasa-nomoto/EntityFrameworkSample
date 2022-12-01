using System;
using System.Collections.Generic;

namespace ContosoPizza.Models2
{
    public partial class Dndasassort
    {
        public long InstructionOrder { get; set; }
        public string? IndicatorNo { get; set; }
        public string? JobNo { get; set; }
        public string? CountryType { get; set; }
        public string? RohsType { get; set; }
        public string? MakeDay { get; set; }
        public bool? SendEnableStatus { get; set; }
        public DateTime? SendEnableDate { get; set; }
        public bool? PpsSendStatus { get; set; }
        public DateTime? PpsSendDate { get; set; }
        public byte? SendCount { get; set; }
        public bool? PpsSendRetStatus { get; set; }
        public DateTime? PpsSendRetDate { get; set; }
        public string? IndicatorRetStatus { get; set; }
        public bool? PpsResultReceiveStatus { get; set; }
        public DateTime? PpsResultReceiveDate { get; set; }
        public bool? WmsSendStatus { get; set; }
        public DateTime? WmsSendDate { get; set; }
        public bool? PpsSendRetryStatus { get; set; }
        public DateTime? PpsRetrySendDate { get; set; }
        public bool? SendRetryCount { get; set; }
        public string? WcsSentDate { get; set; }
        public string? DasBlockNo { get; set; }
        public string? DasCellNo { get; set; }
        public string? PlanDay { get; set; }
        public string? DeliveryCode { get; set; }
        public string? TransportCode { get; set; }
        public string? LoadNo { get; set; }
        public string? DasLoadNo { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? DeliveryCompanyName1 { get; set; }
        public string? DeliveryCompanyName2 { get; set; }
        public bool? EndFlg { get; set; }
        public bool? ReceiveEndFlg { get; set; }
        public int? PlanQty { get; set; }
        public int? ResultQty { get; set; }
        public int? ShortageQty { get; set; }
        public int? PpsResultQty { get; set; }
        public byte? PackingSummaryLine { get; set; }
        public DateTime RegistDate { get; set; }
        public string? RegistPname { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string? LastUpdatePname { get; set; }
    }
}
