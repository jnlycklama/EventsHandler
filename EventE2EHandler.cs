// --------------------------------------------------------------------------
// <copyright file="EventE2EHandler.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------

// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EventHandler
{
    public static class EventE2EHandler
    {
        [FunctionName("EventE2EHandler")]
        [return: Queue("eventsqueue")]
        public static string Run([EventGridTrigger]EventGridEvent eventGridEvent, ILogger log)
        {
            return JsonConvert.SerializeObject(eventGridEvent);
        }
    }
}
