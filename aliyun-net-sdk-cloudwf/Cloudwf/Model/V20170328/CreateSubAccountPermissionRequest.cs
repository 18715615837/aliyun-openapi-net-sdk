/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class CreateSubAccountPermissionRequest : RpcAcsRequest<CreateSubAccountPermissionResponse>
    {
        public CreateSubAccountPermissionRequest()
            : base("cloudwf", "2017-03-28", "CreateSubAccountPermission", "cloudwf", "openAPI")
        {
        }

		private long? uid;

		private List<long?> shopGroupIdss;

		private List<long?> shopIdss;

		private string pagePermission;

		private string accessKeyId;

		private int? permissionType;

		private List<long?> businessIdss;

		public long? Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value.ToString());
			}
		}

		public List<long?> ShopGroupIdss
		{
			get
			{
				return shopGroupIdss;
			}

			set
			{
				shopGroupIdss = value;
				for (int i = 0; i < shopGroupIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ShopGroupIds." + (i + 1) , shopGroupIdss[i]);
				}
			}
		}

		public List<long?> ShopIdss
		{
			get
			{
				return shopIdss;
			}

			set
			{
				shopIdss = value;
				for (int i = 0; i < shopIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ShopIds." + (i + 1) , shopIdss[i]);
				}
			}
		}

		public string PagePermission
		{
			get
			{
				return pagePermission;
			}
			set	
			{
				pagePermission = value;
				DictionaryUtil.Add(QueryParameters, "PagePermission", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? PermissionType
		{
			get
			{
				return permissionType;
			}
			set	
			{
				permissionType = value;
				DictionaryUtil.Add(QueryParameters, "PermissionType", value.ToString());
			}
		}

		public List<long?> BusinessIdss
		{
			get
			{
				return businessIdss;
			}

			set
			{
				businessIdss = value;
				for (int i = 0; i < businessIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BusinessIds." + (i + 1) , businessIdss[i]);
				}
			}
		}

        public override CreateSubAccountPermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSubAccountPermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
