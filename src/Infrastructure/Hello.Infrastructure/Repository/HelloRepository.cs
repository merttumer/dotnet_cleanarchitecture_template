using Hello.Application.Repository;
using Hello.Domain;
using Hello.Infrastructure.Store;
using Microsoft.EntityFrameworkCore;

namespace Hello.Infrastructure.Repository
{
    public class HelloRepository : IHelloRepository
    {
        private readonly StoreContext storeContext;

        public HelloRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;

        }
        public async Task<User?> GetUser(int userId)
        {
            var user = await storeContext.Users
                .FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null) {
                return null;
            }

            return new User(user.Id, user.Name);
        }
    }
}