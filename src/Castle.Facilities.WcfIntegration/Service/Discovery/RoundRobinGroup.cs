// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Facilities.WcfIntegration
{
#if DOTNET40
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ServiceModel.Discovery;

    public class RoundRobinGroup : IServiceContractGroup
    {
		public int Count
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}

		public void Add(EndpointDiscoveryMetadata endpoint)
		{
			throw new NotImplementedException();
		}

        public bool Contains(EndpointDiscoveryMetadata endpoint)
        {
            throw new NotImplementedException();
        }

        public bool Remove(EndpointDiscoveryMetadata endpoint)
        {
            throw new NotImplementedException();
        }

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void CopyTo(EndpointDiscoveryMetadata[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<EndpointDiscoveryMetadata> GetEnumerator()
		{
			throw new NotImplementedException();
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
#endif
}

