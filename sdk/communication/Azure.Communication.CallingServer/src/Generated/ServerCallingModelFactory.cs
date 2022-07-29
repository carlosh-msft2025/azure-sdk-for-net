// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ServerCallingModelFactory
    {
        /// <summary> Initializes a new instance of TransferCallToParticipantResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallingServer.TransferCallToParticipantResult"/> instance for mocking. </returns>
        public static TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null)
        {
            return new TransferCallToParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of RemoveParticipantsResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallingServer.RemoveParticipantsResult"/> instance for mocking. </returns>
        public static RemoveParticipantsResult RemoveParticipantsResult(string operationContext = null)
        {
            return new RemoveParticipantsResult(operationContext);
        }

        /// <summary> Initializes a new instance of RecordingStatusResult. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingStatus"></param>
        /// <returns> A new <see cref="CallingServer.RecordingStatusResult"/> instance for mocking. </returns>
        public static RecordingStatusResult RecordingStatusResult(string recordingId = null, RecordingStatus? recordingStatus = null)
        {
            return new RecordingStatusResult(recordingId, recordingStatus);
        }

        /// <summary> Initializes a new instance of ResultInformation. </summary>
        /// <param name="code"></param>
        /// <param name="subCode"></param>
        /// <param name="message"></param>
        /// <returns> A new <see cref="CallingServer.ResultInformation"/> instance for mocking. </returns>
        public static ResultInformation ResultInformation(int? code = null, int? subCode = null, string message = null)
        {
            return new ResultInformation(code, subCode, message);
        }

        /// <summary> Initializes a new instance of CallConnected. </summary>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallingServer.CallConnected"/> instance for mocking. </returns>
        public static CallConnected CallConnected(AcsEventType eventType = default, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new CallConnected(eventType, callConnectionId, serverCallId, correlationId);
        }

        /// <summary> Initializes a new instance of CallDisconnected. </summary>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallingServer.CallDisconnected"/> instance for mocking. </returns>
        public static CallDisconnected CallDisconnected(AcsEventType eventType = default, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new CallDisconnected(eventType, callConnectionId, serverCallId, correlationId);
        }

        /// <summary> Initializes a new instance of CallTransferAccepted. </summary>
        /// <param name="operationContext"> Operation context. </param>
        /// <param name="resultInfo"></param>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallingServer.CallTransferAccepted"/> instance for mocking. </returns>
        public static CallTransferAccepted CallTransferAccepted(string operationContext = null, ResultInformation resultInfo = null, AcsEventType eventType = default, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new CallTransferAccepted(operationContext, resultInfo, eventType, callConnectionId, serverCallId, correlationId);
        }

        /// <summary> Initializes a new instance of CallTransferFailed. </summary>
        /// <param name="operationContext"> Operation context. </param>
        /// <param name="resultInfo"></param>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallingServer.CallTransferFailed"/> instance for mocking. </returns>
        public static CallTransferFailed CallTransferFailed(string operationContext = null, ResultInformation resultInfo = null, AcsEventType eventType = default, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new CallTransferFailed(operationContext, resultInfo, eventType, callConnectionId, serverCallId, correlationId);
        }
    }
}
