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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Distribution Request Marshaller
    /// </summary>       
    public class UpdateDistributionRequestMarshaller : IMarshaller<IRequest, UpdateDistributionRequest>
    {
        
    
        public IRequest Marshall(UpdateDistributionRequest updateDistributionRequest)
        {
            IRequest request = new DefaultRequest(updateDistributionRequest, "AmazonCloudFront");



            request.HttpMethod = "PUT";
        if(updateDistributionRequest.IsSetIfMatch())
            request.Headers.Add("If-Match", updateDistributionRequest.IfMatch);
            
            string uriResourcePath = "2013-09-27/distribution/{Id}/config"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", updateDistributionRequest.IsSetId() ? updateDistributionRequest.Id.ToString() : "" ); 

            if (uriResourcePath.Contains("?")) 
            {
                int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                
                uriResourcePath    = uriResourcePath.Substring(0, queryIndex);
                
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
                {
                       
                    if (updateDistributionRequest != null) 
        {
            DistributionConfig distributionConfigDistributionConfig = updateDistributionRequest.DistributionConfig;
            if (distributionConfigDistributionConfig != null) 
            {
                xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                if (distributionConfigDistributionConfig.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2013-09-27/", distributionConfigDistributionConfig.CallerReference.ToString(CultureInfo.InvariantCulture));
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    Aliases aliasesAliases = distributionConfigDistributionConfig.Aliases;
                    if (aliasesAliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (aliasesAliases.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", aliasesAliases.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (aliasesAliases != null) 
                        {
                            List<string> aliasesAliasesitemsList = aliasesAliases.Items;
                            if (aliasesAliasesitemsList != null && aliasesAliasesitemsList.Count > 0) 
                            {
                                int aliasesAliasesitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (string aliasesAliasesitemsListValue in aliasesAliasesitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    xmlWriter.WriteValue(aliasesAliasesitemsListValue);
                                xmlWriter.WriteEndElement();


                                    aliasesAliasesitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig.IsSetDefaultRootObject()) 
                {
                    xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2013-09-27/", distributionConfigDistributionConfig.DefaultRootObject.ToString(CultureInfo.InvariantCulture));
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    Origins originsOrigins = distributionConfigDistributionConfig.Origins;
                    if (originsOrigins != null) 
                    {
                        xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (originsOrigins.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", originsOrigins.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (originsOrigins != null) 
                        {
                            List<Origin> originsOriginsitemsList = originsOrigins.Items;
                            if (originsOriginsitemsList != null && originsOriginsitemsList.Count > 0) 
                            {
                                int originsOriginsitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (Origin originsOriginsitemsListValue in originsOriginsitemsList) 
                                {
                                    xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    if (originsOriginsitemsListValue.IsSetId()) 
                                    {
                                        xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2013-09-27/", originsOriginsitemsListValue.Id.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (originsOriginsitemsListValue.IsSetDomainName()) 
                                    {
                                        xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2013-09-27/", originsOriginsitemsListValue.DomainName.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (originsOriginsitemsListValue != null) 
                                    {
                                        S3OriginConfig s3OriginConfigS3OriginConfig = originsOriginsitemsListValue.S3OriginConfig;
                                        if (s3OriginConfigS3OriginConfig != null) 
                                        {
                                            xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            if (s3OriginConfigS3OriginConfig.IsSetOriginAccessIdentity()) 
                                            {
                                                xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", s3OriginConfigS3OriginConfig.OriginAccessIdentity.ToString(CultureInfo.InvariantCulture));
                                              }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (originsOriginsitemsListValue != null) 
                                    {
                                        CustomOriginConfig customOriginConfigCustomOriginConfig = originsOriginsitemsListValue.CustomOriginConfig;
                                        if (customOriginConfigCustomOriginConfig != null) 
                                        {
                                            xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            if (customOriginConfigCustomOriginConfig.IsSetHTTPPort()) 
                                            {
                                                xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customOriginConfigCustomOriginConfig.HTTPPort.ToString(CultureInfo.InvariantCulture));
                                              }
                                            if (customOriginConfigCustomOriginConfig.IsSetHTTPSPort()) 
                                            {
                                                xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customOriginConfigCustomOriginConfig.HTTPSPort.ToString(CultureInfo.InvariantCulture));
                                              }
                                            if (customOriginConfigCustomOriginConfig.IsSetOriginProtocolPolicy()) 
                                            {
                                                xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customOriginConfigCustomOriginConfig.OriginProtocolPolicy.ToString(CultureInfo.InvariantCulture));
                                              }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                xmlWriter.WriteEndElement();


                                    originsOriginsitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig != null) 
                {
                    DefaultCacheBehavior defaultCacheBehaviorDefaultCacheBehavior = distributionConfigDistributionConfig.DefaultCacheBehavior;
                    if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                    {
                        xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetTargetOriginId()) 
                        {
                            xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2013-09-27/", defaultCacheBehaviorDefaultCacheBehavior.TargetOriginId.ToString(CultureInfo.InvariantCulture));
                          }
                        if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                        {
                            ForwardedValues forwardedValuesForwardedValues = defaultCacheBehaviorDefaultCacheBehavior.ForwardedValues;
                            if (forwardedValuesForwardedValues != null) 
                            {
                                xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                if (forwardedValuesForwardedValues.IsSetQueryString()) 
                                {
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2013-09-27/", forwardedValuesForwardedValues.QueryString.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                                  }
                                if (forwardedValuesForwardedValues != null) 
                                {
                                    CookiePreference cookiePreferenceCookies = forwardedValuesForwardedValues.Cookies;
                                    if (cookiePreferenceCookies != null) 
                                    {
                                        xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                        if (cookiePreferenceCookies.IsSetForward()) 
                                        {
                                            xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cookiePreferenceCookies.Forward.ToString(CultureInfo.InvariantCulture));
                                          }
                                        if (cookiePreferenceCookies != null) 
                                        {
                                            CookieNames cookieNamesWhitelistedNames = cookiePreferenceCookies.WhitelistedNames;
                                            if (cookieNamesWhitelistedNames != null) 
                                            {
                                                xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                if (cookieNamesWhitelistedNames.IsSetQuantity()) 
                                                {
                                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cookieNamesWhitelistedNames.Quantity.ToString(CultureInfo.InvariantCulture));
                                                  }

                                                if (cookieNamesWhitelistedNames != null) 
                                                {
                                                    List<string> cookieNamesWhitelistedNamesitemsList = cookieNamesWhitelistedNames.Items;
                                                    if (cookieNamesWhitelistedNamesitemsList != null && cookieNamesWhitelistedNamesitemsList.Count > 0) 
                                                    {
                                                        int cookieNamesWhitelistedNamesitemsListIndex = 1;
                                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                        foreach (string cookieNamesWhitelistedNamesitemsListValue in cookieNamesWhitelistedNamesitemsList) 
                                                        {
                                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                            xmlWriter.WriteValue(cookieNamesWhitelistedNamesitemsListValue);
                                                        xmlWriter.WriteEndElement();


                                                            cookieNamesWhitelistedNamesitemsListIndex++;
                                                        }
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                        {
                            TrustedSigners trustedSignersTrustedSigners = defaultCacheBehaviorDefaultCacheBehavior.TrustedSigners;
                            if (trustedSignersTrustedSigners != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                if (trustedSignersTrustedSigners.IsSetEnabled()) 
                                {
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                                  }
                                if (trustedSignersTrustedSigners.IsSetQuantity()) 
                                {
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Quantity.ToString(CultureInfo.InvariantCulture));
                                  }

                                if (trustedSignersTrustedSigners != null) 
                                {
                                    List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                                    if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                                    {
                                        int trustedSignersTrustedSignersitemsListIndex = 1;
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                        foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                        {
                                            xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            xmlWriter.WriteValue(trustedSignersTrustedSignersitemsListValue);
                                        xmlWriter.WriteEndElement();


                                            trustedSignersTrustedSignersitemsListIndex++;
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetViewerProtocolPolicy()) 
                        {
                            xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-09-27/", defaultCacheBehaviorDefaultCacheBehavior.ViewerProtocolPolicy.ToString(CultureInfo.InvariantCulture));
                          }
                        if (defaultCacheBehaviorDefaultCacheBehavior.IsSetMinTTL()) 
                        {
                            xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2013-09-27/", defaultCacheBehaviorDefaultCacheBehavior.MinTTL.ToString(CultureInfo.InvariantCulture));
                          }
                        if (defaultCacheBehaviorDefaultCacheBehavior != null) 
                        {
                            AllowedMethods allowedMethodsAllowedMethods = defaultCacheBehaviorDefaultCacheBehavior.AllowedMethods;
                            if (allowedMethodsAllowedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                if (allowedMethodsAllowedMethods.IsSetQuantity()) 
                                {
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", allowedMethodsAllowedMethods.Quantity.ToString(CultureInfo.InvariantCulture));
                                  }

                                if (allowedMethodsAllowedMethods != null) 
                                {
                                    List<string> allowedMethodsAllowedMethodsitemsList = allowedMethodsAllowedMethods.Items;
                                    if (allowedMethodsAllowedMethodsitemsList != null && allowedMethodsAllowedMethodsitemsList.Count > 0) 
                                    {
                                        int allowedMethodsAllowedMethodsitemsListIndex = 1;
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                        foreach (string allowedMethodsAllowedMethodsitemsListValue in allowedMethodsAllowedMethodsitemsList) 
                                        {
                                            xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            xmlWriter.WriteValue(allowedMethodsAllowedMethodsitemsListValue);
                                        xmlWriter.WriteEndElement();


                                            allowedMethodsAllowedMethodsitemsListIndex++;
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig != null) 
                {
                    CacheBehaviors cacheBehaviorsCacheBehaviors = distributionConfigDistributionConfig.CacheBehaviors;
                    if (cacheBehaviorsCacheBehaviors != null) 
                    {
                        xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (cacheBehaviorsCacheBehaviors.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cacheBehaviorsCacheBehaviors.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (cacheBehaviorsCacheBehaviors != null) 
                        {
                            List<CacheBehavior> cacheBehaviorsCacheBehaviorsitemsList = cacheBehaviorsCacheBehaviors.Items;
                            if (cacheBehaviorsCacheBehaviorsitemsList != null && cacheBehaviorsCacheBehaviorsitemsList.Count > 0) 
                            {
                                int cacheBehaviorsCacheBehaviorsitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (CacheBehavior cacheBehaviorsCacheBehaviorsitemsListValue in cacheBehaviorsCacheBehaviorsitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetPathPattern()) 
                                    {
                                        xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cacheBehaviorsCacheBehaviorsitemsListValue.PathPattern.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetTargetOriginId()) 
                                    {
                                        xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cacheBehaviorsCacheBehaviorsitemsListValue.TargetOriginId.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue != null) 
                                    {
                                        ForwardedValues forwardedValuesForwardedValues = cacheBehaviorsCacheBehaviorsitemsListValue.ForwardedValues;
                                        if (forwardedValuesForwardedValues != null) 
                                        {
                                            xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            if (forwardedValuesForwardedValues.IsSetQueryString()) 
                                            {
                                                xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2013-09-27/", forwardedValuesForwardedValues.QueryString.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                                              }
                                            if (forwardedValuesForwardedValues != null) 
                                            {
                                                CookiePreference cookiePreferenceCookies = forwardedValuesForwardedValues.Cookies;
                                                if (cookiePreferenceCookies != null) 
                                                {
                                                    xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                    if (cookiePreferenceCookies.IsSetForward()) 
                                                    {
                                                        xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cookiePreferenceCookies.Forward.ToString(CultureInfo.InvariantCulture));
                                                      }
                                                    if (cookiePreferenceCookies != null) 
                                                    {
                                                        CookieNames cookieNamesWhitelistedNames = cookiePreferenceCookies.WhitelistedNames;
                                                        if (cookieNamesWhitelistedNames != null) 
                                                        {
                                                            xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                            if (cookieNamesWhitelistedNames.IsSetQuantity()) 
                                                            {
                                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cookieNamesWhitelistedNames.Quantity.ToString(CultureInfo.InvariantCulture));
                                                              }

                                                            if (cookieNamesWhitelistedNames != null) 
                                                            {
                                                                List<string> cookieNamesWhitelistedNamesitemsList = cookieNamesWhitelistedNames.Items;
                                                                if (cookieNamesWhitelistedNamesitemsList != null && cookieNamesWhitelistedNamesitemsList.Count > 0) 
                                                                {
                                                                    int cookieNamesWhitelistedNamesitemsListIndex = 1;
                                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                                    foreach (string cookieNamesWhitelistedNamesitemsListValue in cookieNamesWhitelistedNamesitemsList) 
                                                                    {
                                                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                                        xmlWriter.WriteValue(cookieNamesWhitelistedNamesitemsListValue);
                                                                    xmlWriter.WriteEndElement();


                                                                        cookieNamesWhitelistedNamesitemsListIndex++;
                                                                    }
                                                                    xmlWriter.WriteEndElement();
                                                                }
                                                            }
                                                            xmlWriter.WriteEndElement();
                                                        }
                                                    }
                                                    xmlWriter.WriteEndElement();
                                                }
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue != null) 
                                    {
                                        TrustedSigners trustedSignersTrustedSigners = cacheBehaviorsCacheBehaviorsitemsListValue.TrustedSigners;
                                        if (trustedSignersTrustedSigners != null) 
                                        {
                                            xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            if (trustedSignersTrustedSigners.IsSetEnabled()) 
                                            {
                                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                                              }
                                            if (trustedSignersTrustedSigners.IsSetQuantity()) 
                                            {
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", trustedSignersTrustedSigners.Quantity.ToString(CultureInfo.InvariantCulture));
                                              }

                                            if (trustedSignersTrustedSigners != null) 
                                            {
                                                List<string> trustedSignersTrustedSignersitemsList = trustedSignersTrustedSigners.Items;
                                                if (trustedSignersTrustedSignersitemsList != null && trustedSignersTrustedSignersitemsList.Count > 0) 
                                                {
                                                    int trustedSignersTrustedSignersitemsListIndex = 1;
                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                    foreach (string trustedSignersTrustedSignersitemsListValue in trustedSignersTrustedSignersitemsList) 
                                                    {
                                                        xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                        xmlWriter.WriteValue(trustedSignersTrustedSignersitemsListValue);
                                                    xmlWriter.WriteEndElement();


                                                        trustedSignersTrustedSignersitemsListIndex++;
                                                    }
                                                    xmlWriter.WriteEndElement();
                                                }
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetViewerProtocolPolicy()) 
                                    {
                                        xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cacheBehaviorsCacheBehaviorsitemsListValue.ViewerProtocolPolicy.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue.IsSetMinTTL()) 
                                    {
                                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2013-09-27/", cacheBehaviorsCacheBehaviorsitemsListValue.MinTTL.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (cacheBehaviorsCacheBehaviorsitemsListValue != null) 
                                    {
                                        AllowedMethods allowedMethodsAllowedMethods = cacheBehaviorsCacheBehaviorsitemsListValue.AllowedMethods;
                                        if (allowedMethodsAllowedMethods != null) 
                                        {
                                            xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                            if (allowedMethodsAllowedMethods.IsSetQuantity()) 
                                            {
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", allowedMethodsAllowedMethods.Quantity.ToString(CultureInfo.InvariantCulture));
                                              }

                                            if (allowedMethodsAllowedMethods != null) 
                                            {
                                                List<string> allowedMethodsAllowedMethodsitemsList = allowedMethodsAllowedMethods.Items;
                                                if (allowedMethodsAllowedMethodsitemsList != null && allowedMethodsAllowedMethodsitemsList.Count > 0) 
                                                {
                                                    int allowedMethodsAllowedMethodsitemsListIndex = 1;
                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                    foreach (string allowedMethodsAllowedMethodsitemsListValue in allowedMethodsAllowedMethodsitemsList) 
                                                    {
                                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                                        xmlWriter.WriteValue(allowedMethodsAllowedMethodsitemsListValue);
                                                    xmlWriter.WriteEndElement();


                                                        allowedMethodsAllowedMethodsitemsListIndex++;
                                                    }
                                                    xmlWriter.WriteEndElement();
                                                }
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                    }
                                xmlWriter.WriteEndElement();


                                    cacheBehaviorsCacheBehaviorsitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig != null) 
                {
                    CustomErrorResponses customErrorResponsesCustomErrorResponses = distributionConfigDistributionConfig.CustomErrorResponses;
                    if (customErrorResponsesCustomErrorResponses != null) 
                    {
                        xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (customErrorResponsesCustomErrorResponses.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customErrorResponsesCustomErrorResponses.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (customErrorResponsesCustomErrorResponses != null) 
                        {
                            List<CustomErrorResponse> customErrorResponsesCustomErrorResponsesitemsList = customErrorResponsesCustomErrorResponses.Items;
                            if (customErrorResponsesCustomErrorResponsesitemsList != null && customErrorResponsesCustomErrorResponsesitemsList.Count > 0) 
                            {
                                int customErrorResponsesCustomErrorResponsesitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                foreach (CustomErrorResponse customErrorResponsesCustomErrorResponsesitemsListValue in customErrorResponsesCustomErrorResponsesitemsList) 
                                {
                                    xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                                    if (customErrorResponsesCustomErrorResponsesitemsListValue.IsSetErrorCode()) 
                                    {
                                        xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customErrorResponsesCustomErrorResponsesitemsListValue.ErrorCode.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (customErrorResponsesCustomErrorResponsesitemsListValue.IsSetResponsePagePath()) 
                                    {
                                        xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customErrorResponsesCustomErrorResponsesitemsListValue.ResponsePagePath.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (customErrorResponsesCustomErrorResponsesitemsListValue.IsSetResponseCode()) 
                                    {
                                        xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customErrorResponsesCustomErrorResponsesitemsListValue.ResponseCode.ToString(CultureInfo.InvariantCulture));
                                      }
                                    if (customErrorResponsesCustomErrorResponsesitemsListValue.IsSetErrorCachingMinTTL()) 
                                    {
                                        xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2013-09-27/", customErrorResponsesCustomErrorResponsesitemsListValue.ErrorCachingMinTTL.ToString(CultureInfo.InvariantCulture));
                                      }
                                xmlWriter.WriteEndElement();


                                    customErrorResponsesCustomErrorResponsesitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2013-09-27/", distributionConfigDistributionConfig.Comment.ToString(CultureInfo.InvariantCulture));
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    LoggingConfig loggingConfigLogging = distributionConfigDistributionConfig.Logging;
                    if (loggingConfigLogging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (loggingConfigLogging.IsSetEnabled()) 
                        {
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", loggingConfigLogging.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                          }
                        if (loggingConfigLogging.IsSetIncludeCookies()) 
                        {
                            xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2013-09-27/", loggingConfigLogging.IncludeCookies.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                          }
                        if (loggingConfigLogging.IsSetBucket()) 
                        {
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2013-09-27/", loggingConfigLogging.Bucket.ToString(CultureInfo.InvariantCulture));
                          }
                        if (loggingConfigLogging.IsSetPrefix()) 
                        {
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2013-09-27/", loggingConfigLogging.Prefix.ToString(CultureInfo.InvariantCulture));
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (distributionConfigDistributionConfig.IsSetPriceClass()) 
                {
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2013-09-27/", distributionConfigDistributionConfig.PriceClass.ToString(CultureInfo.InvariantCulture));
                  }
                if (distributionConfigDistributionConfig.IsSetEnabled()) 
                {
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2013-09-27/", distributionConfigDistributionConfig.Enabled.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                  }
                if (distributionConfigDistributionConfig != null) 
                {
                    ViewerCertificate viewerCertificateViewerCertificate = distributionConfigDistributionConfig.ViewerCertificate;
                    if (viewerCertificateViewerCertificate != null) 
                    {
                        xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2013-09-27/");
                        if (viewerCertificateViewerCertificate.IsSetIAMCertificateId()) 
                        {
                            xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2013-09-27/", viewerCertificateViewerCertificate.IAMCertificateId.ToString(CultureInfo.InvariantCulture));
                          }
                        if (viewerCertificateViewerCertificate.IsSetCloudFrontDefaultCertificate()) 
                        {
                            xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2013-09-27/", viewerCertificateViewerCertificate.CloudFrontDefaultCertificate.ToString(CultureInfo.InvariantCulture).ToLower(CultureInfo.InvariantCulture));
                          }
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();
            }
        }

            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                
                
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
        
            
            return request;
        }
    }
}
    
