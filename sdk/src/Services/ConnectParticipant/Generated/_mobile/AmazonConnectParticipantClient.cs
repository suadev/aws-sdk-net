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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectParticipant.Model;
using Amazon.ConnectParticipant.Model.Internal.MarshallTransformations;
using Amazon.ConnectParticipant.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConnectParticipant
{
    /// <summary>
    /// Implementation for accessing ConnectParticipant
    ///
    /// Amazon Connect is a cloud-based contact center solution that makes it easy to set
    /// up and manage a customer contact center and provide reliable customer engagement at
    /// any scale.
    /// 
    ///  
    /// <para>
    /// Amazon Connect enables customer contacts through voice or chat.
    /// </para>
    ///  
    /// <para>
    /// The APIs described here are used by chat participants, such as agents and customers.
    /// </para>
    /// </summary>
    public partial class AmazonConnectParticipantClient : AmazonServiceClient, IAmazonConnectParticipant
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectParticipantMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonConnectParticipantClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectParticipantConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectParticipantConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(AmazonConnectParticipantConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectParticipantConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials and an
        /// AmazonConnectParticipantClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials, AmazonConnectParticipantConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectParticipantConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectParticipantClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectParticipantConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectParticipantConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectParticipantClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectParticipantConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateParticipantConnection

        internal virtual CreateParticipantConnectionResponse CreateParticipantConnection(CreateParticipantConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateParticipantConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates the participant's connection. Note that ParticipantToken is used for invoking
        /// this API instead of ConnectionToken.
        /// 
        ///  
        /// <para>
        /// The participant token is valid for the lifetime of the participant – until the they
        /// are part of a contact.
        /// </para>
        ///  
        /// <para>
        /// The response URL for <code>WEBSOCKET</code> Type has a connect expiry timeout of 100s.
        /// Clients must manually connect to the returned websocket URL and subscribe to the desired
        /// topic. 
        /// </para>
        ///  
        /// <para>
        /// For chat, you need to publish the following on the established websocket connection:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</code> 
        /// </para>
        ///  
        /// <para>
        /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
        /// clients need to call this API again to obtain a new websocket URL and perform the
        /// same steps as before.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParticipantConnection service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        public virtual Task<CreateParticipantConnectionResponse> CreateParticipantConnectionAsync(CreateParticipantConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParticipantConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectParticipant

        internal virtual DisconnectParticipantResponse DisconnectParticipant(DisconnectParticipantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return Invoke<DisconnectParticipantResponse>(request, options);
        }



        /// <summary>
        /// Disconnects a participant. Note that ConnectionToken is used for invoking this API
        /// instead of ParticipantToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual Task<DisconnectParticipantResponse> DisconnectParticipantAsync(DisconnectParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectParticipantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTranscript

        internal virtual GetTranscriptResponse GetTranscript(GetTranscriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a transcript of the session. Note that ConnectionToken is used for invoking
        /// this API instead of ParticipantToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTranscript service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        public virtual Task<GetTranscriptResponse> GetTranscriptAsync(GetTranscriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;

            return InvokeAsync<GetTranscriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEvent

        internal virtual SendEventResponse SendEvent(SendEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return Invoke<SendEventResponse>(request, options);
        }



        /// <summary>
        /// Sends an event. Note that ConnectionToken is used for invoking this API instead of
        /// ParticipantToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual Task<SendEventResponse> SendEventAsync(SendEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return InvokeAsync<SendEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendMessage

        internal virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }



        /// <summary>
        /// Sends a message. Note that ConnectionToken is used for invoking this API instead of
        /// ParticipantToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}