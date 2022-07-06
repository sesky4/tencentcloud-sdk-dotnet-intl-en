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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLoadBalancingRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancingId")]
        public string LoadBalancingId{ get; set; }

        /// <summary>
        /// Proxy mode.
        /// `dns_only`: Only DNS
        /// `proxied`: Enable proxy
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ID of the origin group used
        /// </summary>
        [JsonProperty("OriginId")]
        public string[] OriginId{ get; set; }

        /// <summary>
        /// Indicates DNS TTL time when `Type=dns_only`
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "LoadBalancingId", this.LoadBalancingId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "OriginId.", this.OriginId);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
        }
    }
}
