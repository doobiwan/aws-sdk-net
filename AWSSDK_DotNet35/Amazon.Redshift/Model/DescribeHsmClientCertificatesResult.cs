/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeHsmClientCertificatesResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<HsmClientCertificate> hsmClientCertificates = new List<HsmClientCertificate>();


        /// <summary>
        /// A marker at which to continue listing events in a new request. The response returns a marker if there are more events to list than returned
        /// in the response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of the identifiers for one or more HSM client certificates used by Amazon Redshift clusters to store and retrieve database encryption
        /// keys in an HSM.
        ///  
        /// </summary>
        public List<HsmClientCertificate> HsmClientCertificates
        {
            get { return this.hsmClientCertificates; }
            set { this.hsmClientCertificates = value; }
        }

        // Check to see if HsmClientCertificates property is set
        internal bool IsSetHsmClientCertificates()
        {
            return this.hsmClientCertificates.Count > 0;
        }
    }
}
