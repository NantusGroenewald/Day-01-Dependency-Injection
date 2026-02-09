using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSwap
{
    public class OrderService
    {
        private readonly IServiceProvider _serviceProvider;
        public OrderService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ProcessOrder(string orderId)
        {
            var logger = _serviceProvider.GetService(typeof(ILogger)) as ILogger;
            logger.Log($"Order started {orderId}");
            logger.Log($"Order finished {orderId}");
        }
    }
}
