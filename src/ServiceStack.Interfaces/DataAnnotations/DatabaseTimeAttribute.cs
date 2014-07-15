using System;

namespace ServiceStack.DataAnnotations
{
    /// <summary>
    /// Used to indicate that a DateTimeOffset or DateTime property contains a
    /// database server timestamp which is automatically updated on insert or update.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DatabaseTimeAttribute : AttributeBase
    {
    }
}
