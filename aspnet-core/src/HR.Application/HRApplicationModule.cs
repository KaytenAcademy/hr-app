using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HR.Authorization;

namespace HR
{
    [DependsOn(
        typeof(HRCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HRApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HRAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HRApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
