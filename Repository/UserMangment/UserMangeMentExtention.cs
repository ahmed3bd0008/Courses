using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository.Context;

namespace Repository.UserManement
{
    public  class UserMangeMenApplication:UserManager<AppUser>
    {
        private readonly IUserStore<AppUser> _userStrore;
        private readonly AppDbContext _appDbContext;

        public UserMangeMenApplication(
                IUserStore<AppUser> store,
                IOptions<IdentityOptions> optionsAccessor,
                IPasswordHasher<AppUser> passwordHasher,
                IEnumerable<IUserValidator<AppUser>> userValidators,
                IEnumerable<IPasswordValidator<AppUser>> passwordValidators,
                ILookupNormalizer keyNormalizer,
                IdentityErrorDescriber errors,
                IServiceProvider services,
                ILogger<UserManager<AppUser>> logger,
                 AppDbContext appDbContext 
                )
               
        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
                _userStrore=store;
                _appDbContext=appDbContext;
        }
        public async Task<List<AppUser>>GetAllUser()
        {
            return await _appDbContext.Users.Include(d => d.City)
                // .Include(d => d.Photos).Where(d=>d.Photos.Any(p=>p.IsMain==true))  //in case we want to get only user that have main Photo
                .Include(d => d.Photos)
                .ToListAsync();
        }
        public async Task<AppUser>GetUser(string Username)
        {
            return await _appDbContext.Users.Include(d => d.City)
                // .Include(d => d.Photos).Where(d=>d.Photos.Any(p=>p.IsMain==true))  //in case we want to get only user that have main Photo
                .Include(d => d.Photos).Where(d=>d.UserName==Username)
                .FirstOrDefaultAsync();
        }
      

    }
}