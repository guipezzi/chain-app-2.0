namespace ChainAppBack.Services
{
    public class UsersService : IUsersService
    {
        public async Task<string> Get()
        {
            await Task.Delay(1);
            return "Hello World!";
        }
    }
}
