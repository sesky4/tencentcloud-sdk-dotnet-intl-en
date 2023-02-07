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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirusMonitorSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable scheduled scan
        /// </summary>
        [JsonProperty("EnableScan")]
        public bool? EnableScan{ get; set; }

        /// <summary>
        /// Scan all paths
        /// </summary>
        [JsonProperty("ScanPathAll")]
        public bool? ScanPathAll{ get; set; }

        /// <summary>
        /// Valid when `ScanPathAll` is `true`. Valid values of `ScanPathAll`: `0` (scan the following paths); `1` (scan all paths except the following; the scope cannot be greater than `1`).
        /// </summary>
        [JsonProperty("ScanPathType")]
        public ulong? ScanPathType{ get; set; }

        /// <summary>
        /// Specified path to be excluded or scanned
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamSimple(map, prefix + "ScanPathAll", this.ScanPathAll);
            this.SetParamSimple(map, prefix + "ScanPathType", this.ScanPathType);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
        }
    }
}
