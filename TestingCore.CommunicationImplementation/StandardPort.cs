using KvTeam.DeviceIo;
using System;
using System.Threading.Tasks;
using TestingCore.CommunicationAbstraction;

namespace TestingCore.CommunicationImplementation
{
    public class StandardPort : IPort
    {
        private DeviceIo _deviceIo;

        public StandardPort(DeviceIo deviceIo)
        {
            _deviceIo = deviceIo;
        }

        public async Task Send(string command)
        {
            try
            {
                await _deviceIo.WriteCommandAsync(command);
            }
            catch (TimeoutException timeoutException)
            {
                throw new TimeoutException("Timeout expired", timeoutException);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<byte[]> Receive(int timeout = 500)
        {
            try
            {
                return await _deviceIo.ReadAsync(timeout);
            }
            catch (System.TimeoutException timeoutException)
            {
                throw new TimeoutException("Timeout expired", timeoutException);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
