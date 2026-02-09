using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSwap
{
    public class OrderService
    {
        private readonly ILogger _logger;
        public OrderService(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessOrder(string orderId)
        {
            _logger.Log($"Order started {orderId}");
            _logger.Log($"Order finished {orderId}");
        }
    }
}
