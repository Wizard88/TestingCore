using System;
using System.Text.RegularExpressions;
using TestingCore.CommandAbstraction;
using TestingCore.Common;

namespace TestingCore.CommandImplementation
{
    internal class CommandSetConfiguration : ICommand
    {
        private int vectorGroupKey;

        public CommandSetConfiguration(WindingConfiguration primary, WindingConfiguration secondary, int displacement)
        {
            this.vectorGroupKey = GetVectorGroupKey(primary, secondary, displacement);
        }

        public CommandSetConfiguration(WindingConfiguration primary, int displacement)
        {
            this.vectorGroupKey = GetVectorGroupKey(primary, displacement);
        }

        public string GetKey()
        {
            return String.Format("RSV{0}", vectorGroupKey);
        }

        public bool IsExpected(string response)
        {
            return Regex.IsMatch(response, "V:[0-9]{3}");
        }

        private int GetVectorGroupKey(WindingConfiguration primary, WindingConfiguration secondary, int displacement)
        {
            int primaryKey = GetConfigurationKey(primary);
            int secondaryKey = GetConfigurationKey(secondary);

            return primaryKey * 16 + secondaryKey + displacement * 256;
        }

        private int GetVectorGroupKey(WindingConfiguration primary, int displacement)
        {
            int primaryKey = GetConfigurationKey(primary);

            return primaryKey * 16 + displacement * 256;
        }

        private int GetConfigurationKey(WindingConfiguration configuration)
        {
            switch (configuration)
            {
                case WindingConfiguration.D: return 1;
                case WindingConfiguration.Y: return 2;
                case WindingConfiguration.Yn: return 3;
                case WindingConfiguration.Z: return 4;
                case WindingConfiguration.Zn: return 5;
                default: throw new InvalidCastException();
            }
        }
    }
}