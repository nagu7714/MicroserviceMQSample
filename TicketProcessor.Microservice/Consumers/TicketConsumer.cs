using MassTransit;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketProcessor.Microservice.Consumers
{
    public class TicketConsumer : IConsumer<Ticket>
    {

        public async Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;
        }
    }
}
