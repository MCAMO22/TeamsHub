using TeamHubServiceUser.DTOs;

namespace TeamHubServiceUser.Gateways.Interfaces;

public interface ILogService
{
    public void SaveUserAction(UserActionDTO userAction);
}