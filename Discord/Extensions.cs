using dotBridge.Discord.Objects;

namespace dotBridge.Discord
{
    public static class Extensions
    {
        public static string String(this StatusType status)
        {
            return status.ToString().ToLower();
        }
    }
}