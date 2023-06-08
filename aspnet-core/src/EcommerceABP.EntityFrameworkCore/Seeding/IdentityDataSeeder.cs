using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace EcommerceABP.Seeding
{
    public class IdentityDataSeeder : ITransientDependency, IIdentityDataSeeder
    {
        protected IGuidGenerator GuidGenerator { get;}
        protected IIdentityRoleRepository RoleRepository { get; }
        protected IIdentityUserRepository UserRepository { get; }
        protected ILookupNormalizer LookupNormalizer { get; }
        protected IdentityUserManager UserManager { get; }
        protected IdentityRoleManager RoleManager { get; }
        protected ICurrentTenant CurrentTenant { get; }
        protected IOptions<IdentityOptions> IdentityOptions { get; }

        public IdentityDataSeeder(IGuidGenerator guidGenerator, IIdentityRoleRepository roleRepository, IIdentityUserRepository userRepository, ILookupNormalizer lookupNormalizer, IdentityUserManager userManager, IdentityRoleManager roleManager, ICurrentTenant currentTenant, IOptions<IdentityOptions> identityOptions)
        {
            GuidGenerator = guidGenerator;
            RoleRepository = roleRepository;
            UserRepository = userRepository;
            LookupNormalizer = lookupNormalizer;
            UserManager = userManager;
            RoleManager = roleManager;
            CurrentTenant = currentTenant;
            IdentityOptions = identityOptions;
        }

        [UnitOfWork]
        public virtual async Task<IdentityDataSeedResult> SeedAsync(string adminEmail, string adminPassword, Guid? tenantId = null)
        {
            using (CurrentTenant.Change(tenantId)) 
            {
                await IdentityOptions.SetAsync();
                var res = new IdentityDataSeedResult();
                //"admin' user
                                //tim kiem trong data co admin khong
                var adminUser = await UserRepository.FindByNormalizedUserNameAsync(LookupNormalizer.NormalizeName(adminEmail));

                if (adminUser != null)
                {
                    return res;
                }
                //Khong co thi tao moi mot cai IdentityUser -> (Name): UserName la Admin
                adminUser =  new IdentityUser(GuidGenerator.Create(), adminEmail, adminEmail, tenantId) { Name = "Admin" };

                (await UserManager.CreateAsync(adminUser,adminPassword,validatePassword:false)).CheckErrors();
                res.CreatedAdminUser = true;

                //"admin" role : quyen
                const string adminRoleName = "Admin";
                var adminRole = await RoleRepository.FindByNormalizedNameAsync(LookupNormalizer.NormalizeName(adminRoleName));

                if (adminRole == null) 
                {
                    adminRole = new IdentityRole(GuidGenerator.Create(), adminRoleName, tenantId) { IsStatic = true, IsPublic = true };

                    (await RoleManager.CreateAsync(adminRole)).CheckErrors();
                    res.CreatedAdminRole = true;
                }

                //Gan role vao user
                (await UserManager.AddToRoleAsync(adminUser,adminRoleName)).CheckErrors();
                return res;
            }
        }
    }
}
