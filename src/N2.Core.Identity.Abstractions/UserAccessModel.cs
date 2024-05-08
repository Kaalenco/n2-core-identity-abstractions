using System.Collections.ObjectModel;

namespace N2.Core.Identity;

public class UserAccessModel : IUserAccess
{
    public ICollection<RoleRight> RoleRights { get; set; } = new Collection<RoleRight>();
    public ICollection<UserRight> UserRights { get; set; } = new Collection<UserRight>();
    public ICollection<UserSelectItem> Assigned { get; set; } = new Collection<UserSelectItem>();
    public Guid OwnerId { get; set; }
    public string OwnerName { get; set; } = string.Empty;
}