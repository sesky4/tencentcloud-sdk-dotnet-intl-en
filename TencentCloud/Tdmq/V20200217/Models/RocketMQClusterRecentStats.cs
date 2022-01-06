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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RocketMQClusterRecentStats : AbstractModel
    {
        
        /// <summary>
        /// Number of topics
        /// </summary>
        [JsonProperty("TopicNum")]
        public ulong? TopicNum{ get; set; }

        /// <summary>
        /// Number of produced messages
        /// </summary>
        [JsonProperty("ProducedMsgNum")]
        public ulong? ProducedMsgNum{ get; set; }

        /// <summary>
        /// Number of consumed messages
        /// </summary>
        [JsonProperty("ConsumedMsgNum")]
        public ulong? ConsumedMsgNum{ get; set; }

        /// <summary>
        /// Number of retained messages
        /// </summary>
        [JsonProperty("AccumulativeMsgNum")]
        public ulong? AccumulativeMsgNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "ProducedMsgNum", this.ProducedMsgNum);
            this.SetParamSimple(map, prefix + "ConsumedMsgNum", this.ConsumedMsgNum);
            this.SetParamSimple(map, prefix + "AccumulativeMsgNum", this.AccumulativeMsgNum);
        }
    }
}
