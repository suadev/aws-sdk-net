/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the BatchPutScheduledUpdateGroupAction operation.
    /// </summary>
    public partial class BatchPutScheduledUpdateGroupActionResponse : AmazonWebServiceResponse
    {
        private List<FailedScheduledUpdateGroupActionRequest> _failedScheduledUpdateGroupActions = new List<FailedScheduledUpdateGroupActionRequest>();

        /// <summary>
        /// Gets and sets the property FailedScheduledUpdateGroupActions. 
        /// <para>
        /// The names of the scheduled actions that could not be created or updated, including
        /// an error message.
        /// </para>
        /// </summary>
        public List<FailedScheduledUpdateGroupActionRequest> FailedScheduledUpdateGroupActions
        {
            get { return this._failedScheduledUpdateGroupActions; }
            set { this._failedScheduledUpdateGroupActions = value; }
        }

        // Check to see if FailedScheduledUpdateGroupActions property is set
        internal bool IsSetFailedScheduledUpdateGroupActions()
        {
            return this._failedScheduledUpdateGroupActions != null && this._failedScheduledUpdateGroupActions.Count > 0; 
        }

    }
}