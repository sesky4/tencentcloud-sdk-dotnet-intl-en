/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpTableRule : AbstractModel
    {
        
        /// <summary>
        /// The action. Values:
        /// <li>`drop`: Block</li>
        /// <li>`trans`: Allow</li>
        /// <li>`monitor`: Observe</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The matching dimension. Values:
        /// <li>`ip`: Match by IP.</li>
        /// <li>`area`: Match by IP region.</li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// The matching content.
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }

        /// <summary>
        /// The rule ID, which is only used as an output parameter.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// The update time, which is only used as an output parameter.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The rule status. A null value indicates that the rule is enabled. Values:
        /// <li>`on`: Enabled</li>
        /// <li>`off`: Disabled</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "MatchFrom", this.MatchFrom);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}
