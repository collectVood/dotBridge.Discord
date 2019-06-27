using DotDiscord.Objects;

namespace DotDiscord
{
    public static class Extensions
    {
        public static string String(this StatusType status)
        {
            return status.ToString().ToLower();
        }
    }
}