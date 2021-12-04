using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
            return await _appDbContext.Users.Include(d=>d.City).ToListAsync();
        }
      

    }
}