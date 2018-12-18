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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <b>Information about the client certificate used for authentication.</b>
    /// </summary>
    public partial class CertificateAuthentication
    {
        private string _clientRootCertificateChain;

        /// <summary>
        /// Gets and sets the property ClientRootCertificateChain. 
        /// <para>
        ///  <b>The ARN of the client certificate. </b> 
        /// </para>
        /// </summary>
        public string ClientRootCertificateChain
        {
            get { return this._clientRootCertificateChain; }
            set { this._clientRootCertificateChain = value; }
        }

        // Check to see if ClientRootCertificateChain property is set
        internal bool IsSetClientRootCertificateChain()
        {
            return this._clientRootCertificateChain != null;
        }

    }
}