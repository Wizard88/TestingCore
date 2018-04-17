using System;
using System.Threading.Tasks;
using TestingCore.CommandAbstraction;
using TestingCore.CommunicationAbstraction;
using TestingCore.TransactionAbstraction;

namespace TestingCore.TransactionImplementation
{
    internal class StandardTransaction : ITransaction
    {
        private IPort port;

        public StandardTransaction(IPort port)
        {
            this.port = port;
        }

        public async Task<string> Execute(ICommand command, int timeout = 500)
        {
            byte[] bytes = null;
            try
            {
                await port.Send(command.GetKey());
                bytes = await port.Receive(timeout);
            }
            catch (Exception exc)
            {
                throw exc;
            }

            var response = System.Text.Encoding.UTF8.GetString(bytes);

            if (command.IsExpected(response))
                return response.Replace("\r\n", "");
            else
                throw new NotValidResponseException(response);
        }
    }
}
