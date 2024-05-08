﻿namespace N2.Core.Identity;

public sealed class UserRight
{
    public Guid UserId { get; set; } = Guid.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public bool Create { get; set; }
    public bool Read { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }
    public bool Design { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether to remove this record
    /// on the next update.
    /// </summary>
    public bool RemoveThisRecord { get; set; }
    public override string ToString() => DisplayName;
}