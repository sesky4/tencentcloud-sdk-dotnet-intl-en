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

namespace TencentCloud.Cdwpg.V20201230
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwpg.V20201230.Models;

   public class CdwpgClient : AbstractClient{

       private const string endpoint = "cdwpg.intl.tencentcloudapi.com";
       private const string version = "2020-12-30";
       private const string sdkVersion = "SDK_NET_3.0.1096";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwpgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwpgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create  instance
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public Task<CreateInstanceByApiResponse> CreateInstanceByApi(CreateInstanceByApiRequest req)
        {
            return InternalRequestAsync<CreateInstanceByApiResponse>(req, "CreateInstanceByApi");
        }

        /// <summary>
        /// This API is used to create  instance
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public CreateInstanceByApiResponse CreateInstanceByApiSync(CreateInstanceByApiRequest req)
        {
            return InternalRequestAsync<CreateInstanceByApiResponse>(req, "CreateInstanceByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance information by an instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// This API is used to query the instance information by an instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceInfoResponse"/></returns>
        public Task<DescribeInstanceInfoResponse> DescribeInstanceInfo(DescribeInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceInfoResponse>(req, "DescribeInstanceInfo");
        }

        /// <summary>
        /// This API is used to get instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceInfoResponse"/></returns>
        public DescribeInstanceInfoResponse DescribeInstanceInfoSync(DescribeInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceInfoResponse>(req, "DescribeInstanceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display instance status, process progress, etc., in the instance details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState");
        }

        /// <summary>
        /// This API is used to display instance status, process progress, etc., in the instance details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of  instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to get a list of  instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of instance
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public Task<DescribeSimpleInstancesResponse> DescribeSimpleInstances(DescribeSimpleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleInstancesResponse>(req, "DescribeSimpleInstances");
        }

        /// <summary>
        /// This API is used to get a list of instance
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public DescribeSimpleInstancesResponse DescribeSimpleInstancesSync(DescribeSimpleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleInstancesResponse>(req, "DescribeSimpleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to destroy instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public Task<DestroyInstanceByApiResponse> DestroyInstanceByApi(DestroyInstanceByApiRequest req)
        {
            return InternalRequestAsync<DestroyInstanceByApiResponse>(req, "DestroyInstanceByApi");
        }

        /// <summary>
        /// This API is used to destroy instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public DestroyInstanceByApiResponse DestroyInstanceByApiSync(DestroyInstanceByApiRequest req)
        {
            return InternalRequestAsync<DestroyInstanceByApiResponse>(req, "DestroyInstanceByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance information. Only the name of an instance can be modified currently.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify instance information. Only the name of an instance can be modified currently.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
