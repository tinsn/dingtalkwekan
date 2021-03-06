using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.class.get
    /// </summary>
    public class OapiAttendanceClassGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceClassGetResponse>
    {
        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.class.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
        }

        #endregion
    }
}
