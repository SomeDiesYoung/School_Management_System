using School_Management_System.Commands;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations;

public class GroupServices
{
    private readonly IGroupRepository _groupRepository;
    public GroupServices(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public void GroupComplicate(GroupCommand groupInfo)
    {
        groupInfo.Validate();
    }
}
