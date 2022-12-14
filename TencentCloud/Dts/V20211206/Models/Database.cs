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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Database : AbstractModel
    {
        
        /// <summary>
        /// Name of the database to be migrated or synced, which is required if `ObjectMode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Name of the database after migration or sync, which is the same as the source database name by default.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewDbName")]
        public string NewDbName{ get; set; }

        /// <summary>
        /// Database selection mode, which is required if `Mode` is `Partial`. Valid values: `All`, `Partial`. Note that the sync of advanced objects does not depend on this parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// The schema to be migrated or synced
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// Name of the schema after migration or sync
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewSchemaName")]
        public string NewSchemaName{ get; set; }

        /// <summary>
        /// Table selection mode, which is required if `DBMode` is `Partial`. Valid values: `All`, `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }

        /// <summary>
        /// The set of table objects, which is required if `TableMode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tables")]
        public Table[] Tables{ get; set; }

        /// <summary>
        /// View selection mode. Valid values: `All`, `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ViewMode")]
        public string ViewMode{ get; set; }

        /// <summary>
        /// The set of view objects, which is required if `ViewMode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Views")]
        public View[] Views{ get; set; }

        /// <summary>
        /// Sync mode. Valid values: `Partial`, `All`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FunctionMode")]
        public string FunctionMode{ get; set; }

        /// <summary>
        /// This parameter is required if `FunctionMode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// Sync mode. Valid values: `Partial`, `All`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcedureMode")]
        public string ProcedureMode{ get; set; }

        /// <summary>
        /// This parameter is required if `ProcedureMode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Procedures")]
        public string[] Procedures{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "NewDbName", this.NewDbName);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "NewSchemaName", this.NewSchemaName);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamSimple(map, prefix + "ViewMode", this.ViewMode);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamSimple(map, prefix + "FunctionMode", this.FunctionMode);
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "ProcedureMode", this.ProcedureMode);
            this.SetParamArraySimple(map, prefix + "Procedures.", this.Procedures);
        }
    }
}
