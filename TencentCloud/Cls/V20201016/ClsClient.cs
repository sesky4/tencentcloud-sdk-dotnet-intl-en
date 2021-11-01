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

namespace TencentCloud.Cls.V20201016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cls.V20201016.Models;

   public class ClsClient : AbstractClient{

       private const string endpoint = "cls.tencentcloudapi.com";
       private const string version = "2020-10-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to apply the collection configuration to the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroup(ApplyConfigToMachineGroupRequest req)
        {
             JsonResponseModel<ApplyConfigToMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyConfigToMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConfigToMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply the collection configuration to the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroupSync(ApplyConfigToMachineGroupRequest req)
        {
             JsonResponseModel<ApplyConfigToMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyConfigToMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConfigToMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public async Task<CreateAlarmResponse> CreateAlarm(CreateAlarmRequest req)
        {
             JsonResponseModel<CreateAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public CreateAlarmResponse CreateAlarmSync(CreateAlarmRequest req)
        {
             JsonResponseModel<CreateAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public async Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncContextTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncContextTaskResponse"/></returns>
        public async Task<CreateAsyncContextTaskResponse> CreateAsyncContextTask(CreateAsyncContextTaskRequest req)
        {
             JsonResponseModel<CreateAsyncContextTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAsyncContextTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsyncContextTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncContextTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncContextTaskResponse"/></returns>
        public CreateAsyncContextTaskResponse CreateAsyncContextTaskSync(CreateAsyncContextTaskRequest req)
        {
             JsonResponseModel<CreateAsyncContextTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAsyncContextTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsyncContextTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline search task.
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncSearchTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncSearchTaskResponse"/></returns>
        public async Task<CreateAsyncSearchTaskResponse> CreateAsyncSearchTask(CreateAsyncSearchTaskRequest req)
        {
             JsonResponseModel<CreateAsyncSearchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAsyncSearchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsyncSearchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an offline search task.
        /// </summary>
        /// <param name="req"><see cref="CreateAsyncSearchTaskRequest"/></param>
        /// <returns><see cref="CreateAsyncSearchTaskResponse"/></returns>
        public CreateAsyncSearchTaskResponse CreateAsyncSearchTaskSync(CreateAsyncSearchTaskRequest req)
        {
             JsonResponseModel<CreateAsyncSearchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAsyncSearchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAsyncSearchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public async Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log download task.
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public async Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
             JsonResponseModel<CreateExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log download task.
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
             JsonResponseModel<CreateExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an index.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public async Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an index.
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a logset. The ID of the created logset is returned.
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public async Task<CreateLogsetResponse> CreateLogset(CreateLogsetRequest req)
        {
             JsonResponseModel<CreateLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a logset. The ID of the created logset is returned.
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public CreateLogsetResponse CreateLogsetSync(CreateLogsetRequest req)
        {
             JsonResponseModel<CreateLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a machine group.
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public async Task<CreateMachineGroupResponse> CreateMachineGroup(CreateMachineGroupRequest req)
        {
             JsonResponseModel<CreateMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a machine group.
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public CreateMachineGroupResponse CreateMachineGroupSync(CreateMachineGroupRequest req)
        {
             JsonResponseModel<CreateMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public async Task<CreateShipperResponse> CreateShipper(CreateShipperRequest req)
        {
             JsonResponseModel<CreateShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public CreateShipperResponse CreateShipperSync(CreateShipperRequest req)
        {
             JsonResponseModel<CreateShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log topic.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public async Task<DeleteAlarmResponse> DeleteAlarm(DeleteAlarmRequest req)
        {
             JsonResponseModel<DeleteAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public DeleteAlarmResponse DeleteAlarmSync(DeleteAlarmRequest req)
        {
             JsonResponseModel<DeleteAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public async Task<DeleteAlarmNoticeResponse> DeleteAlarmNotice(DeleteAlarmNoticeRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public DeleteAlarmNoticeResponse DeleteAlarmNoticeSync(DeleteAlarmNoticeRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAsyncContextTaskRequest"/></param>
        /// <returns><see cref="DeleteAsyncContextTaskResponse"/></returns>
        public async Task<DeleteAsyncContextTaskResponse> DeleteAsyncContextTask(DeleteAsyncContextTaskRequest req)
        {
             JsonResponseModel<DeleteAsyncContextTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAsyncContextTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsyncContextTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAsyncContextTaskRequest"/></param>
        /// <returns><see cref="DeleteAsyncContextTaskResponse"/></returns>
        public DeleteAsyncContextTaskResponse DeleteAsyncContextTaskSync(DeleteAsyncContextTaskRequest req)
        {
             JsonResponseModel<DeleteAsyncContextTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAsyncContextTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsyncContextTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an offline search task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAsyncSearchTaskRequest"/></param>
        /// <returns><see cref="DeleteAsyncSearchTaskResponse"/></returns>
        public async Task<DeleteAsyncSearchTaskResponse> DeleteAsyncSearchTask(DeleteAsyncSearchTaskRequest req)
        {
             JsonResponseModel<DeleteAsyncSearchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAsyncSearchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsyncSearchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an offline search task.
        /// </summary>
        /// <param name="req"><see cref="DeleteAsyncSearchTaskRequest"/></param>
        /// <returns><see cref="DeleteAsyncSearchTaskResponse"/></returns>
        public DeleteAsyncSearchTaskResponse DeleteAsyncSearchTaskSync(DeleteAsyncSearchTaskRequest req)
        {
             JsonResponseModel<DeleteAsyncSearchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAsyncSearchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAsyncSearchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public async Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the collection configuration applied to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public async Task<DeleteConfigFromMachineGroupResponse> DeleteConfigFromMachineGroup(DeleteConfigFromMachineGroupRequest req)
        {
             JsonResponseModel<DeleteConfigFromMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfigFromMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigFromMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the collection configuration applied to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public DeleteConfigFromMachineGroupResponse DeleteConfigFromMachineGroupSync(DeleteConfigFromMachineGroupRequest req)
        {
             JsonResponseModel<DeleteConfigFromMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfigFromMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigFromMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public async Task<DeleteExportResponse> DeleteExport(DeleteExportRequest req)
        {
             JsonResponseModel<DeleteExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log download task.
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public DeleteExportResponse DeleteExportSync(DeleteExportRequest req)
        {
             JsonResponseModel<DeleteExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the index configuration of a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public async Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the index configuration of a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a logset.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public async Task<DeleteLogsetResponse> DeleteLogset(DeleteLogsetRequest req)
        {
             JsonResponseModel<DeleteLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a logset.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public DeleteLogsetResponse DeleteLogsetSync(DeleteLogsetRequest req)
        {
             JsonResponseModel<DeleteLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroup(DeleteMachineGroupRequest req)
        {
             JsonResponseModel<DeleteMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a machine group.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public DeleteMachineGroupResponse DeleteMachineGroupSync(DeleteMachineGroupRequest req)
        {
             JsonResponseModel<DeleteMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a shipping rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public async Task<DeleteShipperResponse> DeleteShipper(DeleteShipperRequest req)
        {
             JsonResponseModel<DeleteShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a shipping rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public DeleteShipperResponse DeleteShipperSync(DeleteShipperRequest req)
        {
             JsonResponseModel<DeleteShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public async Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log topic.
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of alarm notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public async Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of alarm notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public async Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncContextResultRequest"/></param>
        /// <returns><see cref="DescribeAsyncContextResultResponse"/></returns>
        public async Task<DescribeAsyncContextResultResponse> DescribeAsyncContextResult(DescribeAsyncContextResultRequest req)
        {
             JsonResponseModel<DescribeAsyncContextResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncContextResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncContextResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of an offline context search task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncContextResultRequest"/></param>
        /// <returns><see cref="DescribeAsyncContextResultResponse"/></returns>
        public DescribeAsyncContextResultResponse DescribeAsyncContextResultSync(DescribeAsyncContextResultRequest req)
        {
             JsonResponseModel<DescribeAsyncContextResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncContextResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncContextResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of offline context search tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncContextTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncContextTasksResponse"/></returns>
        public async Task<DescribeAsyncContextTasksResponse> DescribeAsyncContextTasks(DescribeAsyncContextTasksRequest req)
        {
             JsonResponseModel<DescribeAsyncContextTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncContextTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncContextTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of offline context search tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncContextTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncContextTasksResponse"/></returns>
        public DescribeAsyncContextTasksResponse DescribeAsyncContextTasksSync(DescribeAsyncContextTasksRequest req)
        {
             JsonResponseModel<DescribeAsyncContextTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncContextTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncContextTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of an offline search task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncSearchResultRequest"/></param>
        /// <returns><see cref="DescribeAsyncSearchResultResponse"/></returns>
        public async Task<DescribeAsyncSearchResultResponse> DescribeAsyncSearchResult(DescribeAsyncSearchResultRequest req)
        {
             JsonResponseModel<DescribeAsyncSearchResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncSearchResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncSearchResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of an offline search task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncSearchResultRequest"/></param>
        /// <returns><see cref="DescribeAsyncSearchResultResponse"/></returns>
        public DescribeAsyncSearchResultResponse DescribeAsyncSearchResultSync(DescribeAsyncSearchResultRequest req)
        {
             JsonResponseModel<DescribeAsyncSearchResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncSearchResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncSearchResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of offline search tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncSearchTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncSearchTasksResponse"/></returns>
        public async Task<DescribeAsyncSearchTasksResponse> DescribeAsyncSearchTasks(DescribeAsyncSearchTasksRequest req)
        {
             JsonResponseModel<DescribeAsyncSearchTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncSearchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncSearchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of offline search tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncSearchTasksRequest"/></param>
        /// <returns><see cref="DescribeAsyncSearchTasksResponse"/></returns>
        public DescribeAsyncSearchTasksResponse DescribeAsyncSearchTasksSync(DescribeAsyncSearchTasksRequest req)
        {
             JsonResponseModel<DescribeAsyncSearchTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncSearchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncSearchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the machine group bound to a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public async Task<DescribeConfigMachineGroupsResponse> DescribeConfigMachineGroups(DescribeConfigMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeConfigMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the machine group bound to a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public DescribeConfigMachineGroupsResponse DescribeConfigMachineGroupsSync(DescribeConfigMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeConfigMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public async Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public async Task<DescribeExportsResponse> DescribeExports(DescribeExportsRequest req)
        {
             JsonResponseModel<DescribeExportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public DescribeExportsResponse DescribeExportsSync(DescribeExportsRequest req)
        {
             JsonResponseModel<DescribeExportsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the index configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public async Task<DescribeIndexResponse> DescribeIndex(DescribeIndexRequest req)
        {
             JsonResponseModel<DescribeIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the index configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public DescribeIndexResponse DescribeIndexSync(DescribeIndexRequest req)
        {
             JsonResponseModel<DescribeIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for content in the log context.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public async Task<DescribeLogContextResponse> DescribeLogContext(DescribeLogContextRequest req)
        {
             JsonResponseModel<DescribeLogContextResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogContext");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogContextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for content in the log context.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public DescribeLogContextResponse DescribeLogContextSync(DescribeLogContextRequest req)
        {
             JsonResponseModel<DescribeLogContextResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogContext");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogContextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public async Task<DescribeLogsetsResponse> DescribeLogsets(DescribeLogsetsRequest req)
        {
             JsonResponseModel<DescribeLogsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of logsets.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public DescribeLogsetsResponse DescribeLogsetsSync(DescribeLogsetsRequest req)
        {
             JsonResponseModel<DescribeLogsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the collection rule configuration bound to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public async Task<DescribeMachineGroupConfigsResponse> DescribeMachineGroupConfigs(DescribeMachineGroupConfigsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineGroupConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the collection rule configuration bound to a machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public DescribeMachineGroupConfigsResponse DescribeMachineGroupConfigsSync(DescribeMachineGroupConfigsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineGroupConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of machine groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public async Task<DescribeMachineGroupsResponse> DescribeMachineGroups(DescribeMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of machine groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public DescribeMachineGroupsResponse DescribeMachineGroupsSync(DescribeMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the machine status in the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public async Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the machine status in the specified machine group.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of topic partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public async Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
             JsonResponseModel<DescribePartitionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of topic partitions.
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
             JsonResponseModel<DescribePartitionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public async Task<DescribeShipperTasksResponse> DescribeShipperTasks(DescribeShipperTasksRequest req)
        {
             JsonResponseModel<DescribeShipperTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShipperTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShipperTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of shipping tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public DescribeShipperTasksResponse DescribeShipperTasksSync(DescribeShipperTasksRequest req)
        {
             JsonResponseModel<DescribeShipperTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShipperTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShipperTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of shipping rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public async Task<DescribeShippersResponse> DescribeShippers(DescribeShippersRequest req)
        {
             JsonResponseModel<DescribeShippersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShippers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShippersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of shipping rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public DescribeShippersResponse DescribeShippersSync(DescribeShippersRequest req)
        {
             JsonResponseModel<DescribeShippersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShippers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShippersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to get the list of log topics and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public async Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to get the list of log topics and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the records of alarm tasks.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public async Task<GetAlarmLogResponse> GetAlarmLog(GetAlarmLogRequest req)
        {
             JsonResponseModel<GetAlarmLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAlarmLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAlarmLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the records of alarm tasks.
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public GetAlarmLogResponse GetAlarmLogSync(GetAlarmLogRequest req)
        {
             JsonResponseModel<GetAlarmLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAlarmLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAlarmLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge a topic partition in read/write state. During merge, a topic partition ID can be specified, and CLS will automatically merge the partition adjacent to the right of the range.
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public async Task<MergePartitionResponse> MergePartition(MergePartitionRequest req)
        {
             JsonResponseModel<MergePartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MergePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MergePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge a topic partition in read/write state. During merge, a topic partition ID can be specified, and CLS will automatically merge the partition adjacent to the right of the range.
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public MergePartitionResponse MergePartitionSync(MergePartitionRequest req)
        {
             JsonResponseModel<MergePartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MergePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MergePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alarm policy. At least one valid configuration item needs to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public async Task<ModifyAlarmResponse> ModifyAlarm(ModifyAlarmRequest req)
        {
             JsonResponseModel<ModifyAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alarm policy. At least one valid configuration item needs to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public ModifyAlarmResponse ModifyAlarmSync(ModifyAlarmRequest req)
        {
             JsonResponseModel<ModifyAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public async Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public async Task<ModifyConfigResponse> ModifyConfig(ModifyConfigRequest req)
        {
             JsonResponseModel<ModifyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a collection rule configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public ModifyConfigResponse ModifyConfigSync(ModifyConfigRequest req)
        {
             JsonResponseModel<ModifyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the index configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public async Task<ModifyIndexResponse> ModifyIndex(ModifyIndexRequest req)
        {
             JsonResponseModel<ModifyIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the index configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public ModifyIndexResponse ModifyIndexSync(ModifyIndexRequest req)
        {
             JsonResponseModel<ModifyIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a logset.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public async Task<ModifyLogsetResponse> ModifyLogset(ModifyLogsetRequest req)
        {
             JsonResponseModel<ModifyLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a logset.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public ModifyLogsetResponse ModifyLogsetSync(ModifyLogsetRequest req)
        {
             JsonResponseModel<ModifyLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a machine group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public async Task<ModifyMachineGroupResponse> ModifyMachineGroup(ModifyMachineGroupRequest req)
        {
             JsonResponseModel<ModifyMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a machine group.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public ModifyMachineGroupResponse ModifyMachineGroupSync(ModifyMachineGroupRequest req)
        {
             JsonResponseModel<ModifyMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an existing shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public async Task<ModifyShipperResponse> ModifyShipper(ModifyShipperRequest req)
        {
             JsonResponseModel<ModifyShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an existing shipping rule. To use this API, you need to grant CLS the write permission of the specified bucket.
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public ModifyShipperResponse ModifyShipperSync(ModifyShipperRequest req)
        {
             JsonResponseModel<ModifyShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a log topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public async Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a log topic.
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry a failed shipping task.
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public async Task<RetryShipperTaskResponse> RetryShipperTask(RetryShipperTaskRequest req)
        {
             JsonResponseModel<RetryShipperTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryShipperTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryShipperTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry a failed shipping task.
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public RetryShipperTaskResponse RetryShipperTaskSync(RetryShipperTaskRequest req)
        {
             JsonResponseModel<RetryShipperTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryShipperTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryShipperTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public async Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for logs.
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to split a topic partition.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public async Task<SplitPartitionResponse> SplitPartition(SplitPartitionRequest req)
        {
             JsonResponseModel<SplitPartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SplitPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to split a topic partition.
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public SplitPartitionResponse SplitPartitionSync(SplitPartitionRequest req)
        {
             JsonResponseModel<SplitPartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SplitPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ## Feature Description
        /// 
        /// This API is used to write a log to the specified log topic.
        /// 
        /// CLS provides the following two modes:
        /// 
        /// #### Load balancing mode
        /// 
        /// In this mode, logs will be automatically written to a target partition among all readable/writable partitions under the current log topic based on the load balancing principle. This mode is suitable for scenarios where the sequential consumption is not needed.
        /// 
        /// #### Hash routing mode
        /// 
        /// In this mode, data will be written to a target partition that meets the range requirements based on the hash value (X-CLS-HashKey) carried by data. For example, a log source can be bound to a topic partition through `hashkey`, strictly guaranteeing the sequence of the data written to and consumed in this partition.
        /// 
        /// In addition, CLS allows you to upload logs in the following two modes:
        /// 
        /// 
        /// ## Request
        /// 
        /// #### Request header parameters
        /// 
        /// The `X-CLS-HashKey` request header indicates that logs are written to the CLS topic partitions with a range corresponding to the hashkey route, strictly guaranteeing the write sequence of logs to each topic partition for sequential consumption.
        /// 
        /// | Field | Type | Location | Required | Description |
        /// | ------------------ | ------ | ------ | -------- | ------------------------------------------------------------ |
        /// | X-CLS-HashKey | string | header | No       | Logs are written to the corresponding topic partition according to `hashkey` |
        /// | X-CLS-TopicId      | String | header | Yes       | Topic ID                                                       |                                                 |
        /// | Content-Type | String | header | Yes | Protocol type of the request parameter. Currently, only the PB protocol is supported. Please enter "application/octet-stream". |
        /// | X-TC-Action | String |	header | Yes | Common parameter. The value used for this API: UploadLog.                   
        /// | X-TC-Region | String | header | Yes	  | Common parameter. This parameter is not required for this API.                       
        /// | X-TC-Version | String | header | Yes | Common parameter. The value used for this API: 2020-10-16.                  
        /// 
        /// #### Input parameters (PB protocol)
        /// 
        /// | Field | Type | Location | Required | Description |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb    | Yes   | The logGroup list, which describes the encapsulated log groups. No more than five `logGroup` values are recommended.                     |
        /// 
        /// `LogGroup` description:
        /// 
        /// | Field | Required | Description |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | Yes       | Log array consisting of multiple `Log` values. The `Log` indicates a log, and a `LogGroup` can contain up to 10,000 `Log` values. |
        /// | contextFlow | No       | Unique LogGroup ID, which should be passed in if the context feature needs to be used. Format: "{context ID}-{LogGroupID}". <br>Context ID: uniquely identifies the context (a series of log files that are continuously scrolling or a series of logs that need to be sequenced), which is a 64-bit integer hex string. <br>LogGroupID: a 64-bit integer hex string that continuously increases, such as "102700A66102516A-59F59".                        |
        /// | filename    | No       | Log filename                                                   |
        /// | source      | No       | Log source, which is generally the server IP                           |
        /// | logTags     | No       | Tag list of the log                                               |
        /// 
        /// `Log` description:
        /// 
        /// | Field | Required | Description |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time | Yes | UNIX timestamp of log time in seconds or milliseconds (recommended) |
        /// | contents | No | Log content in `key-value` format. A log can contain multiple `key-value` pairs. |
        /// 
        /// `Content` description:
        /// 
        /// | Field | Required | Description |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | Key of a field group in one log, which cannot start with `_`.                 |
        /// | value  | Yes       | Value of a field group, which cannot exceed 1 MB in one log. The total value cannot exceed 5 MB in `LogGroup`. |
        /// 
        /// `LogTag` description:
        /// 
        /// | Field | Required | Description |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes       | Key of a custom tag                 |
        /// | value  | Yes       | Value corresponding to the custom tag key |
        /// 
        /// ## PB Compilation Sample
        /// 
        /// This sample describes how to use the protoc compiler to compile the PB description file into a log upload API in C++.
        /// 
        /// > ?Currently, protoc supports compilation in multiple programming languages such as Java, C++, and Python. For more information, please see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Install Protocol Buffer
        /// 
        /// Download [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), decompress the package, and install the tool. The version used in the sample is protobuf 2.6.1 running on CentOS 7.3. Run the following command to decompress the `protobuf-2.6.1.tar.gz` package to the `/usr/local` directory and enter the directory:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Run the following commands to start compilation and installation, and configure the environment variables:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After the compilation succeeds, run the following command to check the version:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create a PB description file
        /// 
        /// A PB description file is an agreed-on data exchange format for communication. To upload logs, please compile the specified protocol format to an API in the target programming language and add the API to the project code. For more information, please see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a PB message description file `cls.proto` based on the PB data format content specified by CLS.
        /// 
        /// > !The PB description file content cannot be modified, and the filename must end with `.proto`.
        /// 
        /// The content of `cls.proto` (PB description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // Key of each field group
        ///         required string value = 2; // Value of each field group
        ///     }
        ///     required int64   time     = 1; // Unix timestamp
        ///     repeated Content contents = 2; // Multiple `key-value` pairs in one log
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        ///     repeated Log    logs        = 1; // Log array consisting of multiple logs
        ///     optional string contextFlow = 2; // This parameter does not take effect currently
        ///     optional string filename    = 3; // Log filename
        ///     optional string source      = 4; // Log source, which is generally the server IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // Log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate the API
        /// 
        /// This sample uses the proto compiler to generate a C++ file in the same directory as the `cls.proto` file. Run the following compilation commands:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./` indicates that the file will be compiled in cpp format and output to the current directory. `./cls.proto` indicates the `cls.proto` description file in the current directory.
        /// 
        /// After the compilation succeeds, the code file in the corresponding programming language will be generated. This sample generates the `cls.pb.h` header file and [cls.pb.cc](http://cls.pb.cc) code implementation file as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call
        /// 
        /// Import the generated `cls.pb.h` header file into the code and call the API for data format encapsulation.
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public async Task<UploadLogResponse> UploadLog(UploadLogRequest req)
        {
             JsonResponseModel<UploadLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ## Feature Description
        /// 
        /// This API is used to write a log to the specified log topic.
        /// 
        /// CLS provides the following two modes:
        /// 
        /// #### Load balancing mode
        /// 
        /// In this mode, logs will be automatically written to a target partition among all readable/writable partitions under the current log topic based on the load balancing principle. This mode is suitable for scenarios where the sequential consumption is not needed.
        /// 
        /// #### Hash routing mode
        /// 
        /// In this mode, data will be written to a target partition that meets the range requirements based on the hash value (X-CLS-HashKey) carried by data. For example, a log source can be bound to a topic partition through `hashkey`, strictly guaranteeing the sequence of the data written to and consumed in this partition.
        /// 
        /// In addition, CLS allows you to upload logs in the following two modes:
        /// 
        /// 
        /// ## Request
        /// 
        /// #### Request header parameters
        /// 
        /// The `X-CLS-HashKey` request header indicates that logs are written to the CLS topic partitions with a range corresponding to the hashkey route, strictly guaranteeing the write sequence of logs to each topic partition for sequential consumption.
        /// 
        /// | Field | Type | Location | Required | Description |
        /// | ------------------ | ------ | ------ | -------- | ------------------------------------------------------------ |
        /// | X-CLS-HashKey | string | header | No       | Logs are written to the corresponding topic partition according to `hashkey` |
        /// | X-CLS-TopicId      | String | header | Yes       | Topic ID                                                       |                                                 |
        /// | Content-Type | String | header | Yes | Protocol type of the request parameter. Currently, only the PB protocol is supported. Please enter "application/octet-stream". |
        /// | X-TC-Action | String |	header | Yes | Common parameter. The value used for this API: UploadLog.                   
        /// | X-TC-Region | String | header | Yes	  | Common parameter. This parameter is not required for this API.                       
        /// | X-TC-Version | String | header | Yes | Common parameter. The value used for this API: 2020-10-16.                  
        /// 
        /// #### Input parameters (PB protocol)
        /// 
        /// | Field | Type | Location | Required | Description |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb    | Yes   | The logGroup list, which describes the encapsulated log groups. No more than five `logGroup` values are recommended.                     |
        /// 
        /// `LogGroup` description:
        /// 
        /// | Field | Required | Description |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | Yes       | Log array consisting of multiple `Log` values. The `Log` indicates a log, and a `LogGroup` can contain up to 10,000 `Log` values. |
        /// | contextFlow | No       | Unique LogGroup ID, which should be passed in if the context feature needs to be used. Format: "{context ID}-{LogGroupID}". <br>Context ID: uniquely identifies the context (a series of log files that are continuously scrolling or a series of logs that need to be sequenced), which is a 64-bit integer hex string. <br>LogGroupID: a 64-bit integer hex string that continuously increases, such as "102700A66102516A-59F59".                        |
        /// | filename    | No       | Log filename                                                   |
        /// | source      | No       | Log source, which is generally the server IP                           |
        /// | logTags     | No       | Tag list of the log                                               |
        /// 
        /// `Log` description:
        /// 
        /// | Field | Required | Description |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time | Yes | UNIX timestamp of log time in seconds or milliseconds (recommended) |
        /// | contents | No | Log content in `key-value` format. A log can contain multiple `key-value` pairs. |
        /// 
        /// `Content` description:
        /// 
        /// | Field | Required | Description |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | Yes       | Key of a field group in one log, which cannot start with `_`.                 |
        /// | value  | Yes       | Value of a field group, which cannot exceed 1 MB in one log. The total value cannot exceed 5 MB in `LogGroup`. |
        /// 
        /// `LogTag` description:
        /// 
        /// | Field | Required | Description |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | Yes       | Key of a custom tag                 |
        /// | value  | Yes       | Value corresponding to the custom tag key |
        /// 
        /// ## PB Compilation Sample
        /// 
        /// This sample describes how to use the protoc compiler to compile the PB description file into a log upload API in C++.
        /// 
        /// > ?Currently, protoc supports compilation in multiple programming languages such as Java, C++, and Python. For more information, please see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// #### 1. Install Protocol Buffer
        /// 
        /// Download [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz), decompress the package, and install the tool. The version used in the sample is protobuf 2.6.1 running on CentOS 7.3. Run the following command to decompress the `protobuf-2.6.1.tar.gz` package to the `/usr/local` directory and enter the directory:
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// Run the following commands to start compilation and installation, and configure the environment variables:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// After the compilation succeeds, run the following command to check the version:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. Create a PB description file
        /// 
        /// A PB description file is an agreed-on data exchange format for communication. To upload logs, please compile the specified protocol format to an API in the target programming language and add the API to the project code. For more information, please see [protoc](https://github.com/protocolbuffers/protobuf).
        /// 
        /// Create a PB message description file `cls.proto` based on the PB data format content specified by CLS.
        /// 
        /// > !The PB description file content cannot be modified, and the filename must end with `.proto`.
        /// 
        /// The content of `cls.proto` (PB description file) is as follows:
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // Key of each field group
        ///         required string value = 2; // Value of each field group
        ///     }
        ///     required int64   time     = 1; // Unix timestamp
        ///     repeated Content contents = 2; // Multiple `key-value` pairs in one log
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        ///     repeated Log    logs        = 1; // Log array consisting of multiple logs
        ///     optional string contextFlow = 2; // This parameter does not take effect currently
        ///     optional string filename    = 3; // Log filename
        ///     optional string source      = 4; // Log source, which is generally the server IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // Log group list
        /// }
        /// ```
        /// 
        /// #### 3. Compile and generate the API
        /// 
        /// This sample uses the proto compiler to generate a C++ file in the same directory as the `cls.proto` file. Run the following compilation commands:
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./` indicates that the file will be compiled in cpp format and output to the current directory. `./cls.proto` indicates the `cls.proto` description file in the current directory.
        /// 
        /// After the compilation succeeds, the code file in the corresponding programming language will be generated. This sample generates the `cls.pb.h` header file and [cls.pb.cc](http://cls.pb.cc) code implementation file as shown below:
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. Call
        /// 
        /// Import the generated `cls.pb.h` header file into the code and call the API for data format encapsulation.
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public UploadLogResponse UploadLogSync(UploadLogRequest req)
        {
             JsonResponseModel<UploadLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}