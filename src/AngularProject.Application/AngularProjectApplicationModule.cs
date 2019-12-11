using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularProject.Authorization;

namespace AngularProject
{
    [DependsOn(
        typeof(AngularProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AngularProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AngularProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AngularProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
